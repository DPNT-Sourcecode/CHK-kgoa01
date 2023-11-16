using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    internal class SpecialOffers
    {
        public Item ItemOffer { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public SpecialOffers(Item itemOffer, int quantity, decimal price)
        {
            ItemOffer = itemOffer;
            Quantity = quantity;
            Price = price;
        }
    }
}
