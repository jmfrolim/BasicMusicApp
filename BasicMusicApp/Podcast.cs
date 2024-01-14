public class Podcast
{
    private List<Episode> _episodes = new List<Episode>();
    public Host Host { get; }
    public string Name { get; }
    public int TotalEpisodios => _episodes.Count;
    public Podcast(Host host, string name)
    {
        Host = host;
        Name = name;
    }

    public void AddEpisodes(Episode episode)
    {
        _episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Lista de Episodios do Podcast {Name}: ");
        Console.WriteLine($"Host {Host.Name}\n");
        foreach (var ep in _episodes.OrderBy(ep=>ep.Order))
        {
            Console.WriteLine($"{ep.Summary}");
        }
        Console.WriteLine($"\nO total de episodios {TotalEpisodios}\n");
    }
}