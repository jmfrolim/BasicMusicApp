using BasicMusicApp;
using System.Threading.Channels;

public class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int DurationTotal => musics.Sum(music => music.Durantion);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAllMusics()
    {
        Console.WriteLine($"Lista de musicas do album: {Name}:\n");
        musics.ForEach(music => Console.WriteLine($"Musica: {music.Name}"));
        Console.WriteLine($"Para ouvir o album completo precisa de {DurationTotal}");
    }
}