using ScreenSound.Modelos;

//FILTRO PARA BUSCAR TODOS OS GENEROS CRIADOS
namespace ScreenSound.Filtros;
internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
                                                    //funcao anonima
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- { genero}");
        }
    }
    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        //assim teria que digitar exatamente o que eu preciso
        //var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero == genero).Select(musicas => musicas.Artista).Distinct().ToList();

        //Assim ele vai pegar apenas o que contém, parecido com o Like do SQL
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musicas => musicas.Artista).Distinct().ToList();

        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    //EXIBIR MUSICAS POR ARTISTAS
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}

