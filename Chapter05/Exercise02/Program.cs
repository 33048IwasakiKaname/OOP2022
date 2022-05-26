using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            Console.Write("数値入力：");
            int.TryParse(Console.ReadLine(), out var num);
            Console.WriteLine("{0:N0}", num);
        }
    }
}
