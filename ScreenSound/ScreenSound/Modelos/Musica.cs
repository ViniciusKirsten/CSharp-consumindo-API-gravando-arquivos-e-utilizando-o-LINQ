using System.Text.Json.Serialization;

namespace ScreenSound.Modelos
{
    internal class Musica
    {
        //para que ele possa pegar dentro da minha API a informação do campo que apontamos, neste caso (song)
        [JsonPropertyName("song")] //esse tributo é conhecido como anotação
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

    }
}
