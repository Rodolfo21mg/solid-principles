using DependencyInversionPrinciple.Factory;
using DependencyInversionPrinciple.Model;
using System;

namespace DependencyInversionPrinciple.Payments
{
    class PaymentProcess
    {

        public void Pay(string id)
        {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);

        }

    }
}
