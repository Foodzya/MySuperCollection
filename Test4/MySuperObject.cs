using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MySuperObject
    {
        private int _number;

        public MySuperObject(int number)
        {
            _number = number;
        }

        public void GetInfo()
        {
            Console.WriteLine(_number);
        }

    }
}
