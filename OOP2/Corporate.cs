using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel Müşteri
    //Miras inheritance 
    public class Corporate : Customer 
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
