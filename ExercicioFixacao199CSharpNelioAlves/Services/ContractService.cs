using System;
using System.Collections.Generic;
using ExercicioFixacao199CSharpNelioAlves.Entities;

namespace ExercicioFixacao199CSharpNelioAlves.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePayment;

        public ContractService(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public Contract ProcessContract(Contract contract, int months)
        {
            try
            {
                double amountPerMonth = contract.TotalValue / months;

                for (int i = 1; i <= months; i++)
                {
                    var dateAux = contract.Date.AddMonths(i);
                    double interest = _onlinePayment.Interest(amountPerMonth, i) + amountPerMonth;
                    double paymentFee = _onlinePayment.PaymentFee(interest);
                    contract.AddInstallment(new Installment(dateAux.Date, paymentFee + interest));
                }
                 
                return contract;
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException($"Method: ProcessContract, Error: {e.Message}");
            }
            catch (Exception e)
            {
                throw new Exception($"Method: ProcessContract, Error: {e.Message}");
            }
        }
    }
}
