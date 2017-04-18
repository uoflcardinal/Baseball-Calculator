using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {   //Author: Brian Wood
        //Date: 4/18/2017

        static void Main(string[] args)
        {
            //Welcomes user.
            Console.WriteLine("Welcome to Batting Average Calculator!");
            
            //Declaration of variable and request for user to enter a number.           
            int input;
            Console.Write("Enter the number of times at bat: ");
            //Sets input to number entered by user.
            input = Convert.ToInt32(Console.ReadLine());

            //Sets a integer array named playerStat with size of whatever input is equal to entered by user.
            int[] playerStat = new int [input];

            //Prints four options to the console for theuser to choose from.
            Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");

            //Prints result for at bat allowing user to choose option the number of times inputed at bat.
            for (int i = 0; i < input; i++)
            {
                Console.Write("Result for at-bat {0}:", i);
                //Takes result chosen by user for each loop until input is reached for length of the array.
                playerStat[i] = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine();//break in line in the console.

            //this loop determine which elements for the length of the array are not zero and sums the number of elements not their values.
            int add = 0;    
            foreach (int element in playerStat)
            {
                if (element > 0)
                {
                    add++;
                }
            }
                int sum = playerStat.Sum();//Sums elements in the array entered by the user.
                double timesOnBase = Convert.ToDouble(add);//Converts number of elements not equal to zero calculated into a double.
                double totalBases = Convert.ToDouble(sum);//Converts to double the total sum calculated from arrays elements.
                double numatBats = Convert.ToDouble(input);//Converts to double the original input entered by the user for number of times at bat.
                double slugPer = totalBases / numatBats;//Calculates slugging percentage by diving total bases by number of at bats.
                double batAvg = timesOnBase / numatBats;//Calculates batting average by dividing times on base by number of at bats.
                Console.WriteLine("Batting average: {0}", batAvg);//Prints batting average to the console.
                Console.Write("Slugging Percentage: {0} \n\n", slugPer);//Prints slugging percent to the console.
        }
    }
}
