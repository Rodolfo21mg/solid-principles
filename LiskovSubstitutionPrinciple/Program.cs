using LiskovSubstitutionPrinciple.Payments;
using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();

        }
    }
}
