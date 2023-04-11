using System;

namespace AdvancedManufacturingCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double annualDemand = 10000; // Units per year
            double orderCost = 200; // Cost per order
            double holdingCostPerUnit = 3.5; // Cost per unit per year

            double eoq = CalculateEOQ(annualDemand, orderCost, holdingCostPerUnit);
            double totalCost = CalculateTotalCost(annualDemand, eoq, orderCost, holdingCostPerUnit);

            Console.WriteLine($"Economic Order Quantity (EOQ): {eoq} units");
            Console.WriteLine($"Total Cost: ${totalCost}");
        }

        static double CalculateEOQ(double annualDemand, double orderCost, double holdingCostPerUnit)
        {
            return Math.Sqrt((2 * annualDemand * orderCost) / holdingCostPerUnit);
        }

        static double CalculateTotalCost(double annualDemand, double eoq, double orderCost, double holdingCostPerUnit)
        {
            double totalOrderCost = (annualDemand / eoq) * orderCost;
            double totalHoldingCost = (eoq / 2) * holdingCostPerUnit;

            return totalOrderCost + totalHoldingCost;
        }
    }
}
