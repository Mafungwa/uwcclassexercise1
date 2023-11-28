using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    internal class Vowels
    {
        private static bool IsAVowel(char letter)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (int index = 0; index < vowels.Length; index++)
            {
                if (letter == vowels[index])
                { 
                     return true;
                }
            }
            return false;
        }
      //  public static string RemoveAllTheVowels(string letters) {

            //string a =letters.Remove(letters);
            

          /*  for (int index = 0; index < letters.Length; index ++)
            {
                char letter = letters[index];
                
            }

          /*  foreach (char letter in letters)
            {
                if (a.Contains(letter))
                {
                    Console.WriteLine(a);
                };
            } 

            return a;*/
       // }
    }
}
