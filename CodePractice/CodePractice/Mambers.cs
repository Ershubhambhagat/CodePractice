using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    internal class Mambers
    {
        //Mambers -Private Field 
        private string MemberName;
        private string jobTitle;
        private int salary =20000;
        //Mambers -Public Field 
        public int age;
        //mamber - Prop Exposes JobTitle sefely - Property Start with Caps Letter
        public string JobTitle {
            get
            {
                return jobTitle;
            }
            set 
            {
                jobTitle = value;
            } 
        }
        //Public member Method- Can be call from Author Classes
        public void Introduction(bool isFried)
        {
            if (isFried)
            {
                ShareingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi , My Name is {0} and job title is {1}",MemberName,jobTitle);
            }

        }

        private void ShareingPrivateInfo()
        {
            Console.WriteLine("My Salery  is {0}",salary);
        }

        //Member constructor

        public Mambers()
        {
            MemberName = "Shubham ";
            jobTitle = "Software Engineer";
            salary = 100000;
            Console.WriteLine("Object Created");
        }
        //Member -finelazer -destructor
        ~Mambers()
        {
            //clean up statement 
            Console.WriteLine(  "DEconstruction of Member Object");
        }

    }
}
