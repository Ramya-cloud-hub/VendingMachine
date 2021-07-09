using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Model
{
  public abstract  class Products
    {
        public string Name { get; set; }
        public abstract string Info();
        public Products(string name)
        {
            Name = name;          
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
