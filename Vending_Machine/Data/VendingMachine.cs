using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using VendingMachineController.Model;

namespace VendingMachineController.Data
{
    public class VendingMachine : IVending
    {
        readonly int[] moneyDenominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        const int costOfDrink = 100;

        //Implimentation of Purchase Method
        public List<Products> Purchase()
        {
            Cola cola = new Cola("Cola");
            Candy candy = new Candy("Candy");
            HealthySnack snack = new HealthySnack("Cake");
            List<Products> listOfItems = new List<Products>();
            listOfItems.Add(cola);
            listOfItems.Add(candy);
            listOfItems.Add(snack);

            return listOfItems;
        }

        //Implimentation of show all the items function
        public int[] ShowAll()
        {
            return moneyDenominations;
        }

        //Implimentation of InserMoney function
        public bool InsertMoney(int insertMoney)
        {
            int runningTotal = 0;
            bool isValid = false;

            if (moneyDenominations.Contains(insertMoney))
            {
                runningTotal += insertMoney;
                isValid = true;
            }

            return isValid;
        }
        //Implimentation to display all the items with prices
        public void Examine(List<Products> listOfProducts)
        {
            Console.WriteLine("----You are Welcome to buy below list of items-----\n ");
            Console.WriteLine("****************************");
            Console.WriteLine("* " + listOfProducts[0] + "= 100Kr/pc   *\n");
            Console.WriteLine("* " + listOfProducts[1] + "= 100Kr/pc   *\n");
            Console.WriteLine("* " + listOfProducts[2] + "= 100Kr/pc   *\n");
            Console.WriteLine("****************************");
            Console.WriteLine("Please make your selection");
        }

        //Implimentation of EndTransaction functiom
        public double EndTransaction(int userInputMoney, int noOfProduct)
        {
            double remainingbalance = 0.0;
            int total = costOfDrink * noOfProduct;
            if (userInputMoney >= total)
                remainingbalance = userInputMoney - total;

            return remainingbalance;
        }

        //Implimentaion of Use funtion to display messeages
        public string Use(string selection)
        {
            string messeage = "";
            if (selection.Equals("COLA"))
                messeage = "THINGS GO BETTER WITH COLA,PLEASE ENJOY OUR COLA";
            if (selection.Equals("CANDY"))
                messeage = "LIFE IS TOO SHORT MAKE IT SWEET, PLEASE ENJOY OUR CANDY";
            if (selection.Equals("CAKE"))
                messeage = "LIFE IS SHORT EAT THE DESSERT FIRST,  PLEASE ENJOY OUR CAKE";

            return messeage;
        }


    }
}
