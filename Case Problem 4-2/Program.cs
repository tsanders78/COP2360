﻿using System;
using System.Linq;
using static System.Console;
class MarshallsRevenue
{
    static void Main()
    {
        int INTERIOR_PRICE = 500;
        int EXTERIOR_PRICE = 750;
        string entryString;
        int numInterior;
        int numExterior;
        int revenueInterior;
        int revenueExterior;
        int total;
        bool isInteriorGreater;
        Write("Enter number of interior murals scheduled >> ");
        int month = int.Parse(ReadLine());
        entryString = ReadLine();
        numInterior = Convert.ToInt32(entryString);
        Write("Enter number of exterior murals scheduled >> ");
        entryString = ReadLine();
        numExterior = Convert.ToInt32(entryString);
        if (new[] { 12, 1, 2 }.Contains(month))
        {
            WriteLine("0 exterior murals are scheduled for a total of $0.00");
        }
        else
        {
            if (new[] {4,5,9,10 }.Contains(month))
            {
                EXTERIOR_PRICE = 699;
            }
            if (new[] { 7, 8 }.Contains(month))
            {
                INTERIOR_PRICE = 450;
            }
            revenueInterior = numInterior * INTERIOR_PRICE;
            revenueExterior = numExterior * EXTERIOR_PRICE;
            total = revenueInterior + revenueExterior;
            isInteriorGreater = numInterior > numExterior;
            WriteLine("{0} interior murals are scheduled for a total of {2}",
               numInterior, INTERIOR_PRICE.ToString("C"), revenueInterior.ToString("C"));
            WriteLine("{0} exterior murals are scheduled for a total of {2}",
               numExterior, EXTERIOR_PRICE.ToString("C"), revenueExterior.ToString("C"));
            WriteLine("Total revenue expected is {0}", total.ToString("C"));
            WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", isInteriorGreater);
        }
    }
}