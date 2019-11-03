using System;

namespace sample
{
    public class VP : Handler
    {
        public override void Handle(MyArgs request)
        {
            Console.WriteLine("VP");

            if (request.handled) return;

            base.Handle(request);
        }
    }
}
