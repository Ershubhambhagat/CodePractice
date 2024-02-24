using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodePractice
{
    internal class Car
    {
        private string _name;
        public Car(string name)
        {
            _name = name;   
            Console.WriteLine("This is going to call Car "+name);
        }
        public void Drive()//Method
        {
            Console.WriteLine(_name+"Drive");
        }
        public void Stop()//Method
        {
            Console.WriteLine(_name+"Stop");
        }
    }
}
