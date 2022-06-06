using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public class SingletonObject
    {
        private static SingletonObject instance = new SingletonObject();
        private SingletonObject() { }

        public static SingletonObject getInstance()
        {
            return instance;
        }

        public void sendMessage()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
