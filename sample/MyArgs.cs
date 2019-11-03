using System;

namespace sample
{
    public class MyArgs : EventArgs
    {
        public string Problem;

        public bool handled = false;

        public MyArgs() : base()
        {

        }
    }
}
