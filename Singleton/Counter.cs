
namespace DesignPatterns.singleton
{
    public class Counter
    {
        public int Count = 0;
        private static Counter instance = null;
        private static object lockobj = new object() ;    
        private Counter()
        {

        }
        public static Counter GetInstance()
        {
            lock (lockobj)
            {
                if (instance == null) { instance = new Counter(); }
                return instance;
            }
        }
        public void AddOne()
        {
            Count++;
        }
    }
}
