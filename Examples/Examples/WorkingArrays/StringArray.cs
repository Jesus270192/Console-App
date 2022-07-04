using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.WorkingArrays
{
    public class StringArray : SimpleArray<string> 
    {
        public StringArray(string v1) : base(v1) { }

        public StringArray(string v1, string v2) : base(v1, v2) { }

        public StringArray(string v1, string v2, string v3) : base(v1, v2, v3) { }
    }
}
