namespace _003;

internal class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}

internal static class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (var i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);

            var type = data[0];
            var name = data[1];
            var time = data[2];

            var song = new Song
            {
                TypeList = type,
                Name = name,
                Time = time
            };

            songs.Add(song);
        }

        var typeList = Console.ReadLine();

        if (typeList == "all")
        {
            foreach (var song in songs) Console.WriteLine(song.Name);
        }
        else
        {
            var filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();
            foreach (var song in filteredSongs) Console.WriteLine(song.Name);
        }
    }
}