using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClassesExercises
{
    internal class SignPositiveOrNegative
    {
        public static int[] CountSign(int[] numbers1)
        {

         //   List<int> numb = new List<int>(numbers1);


            int totalPositive = 0;
            int totalNegative = 0;
            int count = 0;


            for (int index =  0; index <  numbers1.Length; index++)

            {
              //  int result = numbers1[index];
               
                
             //   totalPositive += result;
                if (numbers1[index] > 0)
                {

                    //totalPositive = numbers1.Length;
                    totalPositive += 1;

                }
                else
                {
                    totalNegative += 1;


                }
               // count = numbers1[index];
               // count++;
            }

            //totalPositive = totalPositive += numbers1;
            // totalPositive++;
            // count += totalPositive;

            int[] resturnValues = new int[2];

            resturnValues[0] = totalPositive;
            resturnValues[1] = totalNegative;

            return resturnValues;
        }

        public static Totals CountSign2(int[] numbers1)
        {

            //   List<int> numb = new List<int>(numbers1);


            int totalPositive = 0;
            int totalNegative = 0;
            int count = 0;


            for (int index = 0; index < numbers1.Length; index++)

            {
                //  int result = numbers1[index];


                //   totalPositive += result;
                if (numbers1[index] > 0)
                {

                    //totalPositive = numbers1.Length;
                    totalPositive += 1;

                }
                else
                {
                    totalNegative += 1;


                }
                // count = numbers1[index];
                // count++;
            }

            //totalPositive = totalPositive += numbers1;
            // totalPositive++;
            // count += totalPositive;

            Totals totals = new Totals();

            var dt = new DateTime().AddYears;
            Console.WriteLine(dt.ToString());


            totals.TotalPositive = totalPositive;
            totals.TotalNegative = totalNegative;

            return totals;
        }


    }
}

