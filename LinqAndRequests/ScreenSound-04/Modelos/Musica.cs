using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    private int _tonalidade { get; set; }
    public string Tonalidade { get => TraducaoDeTonalidade[_tonalidade]; set {} }

    [JsonIgnore]
    private static readonly Dictionary<int, string> TraducaoDeTonalidade = new Dictionary<int, string>()
    {
        {0,  "C" },
        {1,  "C#"},
        {2,  "D" },
        {3,  "D#"},
        {4,  "E" },
        {5,  "F" },
        {6,  "F#"},
        {7,  "G" },
        {8,  "G#"},
        {9,  "A" },
        {10, "A#"},
        {11, "B" },
    };

    public override string ToString()
    {
        return $"Artista: {Artista} \nMúsca: {Nome} \nDuração em segundos: {Duracao/1000} \nGênero musical: {Genero} \nTonalidade: {Tonalidade}\n";
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine();
    }
}
