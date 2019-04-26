using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Book
    {
        public Book( int id,string name,string author,int quantity)
        {
            ID = id;
            Name = name;
            Author = author;
            Quantity = quantity;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }

        public void IncreamentQuantity()
        {
            Quantity += 1;
        }
        public void DecreamentQuantity()
        {
            Quantity -= 1;
        }
    }
}
