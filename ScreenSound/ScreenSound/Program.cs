//requisição da nossa API - HttpClient é um tipo já criado dentro do C#
using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
	try
	{
        //await - para ele esperar a tarefa ser concluida
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        Console.WriteLine(resposta);

		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta); //Estamos deserializando o objeto, sendo assim estamos
                                                                          //tirando o tipo que ele retorna no Json e colocando
                                                                          //para o tipo que precisamos
       //Exemplos que eu posso utilizar após fazer a desserialização
        Console.WriteLine(musicas.Count); //adicionando um count e manipulando esse dados
        
        //musicas[1998].ExibirDetalhesDaMusica(); //buscando a musica pelo indice
        
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);//Chamando a minha classe que criei para filtro
        
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "rock");

        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");


    }
    catch (Exception ex)
	{
		Console.WriteLine($"Temos um problema: {ex.Message}");
	}
}
//vamos utilizar esse pacote apenas dentro desse pacote por isso não colocamos ponto e virgula no final do using