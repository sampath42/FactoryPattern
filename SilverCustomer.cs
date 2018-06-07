namespace FactoryPattern
{
    public class SilverCustomer : ICustomerFactory
    {
        public double ApplyDiscount(double amount)
        {
            return amount-30;
        }
    }
}