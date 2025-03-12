using System.Text.Json.Serialization;

namespace ScreenSound.Modelos
{
    internal class Musica
    {
        //para que ele possa pegar dentro da minha API a informação do campo que apontamos, neste caso (song)
        [JsonPropertyName("song")] //esse atributo é conhecido como anotação
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duração { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        //criado apenas para testar o retorno
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duração: {Duração}");
            Console.WriteLine($"Genero: {Genero}");

        }
    }
}
