using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMusicApp
{
    public class Music
    {
        public string Name { get; set; }
        public Band Artist { get; set; }
        public string Album { get; set; }
        public int Durantion { get; set; }

        public bool Available { get; set; }
        public string BasicDescription => $"A musica {Name} pertence à banda {Artist}";

        public Music(string name,Band artist,Album album,int duration,bool available)
        {
            this.Name = name;
            this.Artist = artist;
            this.Album = album.Name;
            this.Durantion = duration;
            this.Available = available;
        }

        public void ShowTechnicalInfo()
        {
            string ResultAvailabele = Available == true ? "Sim" : "Não";
            Console.WriteLine($"Musica: {this.Name}");
            Console.WriteLine($"Artista: { this.Artist.Name}");
            Console.WriteLine($"Duração: { this.Durantion}");
            Console.WriteLine($"Album: { this.Album}");
            Console.WriteLine($"Disponivel? {ResultAvailabele}");
            Console.WriteLine($"Descrição banda completa {BasicDescription}");
        }
    }
}
