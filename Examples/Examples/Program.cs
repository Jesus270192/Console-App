using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.WorkingArrays;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            IntArray array = new IntArray(10,2,3);
            StringArray arrayString = new StringArray("Monica", "Chuy", "Chato");

            int suma =  Encoding.ASCII.GetBytes("chUy".ToLower()).Sum(s=>s);

            array.BubbleSort();
            arrayString.OrderbyDesc();

            for (int i = 0; i < arrayString.MyArray.Length; i++)
            {
                Console.Write($"{arrayString.MyArray[i]}");
                Console.Write("\n");
            }

            Console.Write("Hola mundo");
            Console.ReadLine();
        }



    }
}
