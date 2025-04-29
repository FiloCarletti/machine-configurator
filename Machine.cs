using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineConfigurator
{
    class Machine
    {
        int id { get; set; } 
        double power;
        int axes;
        Material material;

        public Machine()
        {

        }
        public Machine(int id, double power, int axes, Material material)
        {
            this.id = id;
            this.power = power;
            this.axes = axes;
            this.material = material;
        }
        
        public void toString()
        {
            Console.WriteLine("Machine ID: "+id+" \nPower: "+power+" Watts\nTotal Axes: "+axes+"\nWorking Material: " + material.ToString());
        } /*
        public string toString()
        {
            return "Machine ID: " + id + " \nPower: " + power + " Watts\nTotal Axes: " + axes + "\nWorking Material: " + material.ToString();
        }*/
    }
}
