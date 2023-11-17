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
            var itemsStock = shopService.StartShop();
            var specialOffers = shopService.StartSpecialOffers(itemsStock);

            var selectedItems = new Dictionary<char, int>();

            try
            {
                selectedItems = ParseSkus(skus);
            }
            catch(NullReferenceException)
            {
                return 0;
            }
            catch (ArgumentException)
            {
                return -1;
            }

            var validatedItems = new Dictionary<Item, int>();
            
            foreach(var it in selectedItems)
            {
                var item = itemsStock.FirstOrDefault(x => x.Name.Equals(it.Key.ToString()));

                if(item == null)
                {
                    return -1;
                }

                validatedItems.Add(item, it.Value);
            }

            return shopService.ProcessPrice(validatedItems, specialOffers);
        }

        private static Dictionary<char,int> ParseSkus(string skus)
        {
            if (String.IsNullOrEmpty(skus) || String.IsNullOrWhiteSpace(skus))
            {
                throw new NullReferenceException("Invalid input.");
            }

            string pattern = @"^[A-Z]$";

            var regex = new Regex(pattern);

            Match match = regex.Match(skus);

            if (match.Success)
            {
                var items = new Dictionary<char, int>();

                foreach(char it in skus)
                {
                    if (items.ContainsKey(it))
                    {
                        items[it]++;
                    }
                    else
                    {
                        items.Add(it, 1);
                    }
                }

                return items;
            }
            else
            {
                throw new ArgumentException("Invalid input.");
            }
        }
    }
}





