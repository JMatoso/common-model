using System;
using System.Collections.Generic;
using CommonModel.Models;

namespace CommonModel.Repositories
{
    public class BookRepository
    {
        public static List<Books> GetBooks(){
            var books = new List<Books>();

            books.Add(new Books {Id = 1, Book = "Looking For Alasca", Author = "John Green", Category = "Teenager Fiction", Released = DateTime.Now});
            books.Add(new Books {Id = 2, Book = "The Faults In Our Stars", Author = "John Green", Category = "Romance", Released = DateTime.Now});
            books.Add(new Books {Id = 3, Book = "The Perks Of Be A Wallflower", Author = "Stephen Chbosky", Category = "Teenager Fiction", Released = DateTime.Now});
            
            return books;
        }
    }
}