﻿using System;
using System.Collections.Generic;

namespace Orders_AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();
            Dictionary<string, decimal> productsTotalPrice = new Dictionary<string, decimal>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "buy")
                {
                    break;
                }

                string[] parts = line.Split();
                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                

                if (priceByProduct.ContainsKey(product))
                {
                    priceByProduct[product] = price;
                    quantityByProduct[product] += quantity;
                    decimal totalPrice = priceByProduct[product] * quantityByProduct[product];
                    productsTotalPrice[product] = totalPrice;
                }
                else
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                    decimal totalPrice = priceByProduct[product] * quantityByProduct[product];
                    productsTotalPrice.Add(product, totalPrice);
                }
            }

            foreach (var kvp in productsTotalPrice)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
            
        }
    }
}
