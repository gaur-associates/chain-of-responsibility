using System;

namespace sample
{
    public class AlternateChain
    {
        private readonly Developer _developer;

        public void handle(MyArgs e)
        {
            _developer.Handle(e);
        }
        public AlternateChain()
        {
            _developer = new Developer();
            var mgr = new Manager();
            var vp = new VP();

            _developer.SetSuccessor(mgr);
            mgr.SetSuccessor(vp);

        }

    }
}
