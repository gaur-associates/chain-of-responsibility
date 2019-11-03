using System;

namespace sample
{
    public class Developer : Handler
    {
        public Developer()
        {
        }

        public override void Handle(MyArgs request)
        {
            Console.WriteLine("developer");

            request.handled = true;
            if (request.handled) return;

            base.Handle(request);
        }
    }
}
