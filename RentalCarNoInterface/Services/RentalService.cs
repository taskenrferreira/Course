using RentalCarNoInterface.Entities;
using System;

namespace RentalCarNoInterface.Services {
    class RentalService {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {
            //Uma locadora brasileira de carros cobra um valor por hora para locações de até
            //12 horas.Porém, se a duração da locação ultrapassar 12 horas, a locação será
            //cobrada com base em um valor diário. Além do valor da locação, é acrescido no
            //preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20 %
            //para valores até 100.00, ou 15 % para valores acima de 100.00.Fazer um
            //programa que lê os dados da locação(modelo do carro, instante inicial e final da
            //locação), bem como o valor por hora e o valor diário de locação. O programa
            //deve então gerar a nota de pagamento(contendo valor da locação, valor do
            //                imposto e valor total do pagamento) e informar os dados na tela. Veja os
            //exemplos.

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            Invoice invoice = new Invoice(basicPayment, tax);
            carRental.Invoice = invoice;
        }
    }
}
