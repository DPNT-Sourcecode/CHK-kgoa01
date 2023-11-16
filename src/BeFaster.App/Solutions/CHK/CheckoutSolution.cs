using BeFaster.Runner.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
            var i = new Item("teste", 1);
            var items = i.StartShop();
            var specialOffers = StartSpecialOffers(items);

            string name;
            int quantity;

            try
            {
                (name, quantity) = ParseSkus(skus);
            }
            catch 
            {
                return -1;
            }

            var item = items.FirstOrDefault(x => x.Name.Equals(name));

            if(item == null)
            {
                return -1;
            }

            return ProcessPrice(item, quantity, specialOffers);
        }

        private int ProcessPrice(Item item, int quantity, List<SpecialOffer> offers)
        {
            var offer = offers.FirstOrDefault(o => o.ItemOffer == item);

            if(offer != null)
            {
                int timesOfOffer = quantity / offer.Quantity;
                int numberItemsNotOffer = quantity % offer.Quantity;

                return timesOfOffer * offer.TotalPrice + numberItemsNotOffer * item.Price;
            }

            return item.Price * quantity;
        }

       

        

        private static (string,int) ParseSkus(string skus)
        {
            /*if (String.IsNullOrEmpty(skus) || String.IsNullOrWhiteSpace(skus))
            {
                throw new ArgumentException("Invalid input.");
            }*/

            string pattern = @"^(\d+)([A-Za-z])$";

            var regex = new Regex(pattern);

            Match match = regex.Match(skus);

            if (match.Success)
            {
                int quantity = int.Parse(match.Groups[1].Value);
                string item = match.Groups[2].Value;

                return (item, quantity);
            }
            else
            {
                throw new ArgumentException("Invalid input.");
            }
        }
    }
}

