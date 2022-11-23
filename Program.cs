namespace LineComparisionProblem
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("----------------------------------");
            //Usecase-1
            double firstline, secondline;
            UC_1Calculate uC_1Calculate = new UC_1Calculate(3, 4, 5, 6);
            uC_1Calculate.Calculate();
            Console.WriteLine("----------------------------------");

            //Usecase-2
            UC_2CheckEquality line = new UC_2CheckEquality(5, 6, 7, 8);
            line.Checking();
            UC_2CheckEquality line1 = new UC_2CheckEquality(1, 2, 3, 4);
            line1.Checking();
            if (line == line1)
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
            Console.WriteLine("-----------------------------------");

            //Usecase-3
            UC_3ComparingLines Line = new UC_3ComparingLines(2,3,4,5);
            Line.Comparing();
            UC_3ComparingLines Line1 = new UC_3ComparingLines(1,3,5,7);
            Line1.Comparing();
            int val = line.GetHashCode();
            Console.WriteLine(val + "  " + Line + "  " + Line1);
            if (val == 0)
            {
                Console.WriteLine("line one is Equal");
            }
            if (val == 1)
            {
                Console.WriteLine("Line one is Greater");
            }
            else
            {
                Console.WriteLine("Line one is Smaller");
            }
        }
    }
}