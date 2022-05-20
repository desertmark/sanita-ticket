using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita_Ticket
{
    public class Product
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public int quantity { get; set; } = 1;

    }
}
