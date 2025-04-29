using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineConfigurator
{
    class Program
    {
        static void Main(string[] args)
        {
            double power = 0;
            int axes = 0;
            string material = "Steel";

            Console.Write("Type the machine power: ");
            power = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type the machine axes: ");
            axes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the machine working material: ");
            material = Console.ReadLine();


            Machine m = new Machine(0, power, axes, (Material)Enum.Parse(typeof(Material), material));

            m.toString();
            //Console.WriteLine(m.toString());
        }
    }
}
