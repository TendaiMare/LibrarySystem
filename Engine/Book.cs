using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Book
    {
        public Book( int id,string name,string author)
        {
            ID = id;
            Name = name;
            Author = author;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
