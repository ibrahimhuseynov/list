using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Book
    {
        public int _code=0;
        private string _title;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }  
         public string Code
        {
            get
            {
                return _title;
            }
            set
            {
                _title = check(value);
            }
        }
        public string check(string value)
        {
            return (char.ToUpper(Name[0])+char.ToUpper(Name[1]) +_code).ToString(); 
        }
       
    }
      

}
