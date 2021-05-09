namespace LiskovSubstitutionPrinciple.Payments
{
    interface IPaymentInstrument
    {

        void Validate();
        void CollectPayment();

    }
}
