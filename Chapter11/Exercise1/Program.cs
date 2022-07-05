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

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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

            var xelements = xdoc.Root.Elements()
                                    .Select(x => new { 
                                        Name = (string)x.Element("name"),
                                        Num = x.Element("teammembers")
                                    })
                                    .OrderByDescending(x=>x.Num.Value);

            Console.WriteLine(xelements.First().Name);
            
        }


        private static void Exercise1_4(string file, string newfile) {

            var element = new XElement("ballsport",
                            new XElement("name","サッカー",new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers",11),
                            new XElement("firstplayed",1863)
                            );

            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);

            //確認用
            
            /*
            foreach (var xnovelist in xdoc.Root.Elements()) {
                var name = xnovelist.Element("name");
                var kanji = xnovelist.Element("name").Attribute("kanji");
                var member = xnovelist.Element("teammembers");

                Console.WriteLine("{0}({1})：{2}人",name.Value,kanji.Value,member.Value);
            }
            */
        }
    }
}
