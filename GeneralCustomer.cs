namespace FactoryPattern
{
    public class GeneralCustomer : ICustomerFactory
    {
        public double ApplyDiscount(double amount)
        {
            return amount;
        }
    }
}