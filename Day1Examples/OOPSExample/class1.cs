using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class Bird : IFlying
    {
        public void fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine(" flap flap flap");
        }
    }


    class Kite : IFlying
    {
        public void fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Flies colourfully with tail and thread ");
        }
    }

    class Plane : IFlying,IPassengerInfo
    {
        public void fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("up in the sky");
        }


        public void PrintTicket()
        {
            Console.WriteLine("Passenger name:Deepa");
            Console.WriteLine("source:banglore");
            Console.WriteLine("destination:New DElhi");
            Console.WriteLine("PNR NO:2435656");
            Console.WriteLine("DOJ:7/15/2018");
            Console.WriteLine("seat no: AB");
        }

    }
}
