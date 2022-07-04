using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }


        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Num = x.Element("teammembers")
                                    });
            foreach (var sportList in xelements) {
                Console.WriteLine("{0}-{1}人", sportList.Name, sportList.Num.Value);
            }
        }


        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name").Attribute("kanji"),
                                        Day = x.Element("firstplayed"),
                                    })
                                    .OrderBy(x=>x.Day.Value);
            foreach (var sportsList in xelements) {
                Console.WriteLine("{0}({1})",sportsList.Name,sportsList.Day.Value);
            }
        }


        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);

            var maxmember = xdoc.Root.Elements("teammembers").Max();

            Console.WriteLine(maxmember.Elements("name"));
        }


        private static void Exercise1_4(string file, string newfile) {

        }
    }
}
