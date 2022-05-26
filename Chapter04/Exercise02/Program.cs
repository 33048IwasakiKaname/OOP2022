using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1996,12),
                new YearMonth(1997,4),
                new YearMonth(2000,1),
                new YearMonth(2001,5),
                new YearMonth(2002,7),
                new YearMonth(2012,6),
                new YearMonth(2100,10),
                new YearMonth(2800,11),
            };
            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("----------------------");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("----------------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("----------------------");

            //4.2.6
            Exercise2_6(ymCollection);

        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            //①月で昇順に出力
            foreach (var ym in ymCollection.OrderBy(ym => ym.Month)) {
                Console.WriteLine(ym);
            }

            //区切り
            Console.WriteLine("--------------------");

            //②偶数年のみ昇順に出力
            foreach (var ym in ymCollection.Where(ym => ym.Year % 2 ==0).OrderBy(ym=>ym.Year)) {
                Console.WriteLine(ym);
            }

            //区切り
            Console.WriteLine("--------------------");

            //③うるう年のみを出力
            foreach (var ym in ymCollection.Where(ym=> DateTime.IsLeapYear(ym.Year))){
                Console.WriteLine(ym);
            }

            //区切り
            Console.WriteLine("--------------------");

            //④すべての年から12月に一番近い月を出力
            var data = ymCollection.Max(ym=>ym.Month);
            Console.WriteLine(data);
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {

            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;

        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var check = FindFirst21C(ymCollection);
            if(check != null) {
                Console.WriteLine(check);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
