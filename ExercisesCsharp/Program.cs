using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var fruits1=new string[3];

            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

            fruits1 = fruits;

            int[,] chessboard=new int[8,8];

            for (int i = 0; i <8; i++)
            {
                
                for (int j = 0; j <8; j++)
                {
                    Console.Write(chessboard[i,j]);
                }
                Console.WriteLine();
            }

            // The Three Parts of a LINQ Query: 
            //  1. Data source. 
            int[] intNumbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation. 
            // numQuery is an IEnumerable<int> 
            var numQuery =
                from num in intNumbers
                where (num % 2) == 0
                select num;

            // 3. Query execution. 
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            
            var tenNumbers=new int[10]{0,1,2,3,4,5,6,7,8,9};

            

            foreach (var item in tenNumbers)
            {
                Console.Write("{0,2}",item);
            }

            Console.WriteLine();

            for (int i = 0; i < tenNumbers.Length; i++)
            {
                Console.Write("{0,2}",tenNumbers[i]);
            }

            int?[] nullableInts = { null};

            Console.WriteLine();

            for (int i = tenNumbers.Length-1; i >=0; i--)
            {
                Console.Write("{0,2}", tenNumbers[i]);
            }

            foreach (var item in nullableInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
              



           
        }
    }
}
