using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita_Ticket
{
    public class Ticket
    {   
        public int Numero { get; set; } = 0;
        public DateTime Date { get; } = DateTime.Now;
        public List<Product> Products { get; set; } = new List<Product>();
        public string Total 
        { 
            get 
            {
                return Products.Sum(p => double.Parse(p.precio)).ToString();
            } 
        }
    }
}
