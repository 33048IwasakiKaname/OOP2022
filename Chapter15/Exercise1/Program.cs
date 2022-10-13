using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var MaxPrice = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == MaxPrice);
            Console.WriteLine($"タイトル：{book.Title},　値段：{book.Price},　年度：{book.PublishedYear}");
        }

        private static void Exercise1_3() {
            var selected = Library.Books
                                  .GroupBy(b => b.PublishedYear)
                                  .OrderBy(o=>o.Key);

            foreach (var book in selected) {
                Console.WriteLine($"{book.Key}年　{book.Count()}冊");
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books
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
                                         .ThenByDescending(b => b.Price)) {
                Console.WriteLine($"{book.PublishedYear} {book.Price} {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                                     .Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => category.Name)
                                     .Distinct();

            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {

            var selected = Library.Books
                                  .GroupBy(b => b.CategoryId)
                                  .Join(Library.Categories,             
                                        book => book.Key,    
                                        category => category.Id,    
                                        (book, category) => new {
                                            Title = book.Key,
                                            CategoryName = category.Name,
                                            CategoryID = category.Id,
                                        }
                                  );

            foreach (var book1 in selected.OrderBy(b=>b.CategoryName)) {
                Console.WriteLine($"#{book1.CategoryName}");
                foreach (var book2 in Library.Books.Where(b=>book1.CategoryID == b.CategoryId)){
                    Console.WriteLine($" {book2.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books.Where(b => b.CategoryId == categoryId)
                                      .GroupBy(b => b.PublishedYear)
                                      .OrderBy(b => b.Key);

            foreach (var group in groups) {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var book in group) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories.GroupJoin(Library.Books,
                                                          c => c.Id,
                                                          b => b.CategoryId,
                                                          (c, b) => new {
                                                              CategoryName = c.Name,
                                                              Count = b.Count()
                                                          }) 
                                           .Where(x => x.Count >= 4);

            foreach (var category in query) {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
