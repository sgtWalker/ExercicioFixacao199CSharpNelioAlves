using System;

namespace ExercicioFixacao199CSharpNelioAlves.Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            try
            {
                //payment fee is 2% of amount
                return amount * 0.02;
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException($"Method: PaymentFee, Error: {e.Message}");
            }
            catch (Exception e)
            {
                throw new Exception($"Method: PaymentFee, Error: {e.Message}");
            }
        }
        public double Interest(double amount, int month)
        {
            try
            {
                //Interest is 1% monthly
                return (amount * 0.01) * month;
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException($"Method: Interest, Error: {e.Message}");
            }
            catch (Exception e)
            {
                throw new Exception($"Method: Interest, Error: {e.Message}");
            }
        }
    }
}
