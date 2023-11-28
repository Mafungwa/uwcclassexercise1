namespace ClassesExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 9 };
            bool isOddNumber = OddNumbers.CheckOddNumbers(numbers);

            if (isOddNumber)
            {
                Console.WriteLine("The array contains an odd number.");
            }
            else
                Console.WriteLine("The array contains an even number.");

            //string[] letters = new string[] { "The is something in the water" };


            int[] numbers1 = {-1, 2, 4, 6, 9};
            int[] numbers3 = SignPositiveOrNegative.CountSign(numbers1);
            Console.WriteLine(numbers3[0]);
            Console.WriteLine(numbers3[1]);

            Totals numbers4 = SignPositiveOrNegative.CountSign2(numbers1);
            Console.WriteLine(numbers4.TotalPositive);
            Console.WriteLine(numbers4.TotalNegative);



        }
    }
}
