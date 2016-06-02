using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortlisting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylistsimple = new List<int>() {2,3,-5,79,16,-7 };// a list of unsorted numbers
            Console.WriteLine("numbers before sorting");//prints before sorting
            foreach (int b in mylistsimple) {
                
                Console.WriteLine(b);//output of unsorted

            }

            mylistsimple.Sort();//sorting the list
            Console.WriteLine("numbers after sorting");
            foreach (int b in mylistsimple)
            {
                
                Console.WriteLine(b);// prints after sorting

            }
            mylistsimple.Reverse();// descending order
            Console.WriteLine("descending order");
            foreach (int b in mylistsimple)
            {

                Console.WriteLine(b);// prints descending order

            }
            List<string> myalph = new List<string>() { "A","G","Z","H","C"};
            myalph.Sort();
            Console.WriteLine("sorting alphabet");// sorting alphabet
            foreach (string b in myalph)
            {

                Console.WriteLine(b);//prints the sorted alphabet;

            }

            Console.ReadLine();
        }
    }
}
