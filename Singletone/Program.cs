using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone instance1 = Singletone.Instance();
            Singletone instance2 = Singletone.Instance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));

            instance1.SingletonOperation();
            string singletonData = instance1.GetSingletoneData();

            Console.WriteLine(singletonData);
            Console.ReadKey();
        }
    }
}
