using System;

namespace LiskovSubstitutionPrinciple.Payments
{
    class CreditCard : NubankCard
    {

        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite OK!");
        }

    }
}
