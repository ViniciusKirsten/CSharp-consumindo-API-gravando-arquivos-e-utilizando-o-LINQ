
//FILTRO PARA ORDENAR OS ARTISTAS POR NOME
using ScreenSound.Modelos;

namespace ScreenSound.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {                            //funcao anonima para a regra do order by       //funcao anonima para o select
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        }
    }
}
