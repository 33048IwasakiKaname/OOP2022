using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("----------------------");

            Exercise3_2(text);
            Console.WriteLine("----------------------");

            Exercise3_3(text);
            Console.WriteLine("----------------------");

            Exercise3_4(text);
            Console.WriteLine("----------------------");

            Exercise3_5(text);
            Console.WriteLine();
        }

        private static void Exercise3_1(string text) {

            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数：{0}",spaces);
        }


        private static void Exercise3_2(string text) {

            //文字置き換え
            text = text.Replace("big", "small");
            Console.WriteLine(text);
        }


        private static void Exercise3_3(string text) {

            //単語数
            var words = text.Split(' ');
            Console.WriteLine(words.Length);
        }


        private static void Exercise3_4(string text) {

            var words = text.Split(' ');
            foreach (var msg in words.Where(msg=> msg.Length <= 4)) {
                Console.WriteLine(msg);
            }
        }


        private static void Exercise3_5(string text) {
            /*
            var sb = new StringBuilder();
            var words = text.Split(' ');

            foreach (var msg in words) {
                sb.Append(msg);
            }

            var message = sb.ToString();
            Console.WriteLine(message);
            */

            var array = text.Split(' ').ToArray();
            if(array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var str = sb.ToString(); ;Console.WriteLine(str);
            }
        }
    }
}
