namespace Section14208_Interfaces.Services
{
    public class PayPalService : IOnlinePaymentService
    {
        public PayPalService()
        {
        }

        public double Interest(double amount, int month)
        {
            return amount * (1 + (0.01 * month));
        }

        public double PaymentFee(double amount)
        {
            return amount += amount * 0.02;
        }
    }
}