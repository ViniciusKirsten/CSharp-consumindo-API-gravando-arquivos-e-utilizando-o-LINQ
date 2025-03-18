using System;
using System.Text.Json; // para utilizar o Serialize
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome {get; set;}

        //Não precisei adicionar o using, pois estão dentro do mesmo namespace
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome){
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine("");
        }

        //FORMA PARA EXPORTAR OS MEUS DADOS PARA JSON
        public void GerarArquivoJson()
        {
            string  json = JsonSerializer.Serialize(new //neste caso é um objeto anonimo
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            
            File.WriteAllText(nomeDoArquivo, json); //para criar o Json com as informações acima
            Console.WriteLine($"Arquivo {nomeDoArquivo} criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
