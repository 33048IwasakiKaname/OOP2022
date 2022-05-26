using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            string word1, word2;

            Console.Write("1つ目：");
            word1 = Console.ReadLine();

            Console.Write("2つ目：");
            word2 = Console.ReadLine();

            if (String.Compare(word1,word2,ignoreCase:true) == 0) {
                Console.WriteLine("一致しています");
            } else {
                Console.WriteLine("一致していません");
            }
        }
    }
}
