using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class PersonInfo
    {
        string name;
        int age;
        string email;


        public void GetData()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email id");
            email = Console.ReadLine();
        } 

        public void ShowData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("email :"+ email);

        }


        public PersonInfo()
        {
            name = "DEfault";
            age = 99;
            email = "default@default.com";
        }

        public PersonInfo(string name,int age,string em)
        {
            this.name = name;
            this.age = age;
            email = em;
        }

        ~PersonInfo()
        {
            GC.Collect();
            Console.WriteLine("Object destroyed");
        }

    }
}
