using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
                {
                        new PizzaOrder {orderid=1,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="sweetcorn",qty=1,price=300 },
                        new PizzaOrder {orderid=2,orderdate=DateTime.Now,pizzatype="veg",pizzasize='m',toppings="onion",qty=2,price=350 },
                        new PizzaOrder {orderid=3,orderdate=DateTime.Now,pizzatype="veg",pizzasize='l',toppings="capsicum",qty=10,price=400 },
                        new PizzaOrder {orderid=4,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="tomato",qty=5,price=200 },
                        new PizzaOrder {orderid=5,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='m',toppings="chicken",qty=6,price=600 },
                        new PizzaOrder {orderid=6,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='s',toppings="egg",qty=7,price=369 },
                        new PizzaOrder {orderid=7,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='m',toppings="chicken",qty=5,price=400 },
                        new PizzaOrder {orderid=8,orderdate=DateTime.Now,pizzatype="non veg",pizzasize='s',toppings="egg",qty=3,price=500 },


            };

            foreach (var d in po)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
            Console.WriteLine("******************************");

            var data2 = po.Where(x => x.pizzasize == 's' && x.pizzatype == "non veg");
            foreach(var d in data2)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
            Console.WriteLine("******************************");

            var grp = po.GroupBy(x => x.pizzatype).Select(x => new { PizzaSold = x.Count(), AmountCollected = x.Sum(y => y.price) });
            foreach (var d in grp)
                Console.WriteLine(d.PizzaSold + "," + d.AmountCollected);
            Console.WriteLine("*******************************");

            var grp1 = po.GroupBy(x => x.pizzasize).Select(x => new { PizzaSold = x.Count(), AmountCollected = x.Sum(y => y.price) });
            foreach (var d in grp1)
                Console.WriteLine(d.PizzaSold + "," + d.AmountCollected);
            Console.WriteLine("*******************************");


            var data3 = po.Where(x => x.pizzasize == 'm');
            foreach (var d in data3)
                Console.WriteLine(d.pizzatype + "," + d.toppings);
            Console.WriteLine("*******************************");

            var data4 = po.Where(x => x.price == po.Max(y => y.price));
            foreach(var d in data4)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
            Console.WriteLine("******************************");

            var data5 = po.Where(x => x.price == po.Min(y => y.price));
            foreach (var d in data5)
                Console.WriteLine(d.orderid + "," + d.orderdate + "," + d.pizzatype + "," + d.pizzasize + "," + d.toppings + "," + d.qty + "," + d.price);
            Console.WriteLine("******************************");

        }
    }
}
