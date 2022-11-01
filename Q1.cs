using System;

namespace Assesment
{
    public class Rectangular_Array
    {
        public static int GetArray(int n)
        {
            int[,] array = new int[n,n];
            for(int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if(i == j)  array[i,j] = 0; 
                    else if (i>j) array[i,j] = -1;
                    else if (i<j) array[i,j] = 1;
                    
                }
                
            }
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            
            return 0;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetArray(num));
        }
    }
}
