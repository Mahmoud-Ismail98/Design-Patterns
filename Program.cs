using System;
using DesignPatterns.singleton;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
        //Singleton Pattern - Lazy Initialization Implementation
        /*    Counter counter1 = Counter.GetInstance();
            Counter counter2 = Counter.GetInstance();
            counter1.AddOne();
            counter2.AddOne();

            Console.WriteLine("counter 1:" + counter1.Count.ToString());
            Console.WriteLine("counter 2:" + counter2.Count.ToString());
            Console.WriteLine();

            counter1.AddOne();
            Console.WriteLine("counter 1:" + counter1.Count.ToString());
            Console.WriteLine("counter 2:" + counter2.Count.ToString());
        */

        //Thread Safety Singleton Pattern Implementation
             Task task1 = Task.Factory.StartNew(() => {  
               Counter counter1 = Counter.GetInstance();
               counter1.AddOne();
               Console.WriteLine("counter 1 :"+ counter1.Count.ToString());
            }); 
            
            Task task2 = Task.Factory.StartNew(() => {  
               Counter counter2 = Counter.GetInstance();
               counter2.AddOne();
               Console.WriteLine("counter 2 :"+ counter2.Count.ToString());
               Console.WriteLine();
            }); 
            Console.ReadKey();
        }
    }
}

