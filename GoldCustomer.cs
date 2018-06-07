namespace FactoryPattern
{
    public class GoldCustomer : ICustomerFactory
    {
        public double ApplyDiscount(double amount)
        {
            return amount-50;
        }
    }
}