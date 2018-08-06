using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime doj;
            Console.WriteLine("Enter id");
            // id = int.Parse(Console.ReadLine());
            bool res = int.TryParse(Console.ReadLine(), out id);
            if(res==false)
            {
                Console.WriteLine("Id has to be integer values only");
                return
                    ;
            }
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cab(true/false)");
            cab = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID:"+id);
            Console.WriteLine("NAME:"+name);
            Console.WriteLine("GENDER:"+gender);
            Console.WriteLine("SALARY:"+salary);
            Console.WriteLine("cab:"+cab);
            Console.WriteLine("DOJ:"+doj);
        }
    }
}
