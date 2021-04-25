using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperCollectionTest();

            Console.ReadKey();
        }

        public static void SuperCollectionTest()
        {
            MySuperCollection<MySuperObject> mySuperCollection = new MySuperCollection<MySuperObject>
            {
                new MySuperObject(35),
                new MySuperObject(23),
                new MySuperObject(30)
            };

            MySuperObject superObject = new MySuperObject(14);
            mySuperCollection.Add(superObject);
            foreach (MySuperObject i in mySuperCollection)
            {
                i.GetInfo();
            }
            mySuperCollection.Sort();
            mySuperCollection.Remove(1);
            Console.WriteLine(mySuperCollection.IndexOfElement(superObject));
        }

    }
}