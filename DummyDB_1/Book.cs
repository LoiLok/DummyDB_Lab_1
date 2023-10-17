using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_1
{
    class Book
    {
        public uint Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set;  }
        public uint ShelfNumber { get; set;  }
        public uint CabinetNumber { get; set; }
        public Reader Reader { get; set; }
        public DateTime BorrowTime { get; set; }

        public Book(uint id, string author, string title, int yearOfPublication, uint shelfNumber, uint cabinetNumber, Reader reader, DateTime borrowTime)
        {
            Id = id;
            Author = author;
            Title = title;
            YearOfPublication = yearOfPublication;
            ShelfNumber = shelfNumber;
            CabinetNumber = cabinetNumber;
            Reader = reader;
            BorrowTime = borrowTime;
        }

        public Book()
        {
        }
    }
}
