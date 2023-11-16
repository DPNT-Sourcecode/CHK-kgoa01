using BeFaster.Runner.Exceptions;
using System;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public class CheckoutSolution
    {
        public int ComputePrice(string skus)
        {
            var items = StartShop();
            var specialOffers = StartSpecialOffers(items);

            if (String.IsNullOrEmpty(skus))
            {
                return -1;
            }
        }

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

        public List<SpecialOffers> StartSpecialOffers(List<Item> items)
        {
            return new List<SpecialOffers>()
            {
                new SpecialOffers(items[0], 3, 130),
                new SpecialOffers(items[1], 2, 45),
            };
        }
    }
}



