using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection

{
    public class MySuperCollection<T> : IEnumerable<T>
    {
        private List<T> myList = new List<T>();
        
        public MySuperCollection()
        {
        }

        public MySuperCollection(IEnumerable<T> anyArray)
        {
            myList.AddRange(anyArray);
        }

        public void Add(T element)
        {
            myList.Add(element);
        }

        public void Remove(int index)
        {
            Console.WriteLine($"Element with {index} index have been removed from the MySuperCollection");
            myList.RemoveAt(index);
        }

        public void Sort ()
        {
            if (typeof(T) == typeof(MySuperObject))
            {
                Console.WriteLine("This list cannot be sorted");
            }
            else
                myList.Sort();     
        }

        public int IndexOfElement(T element)
        {
            return myList.IndexOf(element);
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(myList);
        }
    }

    public class MyEnumerator<T> : IEnumerator<T>
    {
        private int index = 0;
        private List<T> myList = new List<T>();

        public MyEnumerator(IEnumerable<T> anyArray)
        {
            myList.AddRange(anyArray);
        }

        object IEnumerator.Current
        {
            get { return Current; }
        } 

        public T Current
        {
            get { return myList[index - 1]; }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (index + 1 <= myList.Count)
            {
                index++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
