namespace sample
{
    abstract public class Handler

    {
        protected Handler successor;

        public Handler SetSuccessor(Handler successor)
        {
            this.successor = successor;
            return successor;
        }

        public virtual void Handle(MyArgs request)
        {
            successor?.Handle(request);
        }
    }
}
