using System;

namespace BankHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.CustomerName = "Aybuke";
            customer.CustomerSurname = "Firat";
            customer.Id = 21;

            Customer customer2 = new Customer();

            customer2.CustomerName = "Cansu";
            customer2.CustomerSurname = "Tutar";
            customer2.Id = 12;

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerList(customer);


        }
    }
}
