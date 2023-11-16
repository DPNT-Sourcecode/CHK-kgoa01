using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    public class ShopService
    {
        public List<Item> StartShop()
        {
            return new List<Item>
            {
                new Item("A", 50),
                new Item("B", 30),
                new Item("C", 20),
                new Item("D", 15)
            };
        }

        public List<SpecialOffer> StartSpecialOffers(List<Item> items)
        {
            return new List<SpecialOffer>()
            {
                new SpecialOffer(items[0], 3, 130),
                new SpecialOffer(items[1], 2, 45),
            };
        }

        public int ProcessPrice(Item item, int quantity, List<SpecialOffer> offers)
        {
            var offer = offers.FirstOrDefault(o => o.ItemOffer == item);

            if (offer != null)
            {
                int timesOfOffer = quantity / offer.Quantity;
                int numberItemsNotOffer = quantity % offer.Quantity;

                return timesOfOffer * offer.TotalPrice + numberItemsNotOffer * item.Price;
            }

            return item.Price * quantity;
        }
    }
}
