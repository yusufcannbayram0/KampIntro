using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerçek - Tüzel müşteriler birbirleri yerine kullanılamaz. Gerçek-Tekil / Tüzel-Şirket

            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerNo = "12345";
            individualCustomer.FirstName = "Yusuf Can";
            individualCustomer.LastName = "Bayram";
            individualCustomer.TcNo = "1111111111111";

            // Kodlama.io
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Id = 2;
            corporateCustomer.CustomerNo = "54321";
            corporateCustomer.CompanyName = "Kodlama.io";
            corporateCustomer.TaxNo = "1234567890";



            Customer customer = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);
        }
    }
}
