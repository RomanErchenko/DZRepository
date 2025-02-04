
using DZ1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //Задання. 
   // Створити клас Book, визначити всі властивості якими він буде володіти,
   // конструктор або конструктори які можна буде застосувати при створюванню книг.
   // Написати метод Open який на консоль виведе такий тест - Ви почали читати книгу
   // такогого автора таоїто назви, загальна кількість сторінок така то
   // СТворити в клієнському коді дві книги і відкрити їх на читання

    class Program
    {
        //// Створюємо статичний метод Open  який приймає змінну типа Book
        //public  static void Open(Book book)
        //{

        // Console.WriteLine("Ви почали читати книгу");
        // Console.WriteLine($"Назва книги: {book.BookName},Автор:{book.Author},Жанр:{book.Genre},Сторінки:{book.Pages}, Ціна:{book.Price}, Анотація:{book.Anotation}"); 
        //}



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Створюємо єкземпляри book1 book2,та запрвнюємо поля
            Book book1 = new Book("Лангольери", "Стивен Кинг")
            {
                Pages = 150,
                Price = 10000,
                Anotation="Гарно",
                Genre= "Жахи",
                YearOfProduce=1985,
               

            };
            Book book2 = new Book("Некрономікон", "Лавкрафт")
            {
                Pages = 290,
                Price = 1000,
                Anotation = "Гарно",
                Genre = "Фантастика",
                YearOfProduce = 1853,
               
            };
            // Викликаємо метод Open для читання книг
            book1.Open();
            Console.WriteLine(new string('-',30));
            book2.Open();
            
            Console.ReadKey();
        }
    }
}





