
namespace DesignPatterns.singleton
{
    public class Counter
    {
        public int Count = 0;
        private static Counter instance = new Counter();
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            return instance;
        }
        public void AddOne()
        {
            Count++;
        }
    }
}
