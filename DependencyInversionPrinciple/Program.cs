using DependencyInversionPrinciple.Payments;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();

        }
    }
}
