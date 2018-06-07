using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RegisterCustomers();
            var customer = Factory<ICustomerFactory>.Create(CustomerType.PlatinumCustomer.ToString());
            var discountAmount = customer.ApplyDiscount(1000);
            Console.WriteLine(discountAmount);
        }   

        static void RegisterCustomers()
        {
            Factory<ICustomerFactory>.Register<GeneralCustomer>(CustomerType.GeneralCustomer.ToString());
            Factory<ICustomerFactory>.Register<SilverCustomer>(CustomerType.SilverCustomer.ToString());
            Factory<ICustomerFactory>.Register<GoldCustomer>(CustomerType.GoldCustomer.ToString());
            Factory<ICustomerFactory>.Register<PlatinumCustomer>(CustomerType.PlatinumCustomer.ToString());
        }     
    }
}
