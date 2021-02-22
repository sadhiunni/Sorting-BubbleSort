using System;

namespace Sorting_BubbleSort
{
    class Program
    {
        /* Bubble sort follows a simple logic. 
         * It compares adjacent elements in a loop and swaps them if they are not in order.
         * It is called bubble sort because , the smaller elements gradually bubble up to the top of the list.
         */
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("___________");
            Console.WriteLine("Bubble sort");
            Console.WriteLine("___________");
            int[] a = InputArray();
            Console.WriteLine("___________");
            Console.WriteLine("Before Sorting");
            foreach (var item in a)
            {
                Console.Write(item+" ");
            }
            //sorting
            for (int j = 0; j < a.Length-1; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                    }
                }
            } 
            Console.WriteLine("\n___________");
            Console.WriteLine("After sorting");
            foreach (var item in a)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n___________");

        }
        public static int[] InputArray()
        {
            int no;
            Console.WriteLine("Please enter the number of elements in the array");
            no = Convert.ToInt32(Console.ReadLine());
            int[] ArrA = new int[no];
            Console.WriteLine("Please enter array elements");
            Console.WriteLine("Note : press enter, after entering each element");
            for (int i = 0; i <= no - 1; i++)
            {
                ArrA[i] = Convert.ToInt32(Console.ReadLine());
            }
            return ArrA;
        }

    }
}
