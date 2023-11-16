using BeFaster.Runner.Exceptions;
using System;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string skus)
        {
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
}

