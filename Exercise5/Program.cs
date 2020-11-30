using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CISS_ProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = new[] { "Smith", "Jhones", "Wallace", "Amos", "Lindegaard", "Smith", "Rooney", "Evans", "Ferdinand", "Carrick", "Rooney", "Giggs", "Young", "Persie", "Welbeck", "Rooney" };

            Console.WriteLine("Source Array:\n");

            foreach(var name in names){
                Console.WriteLine(name.ToString());
            }


            IEnumerable<string> sortedNames = Exercise5(names);
            var stored = sortedNames.OrderBy(s => s);

            Console.WriteLine("\nSorted Array:\n");

            foreach(var name in stored){
                Console.WriteLine(name.ToString());
            }

            Console.Write("\nPress a key to continue..");
            Console.ReadKey();


        }

         /// <summary>
        /// return the passed collection sorted first by frequency of the names and then alphabetically
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>

        static IEnumerable<string> Exercise5(IEnumerable<string> names)
        {
            return names;
        }        
    
    }
}
