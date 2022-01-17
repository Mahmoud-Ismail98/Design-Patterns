
namespace DesignPatterns.singleton
{
    public class Counter
    {
        public int Count = 0;
        private static Counter instance = null;
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            if (instance == null) { instance = new Counter(); }
            return instance;
        }
        public void AddOne()
        {
            Count++;
        }
    }
}
