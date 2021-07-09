using System;
using System.Linq;
using System.Collections.Generic;
using VendingMachineController.Model;
using VendingMachineController.Data;



namespace VendingMachineController.Model
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalidMoney = false;
            bool isTrue = true;
            double remaingBalance;
            string messeage;

            VendingMachine machineObject = new VendingMachine();
            List<Products> listOfProducts = new List<Products>();
            Console.WriteLine("Please inset your money in a fixed denominations 1kr, 5kr,10kr,20kr,50kr,100kr,1000kr");
            int userMoney = int.Parse(Console.ReadLine());

            //this is going to return all the products
            listOfProducts = machineObject.Purchase();
            //this is going to return Money in fixed Denominations
            int[] moneyList = machineObject.ShowAll();

            //this will resturn user inserted valid input money or not
            isvalidMoney = machineObject.InsertMoney(userMoney);

            while (isTrue) {
                if (isvalidMoney)
                {
                    machineObject.Examine(listOfProducts);
                    isTrue = false;
                }
                else
                {
                    Console.WriteLine("Your input money is not valid \n Please inset your money in a fixed denominations 1kr, 5kr,10kr,20kr,50kr,100kr,1000kr");
                    userMoney = int.Parse(Console.ReadLine());
                    isvalidMoney = machineObject.InsertMoney(userMoney);
                    isTrue = true;
                }
            }
            Console.WriteLine("Please enter Which one you want to buy from list");
            string userChoice = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter how many you want to buy");
            int noOfProducts = int.Parse(Console.ReadLine());
            Program p = new Program();
            //Calling MakeBuyerSelection function choose wich item to buy
            p.MakeBuySelection(userChoice, userMoney);

            //Calling EndTransaction method
            remaingBalance = machineObject.EndTransaction(userMoney, noOfProducts);
            Console.WriteLine("Here is Your Remaining money:\t" + remaingBalance);

            //Calling use method
            messeage = machineObject.Use(userChoice);
            Console.WriteLine(messeage);
           
        }
             public void MakeBuySelection(string selection, int userMoney)
            {
                bool selectionOk = false;
                while (!selectionOk)
                {
                    switch (selection)
                    {
                        case "COLA":
                            Console.WriteLine("Thank you for Choosing a Cola");
                            selectionOk = true;
                            break;
                        case "CANDY":
                            Console.WriteLine("Thank you for Choosing a Candy");
                            selectionOk = true;
                            break;
                        case "CAKE":
                            Console.WriteLine("Thank you for Choosing a Diet Cake");
                            selectionOk = true;
                            break;
                        default:
                            Console.WriteLine("Invalid selection.Please re-enter your selection");
                            selection = Convert.ToString(Console.ReadLine().ToUpper());
                            selectionOk = false;
                        break;
                    }
                }
            }//end of makeBuyerSelection function

        
    }//End of Class
}//end of NameSpace
