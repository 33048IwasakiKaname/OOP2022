using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            Song[] songs = new Song[3];
            songs[0] = new Song("夜に駆ける", "YOASOBI", 180);
            songs[1] = new Song("もう少しだけ", "YOASOBI", 200);
            songs[2] = new Song("怪物", "YOASOBI", 150);
        }
    }
}
