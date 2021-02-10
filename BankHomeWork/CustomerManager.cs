using System;
using System.Collections.Generic;
using System.Text;

namespace BankHomeWork
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Musteri Eklendi.." + customer.Id);

        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Musteri Silindi.." + customer.Id);
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(" ---Musteriler--- " + customer.CustomerName + customer.CustomerSurname + customer.Id);
        }
    }
}
