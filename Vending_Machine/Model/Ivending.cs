using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Model
{
    public interface IVending
    {
        public List<Products> Purchase();
        public int[] ShowAll();
        public  bool InsertMoney(int insertMoney);
        public  double EndTransaction(int userinputmoney , int noOfProduct);

    }
}
