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
        public void SayHelloWorld(string name)
        {
            Trace.WriteLine($"say helloword to {name}");
        }

        public void SayHi(string name)
        {
            Trace.WriteLine($"say hi {name}");
        }

    }
}
