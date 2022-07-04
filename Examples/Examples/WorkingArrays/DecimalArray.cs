using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.WorkingArrays
{
    public class DecimalArray : SimpleArray<decimal>, ISort
    {
        public DecimalArray(decimal v1) : base(v1) { }

        public DecimalArray(decimal v1, decimal v2) : base(v1, v2) { }

        public DecimalArray(decimal v1, decimal v2, decimal v3) : base(v1, v2, v3) { }

        public void BubbleSort()
        {
            for (int x = 0; x < MyArray.Length; x++)
            {
                for (int i = 0; i < MyArray.Length - 1;
                     i++)
                {
                    int next = i + 1;
                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (MyArray[i] > MyArray[next])
                    {
                        decimal temporal = MyArray[i];
                        MyArray[i] = MyArray[next];
                        MyArray[next] = temporal;
                    }
                }
            }
        }
    }
}
