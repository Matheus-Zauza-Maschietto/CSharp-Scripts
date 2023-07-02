using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas= new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new { nome = Nome, musicas = ListaDeMusicasFavoritas });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json criado com sucesso! \nPath: {Path.GetFullPath(nomeDoArquivo)}");
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        foreach(var musica in ListaDeMusicasFavoritas)
            stringBuilder.AppendLine(musica.Nome);

        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }
}
