// See https://aka.ms/new-console-template for more information
using BasicMusicApp;
using System.Threading.Channels;

Console.WriteLine("Deseja executar o código do desafio?");
Console.Write("Se sim digite 'S': ");
string AnwserChallenge = Console.ReadLine()!;
bool ResultChallenge = AnwserChallenge == "S" ? true : false;

if (ResultChallenge)
{
    /*
     * Claro! Aqui estão quatro episódios do podcast Nerdcast que você pode gostar:
       A História da Guerra Fria: Este episódio aborda a história da Guerra Fria, desde o fim da Segunda Guerra Mundial até a queda do Muro de Berlim1.
       A História do RPG: Este episódio explora a história dos jogos de RPG, desde os primórdios até os dias atuais1.
       A História do Heavy Metal: Este episódio explora a história do Heavy Metal, desde suas raízes até os dias atuais1.
       A História do Rock: Este episódio explora a história do Rock, desde suas raízes até os dias atuais1.
        Espero que isso ajude!
     */
    
    Host hostJoaoMarcos = new Host("João Marcos");
    Podcast podcast = new Podcast(hostJoaoMarcos,"NerdCast");
    Episode episode1 = new Episode(60,1, "A História da Guerra Fria");
    episode1.AddGuests("Robson Marques");

    Episode episode2 = new Episode(58,2, "A História do RPG");
    episode2.AddGuests("Alessandro");

    Episode episode3 = new Episode(48,3, "A História do Heavy Metal");
    episode3.AddGuests("Maria Eduarda");
    episode3.AddGuests("Alexandre");

    Episode episode4 = new Episode(51,4, "A História do Rock");
    episode4.AddGuests("Pedro Joaquim");
    episode4.AddGuests("Maria Isis");

    podcast.AddEpisodes(episode2);    
    podcast.AddEpisodes(episode4);
    podcast.AddEpisodes(episode1);
    podcast.AddEpisodes(episode3);

    podcast.ShowDetails();

}
else
{
    /*
     * O Tempo
     * O Caminho
     * Ele Vive
     * Perfeito Amor 
     * Ingratidão
     * Preciso Voltar
     */
    Band banda = new Band("Oficina G3");
    Album albumOficina = new Album("O Tempo");

    Music musicOTempo = new Music("Tempo", banda, albumOficina, 3, true);
    Music musicOCaminho = new Music("O Caminho", banda, albumOficina, 3, true);
    Music musicEleVive = new Music("Ele Vive", banda, albumOficina, 3, true);
    Music musicPerfeitoAmor = new Music("Perfeito Amor", banda, albumOficina, 3, true);
    Music musicIngratidao = new Music("Ingratidão", banda, albumOficina, 3, true);
    Music musicPrecisoVoltar = new Music("Preciso Voltar", banda, albumOficina, 3, true);

    albumOficina.AddMusic(musicOTempo);
    albumOficina.AddMusic(musicOCaminho);
    albumOficina.AddMusic(musicEleVive);
    albumOficina.AddMusic(musicPerfeitoAmor);
    albumOficina.AddMusic(musicIngratidao);
    albumOficina.AddMusic(musicPrecisoVoltar);


    banda.AddAlbum(albumOficina);

    Console.Write("Deseja exibir somente o album? Pressione 'S' caso contrario: ");
    string exibSomenteAlbum = Console.ReadLine()!;
    bool exibAlbum = exibSomenteAlbum == "S" ? true : false;

    if (exibAlbum)
    {
        albumOficina.ShowAllMusics();
    }
    else
    {
        banda.ShowAlbuns();
    }

}






//music.ShowTechnicalInfo();
/*
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

numerosPares.ForEach(numero => Console.WriteLine(numero));
*/
