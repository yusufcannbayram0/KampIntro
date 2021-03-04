using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras - inheritance ( Customer class'ında olan özellikler bu class'ta da vardır )
    class IndividualCustomer :Customer // Bireysel Müşteri - Gerçek Müşteri
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
