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
        //Private Member var /Field 
        private string _name;
        private int _HP;

        public int MaxSpeed { get; set; }
        public int Waight { get; } = 1000;//Set Accesser only

        #region Ctor
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
        public Car()
        {
            _name = "car";  
            _HP = 323;
        }
        #endregion

        #region Member Method
        public int GetHP()
        {
            return _HP*_HP;
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
        #endregion


        //the public Properties 
        #region //using this we can modified private member  or var
        public string Name
        {
            get { return _name; }//get accessor
            set { _name = value; }//set accessor
        }
        #endregion
    }
}
