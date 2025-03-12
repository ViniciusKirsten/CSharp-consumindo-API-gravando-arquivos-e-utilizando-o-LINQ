using ScreenSound.Modelos;

//FILTRO PARA ORDENAR OS ARTISTAS POR NOME

namespace ScreenSound.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {                            //funcao anonima para a regra do order by       //funcao anonima para o select
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var atista in artistasOrdenados)
            {
                Console.WriteLine($"- {atista}");
            }
        }

        internal static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string v)
        {
            throw new NotImplementedException();
        }
    }
}
