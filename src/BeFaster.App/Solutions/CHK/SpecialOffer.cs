using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    public class SpecialOffer
    {
        public Item ItemOffer { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

        public SpecialOffer(Item itemOffer, int quantity, int price)
        {
            ItemOffer = itemOffer;
            Quantity = quantity;
            TotalPrice = price;
        }
    }
}
