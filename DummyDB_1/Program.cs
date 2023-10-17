using DummyDB_1;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Dummy_DB_1
{
    class Program
    {
        public static void Main()
        {
            List<Reader> readers = new List<Reader>
            {
                new Reader
                {
                    Id = 1,
                    Name = "Петров П.П."
                },
                new Reader
                {
                    Id = 2,
                    Name = "Романов Р.Р."
                },
                new Reader
                {
                    Id = 3,
                    Name = "Иванов И.И."
                }
            };
            List<Book> books = new List<Book>
            {
                new Book()
                {
                    Id = 1,
                    Author = "Булгаков М.А.",
                    Title = "Мастер и Маргарита",
                    YearOfPublication = 1928,
                    ShelfNumber = 1,
                    CabinetNumber = 1,
                    Reader = readers[0],
                    BorrowTime = new DateTime(2022,01,01)
                },
                new Book()
                {
                    Id = 2,
                    Author = "Достоевский Ф.М.",
                    Title = "Преступление и наказание",
                    YearOfPublication = 1866,
                    ShelfNumber = 1,
                    CabinetNumber = 2
                },
                new Book()
                {
                    Id = 3,
                    Author = "Адамс Дуглас",
                    Title = "Автостопом по галактике",
                    YearOfPublication = 1978,
                    ShelfNumber = 2,
                    CabinetNumber = 1,
                    Reader = readers[2],
                    BorrowTime = new DateTime(2023,01,01)
                }
            };
            foreach(Book book in books)
            {

                if (book.Reader != null)
                {
                    Console.WriteLine("Взята - " + book.Author + " " + book.Title + " " + book.ShelfNumber + " " + book.CabinetNumber + " " + book.Reader.Name + " " + $"{book.BorrowTime.ToString("d")}");
                }
                else
                {
                    Console.WriteLine("В библиотеке - " + book.Author + " " + book.Title + " " + book.ShelfNumber + " " + book.CabinetNumber);
                }

            }
        }
    }
}