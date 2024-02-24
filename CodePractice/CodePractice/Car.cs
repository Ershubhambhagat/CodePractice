using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Car(string name, int hp = 1)
        {
            //Member Variable 
            _name = name;   //This field is used to storeing data
            _HP = hp;
            Console.WriteLine("This is going to call Car " + name);
        }
        //need Full Specification
        public Car(string name, int hp,string Color)
        {
            _name = name;
            _HP = hp;

        }
        //Default CTOR 

        //Ctor 

        public Car()
        {
            _name = "car";  
            _HP = 323;
            
        }
    
        
        #region Member Method
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
        #endregion
    }
}
