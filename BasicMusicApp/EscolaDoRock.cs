using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMusicApp
{
    class EscolaDoRock
    {
        public string Titulo;
        public int AnoLancamento;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        }
    }

}
