using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    class Rectangle:Shapes
    {
        int len;
        int brd;
        public override void DisplayShapes()
        {
            base.DisplayShapes();
            Console.WriteLine("Rectangle class");
        }


        public override void DisplayArea()
        {
            //throw new NotImplementedException();
            len = 200;
            brd = 100;
            area = len * brd;
            Console.WriteLine("Area of rectangle :" + area);
        }
    }
}
