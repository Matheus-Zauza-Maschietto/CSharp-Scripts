using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        foreach(var musica in musicas)
           Console.WriteLine(musica);

        LinqFilter.FiltarPorTonalidade(musicas, "C");

        Console.WriteLine("Tipos de generos");
        LinqFilter.FiltrarTodosGeneros(musicas);
        Console.WriteLine();
        
        Console.WriteLine("Artistas Ordenados");
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        Console.WriteLine();

        Console.WriteLine("Artistas Por Genero Musical");
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        Console.WriteLine();

        Console.WriteLine("Musicas Por Artista");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        Console.WriteLine();

        var musicasPreferidas = new MusicasPreferidas("Daniel");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[12]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[17]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[31]);

        musicasPreferidas.GerarArquivoJson();
        Console.WriteLine(musicasPreferidas);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não foi possivel realizar a requisição");
    }
}
