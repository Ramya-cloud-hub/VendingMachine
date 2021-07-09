using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Model
{
   public class Candy : Products
    {

        public new string Name { get; set; }

        public  Candy(string name) : base(name)
        {
            Name = name; 
        }
       public  override string Info()
        {
            return $"Product Name: {Name}\n";
        }
    }
}
