using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras - inheritance ( Customer class'ında olan özellikler bu class'ta da vardır )
    class CorporateCustomer :Customer // Tüzel Müşteri  
    {

        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
