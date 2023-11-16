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
            var shopService = new ShopService();
            var items = shopService.StartShop();
            var specialOffers = shopService.StartSpecialOffers(items);

            string name;
            int quantity;

            try
            {
                (name, quantity) = ParseSkus(skus);
            }
            catch(NullReferenceException)
            {
                return 0;
            }
            catch (ArgumentException)
            {
                return -1;
            }

            var item = items.FirstOrDefault(x => x.Name.Equals(name));

            if(item == null)
            {
                return -1;
            }

            return shopService.ProcessPrice(item, quantity, specialOffers);
        }

        private static (string,int) ParseSkus(string skus)
        {
            if (String.IsNullOrEmpty(skus) || String.IsNullOrWhiteSpace(skus))
            {
                throw new NullReferenceException("Invalid input.");
            }

            string pattern = @"^(\d*)?([A-Za-z])$";

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




