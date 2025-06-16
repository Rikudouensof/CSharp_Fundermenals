using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundermenals.Basics.Collections
{
    public class ArrayLesson
    {
        //Declaration with array index. Can be instanciated or not and it will work
        string[] cars = new string[3] { "Volvo", "BMV", "Cargo" };


        //Declaration without defining the size of index, it is set by the number of values
        string[] cars2 = { "Benz", "Lexus" };

        string[] planets =
        {
            "Mercury", "Venus","Eearth","Mars","Jupiter","Sarturn","Uranus","Neptune"
        };

       


        public void GetArrayIteration()
        {
            foreach (string planet in planets)
            {

                Console.WriteLine(planet);
            }
        }


        //Remeber Arrays use O index
        public void GetArrayValueByIndex(int index)
        {
            Console.WriteLine($"in the planet array, the planet: {planets[index]} is for index: {index}");
        }

        public void UpdateArrayValue(int index, string newValue)
        {
            planets[index] = newValue;

            Console.WriteLine("New Array iteration");
            GetArrayIteration();
        }

        public void OtherArrayAbilities()
        {
            //Reverses the value of the array content, replaces value of the same array name
            Console.WriteLine("Reverse Array");
            Array.Reverse(planets);
            GetArrayIteration();
            Console.WriteLine();

            //Sorts the order of Array Item, replaces value of the same array name
            Console.WriteLine("Sort Array");
            Array.Sort(planets);
            GetArrayIteration();
            Console.WriteLine();
        }

    }

}
