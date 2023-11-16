using BeFaster.Runner.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BeFaster.App.Solutions.CHK
{
    public class CheckoutSolution
    {
        public int ComputePrice(string skus)
        {
            var items = StartShop();
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

            var item = items.FirstOrDefault();

            return 0;
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

        private static (string,int) ParseSkus(string skus)
        {
            if (String.IsNullOrEmpty(skus) || String.IsNullOrWhiteSpace(skus))
            {
                throw new ArgumentException("Invalid input.");
            }

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
