using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            IEnumerable<Book> books;


            Console.WriteLine("出力したい西暦を入力 (-1で終了)");
            var year = int.Parse(Console.ReadLine());
            while (year != -1) {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }

            Console.Write("昇順(0)　/　降順(1)＿＿");
            var check = int.Parse(Console.ReadLine());

            if (check == 0) {
                books = Library.Books.Where(b => years.Contains(b.PublishedYear))
                                     .OrderBy(b=>b.PublishedYear);
            } else {
                books = Library.Books.Where(b => years.Contains(b.PublishedYear))
                                     .OrderByDescending(b => b.PublishedYear);
            }

            foreach (var book in books) {
                Console.WriteLine(book);
            }

            Console.WriteLine("");//改行

            foreach (var year2 in years) {
                Console.WriteLine(year2);
                foreach (var book2 in books.Where(b => b.PublishedYear == year2)) {
                    var category = Library.Categories.Where(b => b.Id == book2.CategoryId).First();
                    Console.WriteLine($"タイトル:{book2.Title},価格:{book2.Price},カテゴリ:{category.Name}");
                }

                Console.WriteLine("");//改行
            }

            var selected = Library.Books
                                  .Where(b=>years.Contains(b.PublishedYear))  
                                  .Join(Library.Categories,         //結合する2番目のシーケンス    
                                        book => book.CategoryId,    //対象シーケンスの結合キー
                                        category => category.Id,    //2番目のシーケンスの結合キー
                                        (book, category) => new {
                                            Title = book.Title,
                                            Category = category.Name,
                                            PublishedYear = book.PublishedYear,
                                            Price = book.Price
                                        }
                                  );

            foreach (var book in selected.OrderByDescending(b => b.PublishedYear)
                                         .ThenBy(b => b.Category)) {
                Console.WriteLine($"{book.PublishedYear},{book.Title},{book.Category},{book.Price}");
            }

            Console.WriteLine($"合計金額：{selected.Sum(b=>b.Price)}円");
        }
    }
}
