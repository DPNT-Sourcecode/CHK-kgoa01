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

        public SpecialOffers StartSpecialOffers(Item itemOffer, int quantity, int price)
        {
            return new SpecialOffers(itemOffer, quantity, price);
        }
    }
}


