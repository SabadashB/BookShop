using BL.Data.Interfaces;
using BL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Data.Mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksPublisher _booksPublisher = new MockPublisher();
        public IEnumerable<Book> Books 
        {
            get
            {
                return new List<Book>
                {
                    new Book
                    {
                        bookName = "Гаррі Поттер та в'язник Азкабану",
                        author = "Дж. К. Роулинг",
                        shortDesc = "3-тя книга циклу про Гаррі Поттера",
                        longDesc = "Пригоди Гаррі Поттера тривають. Разом з Роном і Герміоною, своїми найкращими друзями, він уже третій рік навчається у Ґогвортській школі чарівників.",
                        pagesCount = 343,
                        price = 200,
                        img = "",
                        available = true,
                        isFavorite = true,
                        Publisher = _booksPublisher.allPublishers.First()
                    },
                    new Book
                    {
                        bookName = "Зелена миля",
                        author = "Стівен Кінг",
                        shortDesc = "Нова книга від короля жахів",
                        longDesc = "Пол Еджкомб — колишній наглядач федеральної в’язниці штату Луїзіана «Холодна гора», а нині — мешканець будинку для літніх людей.",
                        pagesCount = 423,
                        price = 210,
                        img = "",
                        available = true,
                        isFavorite = true,
                        Publisher = _booksPublisher.allPublishers.Last()
                    },
                    new Book
                    {
                        bookName = "Шерлок Холмс, увесь збірник",
                        author = "Артур Конан Дойль",
                        shortDesc = "Увесь сбірник розповідей про детектива №1",
                        longDesc = "1887 року в «Бітонському різдвяному альманасі» з'явилася друком повість «Етюд у багряних тонах» нікому тоді не відомого автора – лікаря Артура Конан Дойла.",
                        pagesCount = 675,
                        price = 300,
                        img = "",
                        available = true,
                        isFavorite = true,
                        Publisher = _booksPublisher.allPublishers.Last()
                    }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookID)
        {
            throw new NotImplementedException();
        }
    }
}
