using Section14208_Interfaces.Entities;
using System.Collections.Generic;

namespace Section14208_Interfaces.Services
{
    public class ContractService
    {

        private readonly IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int numberInstallments)
        {
            double baseInterest = contract.TotalValue / numberInstallments;
            List<Installment> installmentsList = new(numberInstallments);

            for (int i = 1; i <= numberInstallments; i++)
            {
                double interest = _onlinePaymentService.Interest(baseInterest, i);
                interest = _onlinePaymentService.PaymentFee(interest);

                var installmentDate = contract.Date.AddMonths(i);
                installmentsList.Add(new Installment(installmentDate, interest));
            }

            contract.Installment = installmentsList;
        }
    }
}