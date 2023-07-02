using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosGeneros(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList();
            foreach(var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasFiltradosPorGeneroMusical = musicas.Where(musicas => musicas.Genero.Contains(genero))
                                                            .Select(musicas => musicas.Artista)
                                                            .Distinct().ToList();

            Console.WriteLine($"Genero musical: {genero}");
            foreach (var artista in artistasFiltradosPorGeneroMusical)
            {
                Console.WriteLine($"-{artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musicas => musicas.Artista.Equals(nomeDoArtista))
                                           .Select(musicas => musicas.Nome).ToList();

            foreach(var musica in musicasDoArtista)
            {
                Console.WriteLine($"-{musica}");
            }
        }

        public static void FiltarPorTonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicasPorTonalidade = musicas.Where(musicas => musicas.Tonalidade.Equals(tonalidade))
                                              .Select(musicas => musicas.Nome);

            foreach (var musica in musicasPorTonalidade)
            {
                Console.WriteLine($"-{musica}");
            }
        }
    }
}
