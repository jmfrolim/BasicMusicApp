public class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album albun)
    {
        albums.Add(albun);
    }

    public void RemoveAlbum() { }

    public void ShowAlbuns()
    {
        Console.WriteLine($"Lista de albuns:\n");
        albums.ForEach( a => Console.WriteLine($"{a.Name} ({a.DurationTotal})") );
    }
}
