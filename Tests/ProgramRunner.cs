using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

// Programs swap the global Console.In/Out, so tests must never run concurrently.
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Tests;

/// <summary>
/// Compiles an exercise's Program.cs in memory (the exercises have no .csproj and share
/// namespaces like Ex001 across modules) and runs it with redirected console I/O.
/// </summary>
public static class ProgramRunner
{
    // Same global usings the SDK adds for a console app with ImplicitUsings enabled.
    private const string GlobalUsings = """
        global using System;
        global using System.Collections.Generic;
        global using System.IO;
        global using System.Linq;
        global using System.Net.Http;
        global using System.Threading;
        global using System.Threading.Tasks;
        """;

    private static readonly string RepoRoot = FindRepoRoot();

    private static readonly MetadataReference[] References =
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
        .Split(Path.PathSeparator)
        .Select(path => MetadataReference.CreateFromFile(path))
        .ToArray();

    private static readonly Dictionary<string, MethodInfo> EntryPoints = new();

    /// <param name="program">Exercise folder relative to the repo root, e.g. "005-Arrays/Ex001".</param>
    /// <returns>Console output with "\n" line endings and trailing whitespace trimmed from every line.</returns>
    public static string Run(string program, string input = "")
    {
        var entryPoint = GetEntryPoint(program);

        var originalIn = Console.In;
        var originalOut = Console.Out;
        var output = new StringWriter();

        try
        {
            Console.SetIn(new StringReader(input));
            Console.SetOut(output);
            entryPoint.Invoke(null, entryPoint.GetParameters().Length == 0 ? null : [Array.Empty<string>()]);
        }
        finally
        {
            Console.SetIn(originalIn);
            Console.SetOut(originalOut);
        }

        var lines = output.ToString().ReplaceLineEndings("\n").Split('\n').Select(line => line.TrimEnd());
        return string.Join("\n", lines).TrimEnd('\n');
    }

    private static MethodInfo GetEntryPoint(string program)
    {
        if (EntryPoints.TryGetValue(program, out var cached)) return cached;

        var sourcePath = Path.Combine(RepoRoot, program, "Program.cs");
        var compilation = CSharpCompilation.Create(
            program.Replace('/', '_'),
            [
                CSharpSyntaxTree.ParseText(File.ReadAllText(sourcePath), path: sourcePath),
                CSharpSyntaxTree.ParseText(GlobalUsings)
            ],
            References,
            new CSharpCompilationOptions(OutputKind.ConsoleApplication, nullableContextOptions: NullableContextOptions.Enable));

        using var assembly = new MemoryStream();
        var result = compilation.Emit(assembly);
        Assert.True(result.Success,
            string.Join("\n", result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error)));

        var entryPoint = Assembly.Load(assembly.ToArray()).EntryPoint!;
        EntryPoints[program] = entryPoint;
        return entryPoint;
    }

    private static string FindRepoRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir is not null && !File.Exists(Path.Combine(dir.FullName, "Directory.Build.props"))) dir = dir.Parent;
        return dir?.FullName ?? throw new DirectoryNotFoundException("Repository root not found");
    }
}
