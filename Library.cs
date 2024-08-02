using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson17
{
    public class Library
    {
        private Book[] Books=new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books,Books.Length+1);
            Books[Books.Length-1]=book;
        }
        public void FindAllBooksByName(string name)
        {
            Book[] FindBooks = new Book[0];
            foreach(Book book in Books)
            {
                if(book.Name==name)
                {
                    Array.Resize(ref FindBooks,FindBooks.Length+1);
                    FindBooks[FindBooks.Length-1]=book;
                }
            }
        }
        public void FindBookByCode(string code)
        {
            Book book1;
            foreach(Book book in Books)
            {
                if(book.BookCode==code)
                {
                   System.Console.WriteLine(book);
                }
            }

        }

        public Book[] FindAllBookbyPageCountRange(int min , int max)
        {
            Book[] FABbPCR=new Book[0];
            foreach (Book item in Books)
            {
                if(item.PageCount>=min && item.PageCount<=max)
                {
                    Array.Resize(ref FABbPCR,FABbPCR.Length+1);
                    FABbPCR[FABbPCR.Length-1]=item;
                }
            }
            return FABbPCR;
        } 
    }
}