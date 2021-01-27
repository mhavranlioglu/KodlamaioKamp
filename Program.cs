using System;

namespace ClassMetodDemo
{
    class Program
    {
        private static object customer;

        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Id = 1;
            customer.MusteriNo = "123456";
            customer.Adi = "Ali";
            customer.Soyadi = "Havranlıoğlu";
            customer.TcNo = "12345678910";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.List(customer);
        }
    }
}
