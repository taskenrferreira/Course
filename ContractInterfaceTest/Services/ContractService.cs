using System;
using ContractInterfaceTest.Entities;

namespace ContractInterfaceTest.Services {
    class ContractService {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentServices) {
            _onlinePaymentService = onlinePaymentServices;
        }

        public void ProcessContract(Contract contract, int months) {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
