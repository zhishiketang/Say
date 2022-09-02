using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Say
{
    public class MySay
    {
        public void SayHello(string name)
        {
            Trace.WriteLine($"say hello to {name}");
        }
    }
}
