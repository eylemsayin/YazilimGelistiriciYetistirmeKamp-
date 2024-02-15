using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Gerçek Müşteri
    public class Individual: Customer //Gerçek müşteri bir müşteridir demek inheritance(kalıtım,miras)
    {
      
      
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
