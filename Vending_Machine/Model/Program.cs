using System;
using System.IO;
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
            try
            {
                do
                {
                    bool isvalidMoney = false;
                    bool isTrue = true;
                    bool isSufficient = true;
                    int userReInsertMoney;
                    double remaingBalance;
                    string messeage;
                    int total;

                    VendingMachine machineObject = new VendingMachine();
                    Program p = new Program();
                    List<Products> listOfProducts = new List<Products>();
                    Console.WriteLine("Please inset your money in a fixed denominations 1kr, 5kr,10kr,20kr,50kr,500kr, 100kr,1000kr");
                    int userMoney = int.Parse(Console.ReadLine());

                    //this is going to return all the products
                    listOfProducts = machineObject.Purchase();

                    //this is going to return Money in fixed Denominations
                    int[] moneyList = machineObject.ShowAll();

                    //this will resturn user inserted valid input money or not
                    isvalidMoney = machineObject.InsertMoney(userMoney);

                    while (isTrue)
                    {
                        if (isvalidMoney)
                        {
                            p.Examine(listOfProducts);
                            isTrue = false;
                        }
                        else
                        {
                            Console.WriteLine("Your input money is not valid \n Please inset your money in a fixed denominations 1kr, 5kr,10kr,20kr,50kr,100kr,1000kr");
                            userMoney = int.Parse(Console.ReadLine());
                            isvalidMoney = machineObject.InsertMoney(userMoney);
                            isTrue = true;
                        }
                        if (userMoney < 100)
                        {
                            Console.WriteLine("Inserted money is not sufficient to buy the product please insert more money as per fixed denominations");
                            userReInsertMoney = int.Parse(Console.ReadLine());
                            userMoney += userReInsertMoney;
                            isvalidMoney = machineObject.InsertMoney(userMoney);
                            isTrue = false;
                        }

                    }
                    Console.WriteLine("Please make your selection");
                    Console.WriteLine("Please enter Which one you want to buy from list");
                    string userChoice = Console.ReadLine().ToUpper();
                    Console.WriteLine("Please enter how many you want to buy");
                    int noOfProducts = int.Parse(Console.ReadLine());
                    total = noOfProducts * 100;
                      
                    if(total > userMoney)
                    {
                        while (isSufficient) {
                            Console.WriteLine("Your inserted Money is not sufficient to buy the items please insert more money");
                            int oldMoney = userMoney;
                            userMoney = int.Parse(Console.ReadLine());                           
                            isvalidMoney = machineObject.InsertMoney(userMoney);
                            userMoney += oldMoney;
                            if (isvalidMoney)
                            {
                                isSufficient = false;
                            }
                            else
                            {
                                Console.WriteLine("Your input money is not valid \n Please inset your money in a fixed denominations 1kr, 5kr,10kr,20kr,50kr,100kr,1000kr");
                                userMoney = int.Parse(Console.ReadLine());
                                isvalidMoney = machineObject.InsertMoney(userMoney);
                                isSufficient = true;
                            }
                        }

                    }

                    //Calling MakeBuyerSelection function choose wich item to buy
                    p.MakeBuySelection(userChoice, userMoney);

                    //Calling EndTransaction method
                    remaingBalance = machineObject.EndTransaction(userMoney, noOfProducts);
                    Console.WriteLine("Here is Your Remaining money:\t" + remaingBalance +" Kr");

                    //Calling use method
                    messeage = machineObject.Use(userChoice);
                    Console.WriteLine(messeage);
                    

                    Console.WriteLine("Would you like to order again?\n enter Yes to order again else enter No to exit ");
                   
                } while (Console.ReadLine().ToUpper()=="YES");
                Console.Clear();
                Console.WriteLine("Press any key to exit.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You Have to enter somthing input should not be null");
            }
            catch (IOException)
            {
                Console.WriteLine("There will be problem with input or output please give proper input");
            }
            catch (FormatException)
            {
                Console.WriteLine("Given input format is not valid please enter proper format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Given input is too big its overFlow enter proper input");
            }
           
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

                //Implimentation to display all the items with prices
        public void Examine(List<Products> listOfProducts)
        {
            Console.WriteLine("----You are Welcome to buy below list of items-----\n ");
            Console.WriteLine("****************************");
            Console.WriteLine("* " + listOfProducts[0] + "= 100Kr/pc    *\n");
            Console.WriteLine("* " + listOfProducts[1] + "= 100Kr/pc   *\n");
            Console.WriteLine("* " + listOfProducts[2] + "= 100Kr/pc    *\n");
            Console.WriteLine("****************************");
        }
        
    }//End of Class
}//end of NameSpace
