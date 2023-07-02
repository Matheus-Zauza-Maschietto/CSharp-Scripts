using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos;

internal class GameOfTronesPerson
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    [JsonPropertyName("gender")]
    public string Genero { get; set; }

    [JsonPropertyName("culture")]
    public string Cultura { get; set; }

    [JsonPropertyName("born")]
    public string DataNascimento { get; set; }

    [JsonPropertyName("died")]
    public string DataFalecimento { get; set; }

    [JsonPropertyName("titles")]
    public List<string>? Titulos { get; set; }

    [JsonPropertyName("aliases")]
    public List<string>? Apelidos { get; set; }

    [JsonPropertyName("father")]
    public string Pai { get; set; }

    [JsonPropertyName("mother")]
    public string Mae { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome} \nGenero: {Genero} \nCultura: {Cultura} \nData de Nascimento: {DataNascimento} \nData de Falêciamento: {DataFalecimento} \nTitulos: {Titulos.ToString()} \nApelidos: {Apelidos.ToString()} \nPai: {Pai} \nMãe: {Mae}";
    }
}
