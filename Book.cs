using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson17
{
    public class Book
    {
        public string Name {get; set;}
        public string AuthorName {get; set;}
        public long PageCount {get; set;}
        public string BookCode {get; set;}
        public void Code (Book book , int sira)
        {
           string k = book.Name.Substring(0,2);
           string y ="";
          for(int i=0;i<k.Length;i++)
          {
            y+=char.ToUpper(k[i]);
          }
           sira.ToString();
           string code = y+sira;
           System.Console.WriteLine(code);
           BookCode=code;
        }
        public override string ToString()
        {
            return $"Adi : {Name} Sehife sayi : {PageCount} Yazicisi : {AuthorName} Kodu : {BookCode}";
        }
    }
}