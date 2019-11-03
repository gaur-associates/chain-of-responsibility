using System;

namespace sample
{
    public class Manager : Handler
    {
        public override void Handle(MyArgs request)
        {
            Console.WriteLine("Manager");

            if (request.handled) return;

            base.Handle(request);
        }
    }
}
