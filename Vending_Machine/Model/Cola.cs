using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Model
{
  public class Cola : Products
    {
        public new string Name { get; set; }

        public Cola(string name) : base(name)
        {
            Name = name;
        }
        public override string Info()
        {
            return $"P{Name}\n";
        }

    }
}
