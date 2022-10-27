namespace basics
{
    public class Worker
    {
        public bool DoStuff()
        {
            return true;
        }

        public int AddOne(int input)
        {
            return input++;
        }

        public int AddTwo(int input)
        {
            return input + 2;
        }

        public void DoNothing(int input)
        {
            return;
        }
    }
}
