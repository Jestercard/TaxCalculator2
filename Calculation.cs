using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator2
{
    public static class Calculation
    {
        public static double TaxCalculation(List<Bracket> brackets, double income)
        {
            double taxOwed = 0;
            foreach(var b in brackets)
            {
                if(income >= b.Min)
                {
                    if(income > b.Max)
                    {
                        taxOwed += (b.Max - b.Min + 1) * b.Rate;
                    }
                    else
                    {
                        taxOwed += (income - b.Min + 1) * b.Rate;
                    }
                }
            }
            return taxOwed;
        }
    }
}
