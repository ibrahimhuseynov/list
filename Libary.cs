using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Libary
    {
       List<Book> Books = new List<Book>();
        public List<Book> FindAllBooksByName(string name)
        {
            return Books.FindAll(x=>x.Name.Contains(name));
        }
        public void RemoveAllBooksByNme(string name)
        {
            Books.RemoveAll(x => x.Name.Contains(name));
        }
        public List<Book> SearchBooks(string name)
        {
            return Books.FindAll(x => x.Name.Contains(name) || x.AuthorName.Contains(name));
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return Books.FindAll(x=>x.PageCount>=min&&x.PageCount<=max);
        }
        public void RemoveBookByCode(string name)
        {
            Book result=Books.Find(x=>x.Code==name);   
        }

    }
}
