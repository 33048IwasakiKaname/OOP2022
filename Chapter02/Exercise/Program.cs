using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            /*
            List<Song> songs = new List<Song>();
            var song1 = new Song("夜に駆ける", "YOASOBI", 180);
            songs.Add(song1);

            var song2 = new Song("もう少しだけ", "YOASOBI", 200);      
            songs.Add(song2);

            var song3 = new Song("怪物", "YOASOBI", 150);
            songs.Add(song3);
            */


            var songs = new Song[] {
                new Song("夜に駆ける", "YOASOBI", 180),
                new Song("もう少しだけ", "YOASOBI", 200),
                new Song("怪物", "YOASOBI", 150),
            };

            PrintSongs(songs);
        }

        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0}_{1}_{2:m\\:ss}",
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
