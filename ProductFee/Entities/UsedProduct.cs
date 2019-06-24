using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProductFee.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufatureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return
                $"{Name} (used) $ " +
                $"{Price.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Manufacture date: {ManufatureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
