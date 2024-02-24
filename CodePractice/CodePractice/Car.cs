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
        private int _HP;
        public Car(string name,int hp=1)
        {
            //Member Variable 
            _name = name;   //This field is used to storeing data
            _HP = hp;
            Console.WriteLine("This is going to call Car "+name);
        }
        public void Drive()// Member Method
        {
            Console.WriteLine(_name+"Drive");
        }
        public void Stop()//Member Method 
        {
            Console.WriteLine(_name+"Stop");
        }
        public void Deatais()
        {
            Console.WriteLine(_name +" is a car and HP is "+_HP );
        }
    }
}
