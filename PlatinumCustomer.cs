namespace FactoryPattern
{
    public class PlatinumCustomer : ICustomerFactory
    {
        public double ApplyDiscount(double amount)
        {
            return amount-100;
        }
    }
}