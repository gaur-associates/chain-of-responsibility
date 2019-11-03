using System;
using System.Collections.Generic;

namespace sample
{
    public class ChainOfResponsibility
    {
        private event EventHandler<MyArgs> _handers;

        public void handle(MyArgs e)
        {
            _handers?.Invoke(this, e);
        }

        public ChainOfResponsibility()
        {
            _handers += developer;
            _handers += manager;
            _handers += vp;
        }

        private void vp(object sender, MyArgs e)
        {
            if (e.handled) return;
            Console.WriteLine("vice president");

        }

        private void manager(object sender, MyArgs e)
        {
            if (e.handled) return;
            Console.WriteLine("manager");

        }

        private void developer(object sender, MyArgs e)
        {
            Console.WriteLine("developer");
            e.handled = true;
        }
    }
}
