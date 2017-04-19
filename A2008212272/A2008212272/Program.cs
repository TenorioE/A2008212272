using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Carlos", "Rivera", "Lujan", 4756346, 3000);
            emp.print();
            Console.ReadKey();
            Cliente cli = new Cliente("Mayra", "Contreras", "Martinez", 4756346);
            cli.print();
            Console.ReadKey();

        }
    }
}
