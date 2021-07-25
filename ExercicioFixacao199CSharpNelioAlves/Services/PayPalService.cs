using System;

namespace ExercicioFixacao199CSharpNelioAlves.Services
{
    public class PayPalService : IOnlinePaymentService
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
                throw new ApplicationException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
                throw new ApplicationException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
