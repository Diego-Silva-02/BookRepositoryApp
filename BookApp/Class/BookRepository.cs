using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookApp.Interfaces;

namespace BookApp
{
    public class BookRepository : IRepository<Book>
    {
        public List<Book> BookList = new List<Book>();

        public void Atualize(int id, Book entity)
        {
            BookList[id] = entity;
        }

        public void Delete(int id)
        {
            BookList[id].Exclude();
        }

        public void Insert(Book book)
        {
            BookList.Add(book);
        }

        public List<Book> List()
        {
            return BookList;
        }

        public int NextId()
        {
            return BookList.Count;
        }

        public Book ReturnById(int id)
        {
            return BookList[id];
        }
    }
}
