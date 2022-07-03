using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.WorkingArrays
{
    public abstract class SimpleArray<Type>
    {
        public Type[] MyArray;

        public SimpleArray(Type[] array)
        {
            this.MyArray = array;
        }

        public SimpleArray(Type v1)
        {
            MyArray = new Type[1] { v1};
        }

        public SimpleArray(Type v1, Type v2)
        {
            MyArray = new Type[2] { v1 ,v2};
        }

        public SimpleArray(Type v1, Type v2, Type v3)
        {
            MyArray = new Type[3] { v1, v2 ,v3};
        }

        public SimpleArray(Type v1, Type v2, Type v3,Type v4)
        {
            MyArray = new Type[4] { v1, v2, v3,v4 };
        }

        public abstract void Orderby();

        public abstract void OrderbyDesc();

        public abstract void BubbleSort();
    }
}
