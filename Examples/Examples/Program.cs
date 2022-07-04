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
            IntArray array = new IntArray(10, 2, 3);
            DecimalArray decArr = new DecimalArray(decimal.One, decimal.Zero, decimal.MaxValue);
            StringArray arrayString = new StringArray("Monica", "Chuy", "Chato");
            StoreArray store = new StoreArray(new Store() { Name="Monica" }, new Store() { Name = "Chuy" }, new Store() { Name = "Chato" });

            array.PrintArray();
            decArr.PrintArray();
            arrayString.PrintArray();
            store.PrintArray();

            Console.Write("Press any key to exit");
            Console.ReadLine();
        }
    }
}
