using System;
using System.Diagnostics;
using sample;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chain = new AlternateChain();
            var evt = new MyArgs { Problem = "strange bug" };
            chain.handle(evt);
        }
    }
}
