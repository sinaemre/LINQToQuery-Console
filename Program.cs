using LINQToQuery.Infrastructure.Context;
using LINQToQuery.Models.Concrete;
using Microsoft.EntityFrameworkCore;

using (var db = new AppDbContext())
{
    #region Select
    //var genres = db.Genres.Select(x => new
    //{
    //    x.Id,
    //    x.Name,
    //    x.CreatedDate,
    //    x.Status
    //}).ToList();

    //foreach (var genre in genres)
    //{
    //    Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nCreated Date: {genre.CreatedDate}\nStatus: {genre.Status}\n==================");
    //}

    #endregion

    #region Where - 1
    ////Fiyatı 7 ile 14 arasında olan kitapları listeleyelim.
    //var books = db.Books.Where(x => x.Price >= 7 && x.Price <= 14)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n==========================");
    //}

    #endregion

    #region Where - 2
    ////Id'si 1 ile 5 arasında olan yazarları sıralayalım.
    //var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <= 5)
    //                        .Select(x => new
    //                        {
    //                            x.Id,
    //                            x.FullName,
    //                            x.CreatedDate,
    //                            x.Status
    //                        }).ToList();

    //foreach (var author in authors)
    //{
    //    Console.WriteLine($"Id: {author.Id}\nFull Name: {author.FullName}\nCreated Date: {author.CreatedDate}\nStatus: {author.Status}\n================");
    //}
    #endregion

    #region OrderBy - 1
    ////Id'si 1 ile 10 arasında olan yazarları isimlerine a'dan z'ye sıralayalım.
    //var authors = db.Authors.Where(x => x.Id >= 1 && x.Id <= 10)
    //                        .OrderBy(x => x.FirstName)
    //                        .Select(x => new
    //                        {
    //                            x.Id,
    //                            x.FullName,
    //                            x.CreatedDate,
    //                            x.Status
    //                        }).ToList();

    //foreach (var author in authors)
    //{
    //    Console.WriteLine($"Id: {author.Id}\nFull Name: {author.FullName}\nCreated Date: {author.CreatedDate}\nStatus: {author.Status}\n================");
    //}
    #endregion
    #region OrderBy - 2
    ////Fiyatı 10'dan büyük olan kitapların, fiyat bilgisine göre çoktan aza sıralanması
    //var books = db.Books.Where(x => x.Price >= 10)
    //                    .OrderByDescending(x => x.Price)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Price,
    //                        x.Title,
    //                        x.Status
    //                    }).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region First - 1
    //Kitap tablosundaki birinci kaydı getirelim.
    //var book = db.Books.First();
    //Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    #endregion

    #region First - 2
    ////Kitap tablosundaki 51. kaydı getirelim.
    ////Veri tabanında verilen şartı şağlayan bir kayıt bulamazsa hata fırlatır.
    //try
    //{
    //    var book = db.Books.First(x => x.Id == 51);
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");

    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Böyle bir kitap bulunamadı!");
    //}
    #endregion

    #region FirstOrDefault - 1
    //Kitap tablosundaki 51. kaydı getirelim.
    //FirstOrDefault methodu sorgu sonucunda dönen veri kümesi boş ise First() methodu gibi hata fırlatmaz, null döner!
    //var book = db.Books.FirstOrDefault(x => x.Id == 51);

    //if (book != null)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    //else
    //{
    //    Console.WriteLine("Böyle bir kitap bulunamadı!");
    //}
    #endregion

    #region FirstOrDefault - 2
    ////Tür adı "History" olan kaydı getirelim.
    //var genre = db.Genres.FirstOrDefault(x => x.Name == "History");
    //if (genre != null)
    //{
    //    Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nStatus: {genre.Status}");
    //}
    //else { Console.WriteLine("Böyle bir tür bulunamadı!"); }

    #endregion

    #region Find
    //Sadece ID'ler üzerinde arama yapar ve bulduğu ilk sonucu size döndürür.
    //var genre = db.Genres.Find("history");
    //if (genre != null)
    //{
    //    Console.WriteLine($"Id: {genre.Id}\nName: {genre.Name}\nStatus: {genre.Status}");
    //}
    //else { Console.WriteLine("Böyle bir tür bulunamadı!"); }
    #endregion

    #region Take
    ////Fiyatı en yüksek 5 kitabı listeleyelim.
    //var books = db.Books.OrderByDescending(x => x.Price)
    //                    .Take(5)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region Take And Skip
    ////Türü "history" olan ve fiyatı en yüksek 4. kitabı getirin.
    //var books = db.Books.Where(x => x.GenreId == "history")
    //                    .OrderByDescending(x => x.Price)
    //                    .Skip(3)
    //                    .Take(1)
    //                    .Select(x => new
    //                    {
    //                        x.Id,
    //                        x.Title,
    //                        x.Price,
    //                        x.Status
    //                    }).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region Contains
    ////İçerisinde "a" harfi geçen kitapları getirin.
    //var books = db.Books.Where(x => x.Title.Contains("a")).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region StartsWith
    ////"B" harfi ile başlayan kitapları getirin.
    //var books = db.Books.Where(x => x.Title.StartsWith("B")).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region EndsWith
    ////"E" harfi ile biten kitapları getirin.
    //var books = db.Books.Where(x => x.Title.EndsWith("E")).ToList();

    //foreach (var book in books)
    //{
    //    Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}\nPrice: {book.Price}\nStatus: {book.Status}\n===============");
    //}
    #endregion

    #region Any
    ////Veri tablosunda türü "history" olan kitap var mı?
    //var result = db.Books.Any(x => x.GenreId == "history");

    //if (result)
    //    Console.WriteLine("Türü 'history' olan kitaplar vardır!");
    //else
    //    Console.WriteLine("Türü 'history' olan kitap yoktur!");
    #endregion

    //Aggregate Functions

    #region Count
    ////var result = db.Books.Count();
    //Console.WriteLine($"Veri tabanındaki kitap sayısı: {result}");
    #endregion

    #region Sum
    ////Veri tabanındaki kitapların fiyatlarının toplamını getirelim.
    //var result = db.Books.Sum(x => x.Price);
    //Console.WriteLine("Bütün kitapların fiyatlarının toplamı: " + result + " TL");
    #endregion

    #region Min&Max
    ////Fiyatı en ecuz ve en pahalı kitapların fiyatrını gösterelim.
    //var mostExpensive = db.Books.Max(x => x.Price);
    //var cheapest = db.Books.Min(x => x.Price);

    //Console.WriteLine($"En ucuz kitabın fiyatı: {cheapest} TL\nEn pahalı kitabın fiyatı: {mostExpensive} TL");
    #endregion

    #region GroupBy With Count - 1
    ////Kitapları türlerine göre gruplayalım.
    //var result = db.Books.GroupBy(x => x.Genre.Name)
    //                     .Select(x => new
    //                     {
    //                         GenreName = x.Key, //Key => Gruplamak istediğiniz sütun
    //                         Count = x.Count()
    //                     }).ToList();

    //foreach (var item in result)
    //{
    //    Console.WriteLine($"Genre Name: {item.GenreName}\nBook Count: {item.Count}\n==================");
    //}
    #endregion
    #region GroupBy With Count - 2
    ////2'den fazla kitabı olan yazarları İsim ve soyisimlerine göre gruplayalım.
    //var result = db.BookAuthors.GroupBy(x => x.Author.FirstName + " " + x.Author.LastName)
    //                           .Select(x => new 
    //                           {
    //                               AuthorName = x.Key,
    //                               Count = x.Count()
    //                           })
    //                           .Where(x => x.Count >= 2)
    //                           .OrderByDescending(x => x.Count)
    //                           .ToList();

    //foreach (var item in result)
    //{
    //    Console.WriteLine($"Author Name: {item.AuthorName}\nBook Count: {item.Count}\n==============");
    //}
    #endregion
    #region GroupBy With Sum
    ////Kategorilerine göre kitapların toplam tutarı
    //var result = db.Books.GroupBy(x => x.Genre.Name)
    //                     .Select(x => new
    //                     {
    //                         GenreName = x.Key,
    //                         TotalPrice = x.Sum(z => z.Price)
    //                     }).ToList();


    //foreach (var item in result)
    //{
    //    Console.WriteLine($"Genre Name: {item.GenreName}\nTotal Price: {item.TotalPrice} TL\n============");
    //}
    #endregion

}


