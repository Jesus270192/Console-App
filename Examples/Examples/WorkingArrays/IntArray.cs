using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.WorkingArrays
{
    public class IntArray : SimpleArray<int>
    {
        public IntArray(int v1) : base(v1) { }
        
        public IntArray(int v1, int v2) : base(v1,v2) { }

        public IntArray(int v1, int v2,int v3) : base(v1, v2,v3) { }
        
        public override void BubbleSort()
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
                        int temporal = MyArray[i];
                        MyArray[i] = MyArray[next];
                        MyArray[next] = temporal;
                    }
                }
            }
        }

        public override void Orderby()
        {
             MyArray = MyArray.OrderBy(s=>s).ToArray();
        }

        public override void OrderbyDesc()
        {
            MyArray =  MyArray.OrderByDescending(s => s).ToArray();
        }
    }
}
