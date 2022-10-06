using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            var books = Library.Books;


            Console.WriteLine("出力したい西暦を入力");
            var year = int.Parse(Console.ReadLine());
            while (year != -1) {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }

            Console.Write("昇順(0)　/　降順(1)＿＿");
            var check = int.Parse(Console.ReadLine());

            if (check == 0) {
                books = Library.Books.OrderBy(b=>b.PublishedYear)
                                     .Where(b => years.Contains(b.PublishedYear));
            } else {
                books = Library.Books.OrderByDescending(b => b.PublishedYear)
                                     .Where(b => years.Contains(b.PublishedYear));
            }

            foreach (var book in books) {
                Console.WriteLine(book);
            }

            Console.WriteLine("");//改行

            foreach (var year2 in years) {
                Console.WriteLine(year2);
                foreach (var book2 in books.Where(b=>b.PublishedYear == year2)) {
                    var category = Library.Categories.Where(b=>b.Id == book2.CategoryId).First();
                    Console.WriteLine($"タイトル:{book2.Title},価格:{book2.Price},カテゴリ:{category.Name}");                  
                }

                Console.WriteLine("");//改行
            }
        }
    }
}
