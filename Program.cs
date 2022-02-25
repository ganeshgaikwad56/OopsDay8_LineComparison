using System;

namespace LineComparisonOops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Line Comparison Program");
            //LineComparisonUC4 line=new LineComparisonUC4();
            //line.CompairTwoLines();
            //LineComparisonUC4 line1 = new LineComparisonUC4();
            //line1.Comparelines();

            // LineComparisonUC1 line = new LineComparisonUC1();
            // line.Length_Line();

            //CheckEqualityUC2 line = new CheckEqualityUC2();
            //line.CheckEquality();
            //CheckEqualityUC2 line1 = new CheckEqualityUC2();
            //line1.function_check();

            LineComparisonUC3 line = new LineComparisonUC3();
            line.CompairTwoLines();
            LineComparisonUC3 line1 = new LineComparisonUC3();
            line1.Comparelines();

        }
    }
}
