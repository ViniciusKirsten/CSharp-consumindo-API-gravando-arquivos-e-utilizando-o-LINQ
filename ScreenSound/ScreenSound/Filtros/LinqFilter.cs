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
}

