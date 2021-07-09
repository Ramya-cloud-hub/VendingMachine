using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Model
{
   public  class HealthySnack : Products
    {
        public new string Name{ get;set;}

        public HealthySnack(string name) :base(name)
        {
            Name = name;
        }
        public override string Info()
        {
            return $"Product Name: {Name}\n";
        }
    }
}
