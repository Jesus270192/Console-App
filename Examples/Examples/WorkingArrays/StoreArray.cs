using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.WorkingArrays
{
 public  class StoreArray :  SimpleArray<Store>
    {
        public StoreArray(Store v1) : base(v1) { }

        public StoreArray(Store v1, Store v2) : base(v1, v2) { }

        public StoreArray(Store v1, Store v2, Store v3) : base(v1, v2, v3) { }


        public override void PrintArray()
        {
            Console.WriteLine(MyArray.GetType().Name);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i].Name);
            }

            Console.WriteLine();
        }
    }
}
