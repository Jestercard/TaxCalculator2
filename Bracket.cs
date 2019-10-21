namespace TaxCalculator2
{
    public class Bracket
    {
        //properties
        public double Min { get; set; }
        public double Max { get; set; }
        public double Rate { get; set; }

        //constructor
        public Bracket(double min, double max, double rate)
        {
            this.Min = min;
            this.Max = max;
            this.Rate = rate;
        }
    }
}
