//requisição da nossa API - HttpClient é um tipo já criado dentro do C#
using (HttpClient client = new HttpClient())
{
	try
	{
        //await - para ele esperar a tarefa ser concluida
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
	catch (Exception ex)
	{
		Console.WriteLine($"Temos um problema: {ex.Message}");
	}
}
//vamos utilizar esse pacote apenas dentro desse pacote por isso não colocamos ponto e virgula no final do using