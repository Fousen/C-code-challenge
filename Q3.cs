using System;

namespace Assesment
{
    internal class Enrollment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total students placed in CS : ");
            int cs = int.Parse(Console.ReadLine());
            Console.WriteLine("Total students placed in MECH : ");
            int mech = int.Parse(Console.ReadLine());
            Console.WriteLine("Total students placed in MET : ");
            int met = int.Parse(Console.ReadLine());

            if (cs > mech && cs > met) Console.WriteLine("Highest placement CS");
            else if (mech > met && mech > cs) Console.WriteLine("Highest placement MECH");
            else if (met > mech && met > cs) Console.WriteLine("Highest placement MET");          
            else if (cs == mech) Console.WriteLine("Highest placement CS \nHighest placement MECH");
            else if (mech == met) Console.WriteLine("Highest placement MECH\nHighest placement MET");
            else if (cs == met) Console.WriteLine("Highest placement CS\nHighest placement MET");
            else Console.WriteLine("Highest placement CS\nHighest placement MECH\nHighest placement MET");           
        }
    }
}