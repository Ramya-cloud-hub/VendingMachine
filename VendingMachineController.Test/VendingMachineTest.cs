using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineController.Data;
using VendingMachineController.Model;

namespace VendingMachineController.Test
{
   public class VendingMachineTest
    {
        [Fact]
        public void Test_Purchase_List_Products()
        {
            //Arrange
            string cola1 = "Cola";
            string candy1 = "Candy";
            string snack1 = "Cake";
            List<string> listOfExpected = new List<string>();
            listOfExpected.Add(cola1);
            listOfExpected.Add(candy1);
            listOfExpected.Add(snack1);

            //Act        
            VendingMachine objVending = new VendingMachine();
            List<Products> listOfItems = new List<Products>();
            listOfItems = objVending.Purchase();
            
            //Assert
            Assert.Equal(listOfExpected[0], listOfItems[0].ToString());
            Assert.Equal(listOfExpected[1], listOfItems[1].ToString());
            Assert.Equal(listOfExpected[2], listOfItems[2].ToString());
            Assert.Contains(listOfExpected[0], listOfItems[0].ToString());
            Assert.Contains(listOfExpected[1], listOfItems[1].ToString());
            Assert.Contains(listOfExpected[2], listOfItems[2].ToString());
        }
        [Fact]
        public void Test_ShowAll()
        {
            //Actual
            int expectedMoney = 500;
            int[] listOfMoney;

            //Act
            VendingMachine objectVending = new VendingMachine();
           listOfMoney = objectVending.ShowAll();

            //Actual
            Assert.Contains(expectedMoney, listOfMoney);
        }
        [Fact]
        public void Test_ShowAll_Wrok_ForBad_InputMoney()
        {
            //Actual
            int expectedMoney = 300;
            int[] listOfMoney;

            //Act
            VendingMachine objectVending = new VendingMachine();
            listOfMoney = objectVending.ShowAll();

            //Actual
            Assert.DoesNotContain(expectedMoney, listOfMoney);
        }
        [Fact]
        public void Test_Good_InsertMoney()
        {
            //Actual
            int expectedMoney = 100;
            bool expectedMoneyIsValid = true;
            bool isValidMoney;

            //Act
            VendingMachine objectVending = new VendingMachine();
            isValidMoney = objectVending.InsertMoney(expectedMoney);

            //Actual
            Assert.Equal(expectedMoneyIsValid, isValidMoney);
        }
        [Fact]
        public void Test_Bad_InsertMoney()
        {
            //Actual
            int expectedMoney = 600;
            bool expectedMoneyIsValid = true;
            bool isValidMoney;

            //Act
            VendingMachine objectVending = new VendingMachine();
            isValidMoney = objectVending.InsertMoney(expectedMoney);

            //Actual
            Assert.NotEqual(expectedMoneyIsValid, isValidMoney);
        }
        [Fact]
        public void Test_EndTransaction()
        {
            //Actual
            int inputMoney = 500;
            int noOfItems = 2;
            double expectedResult = 300;
            double actualResult;

            //Act
            VendingMachine objectVending = new VendingMachine();
            actualResult = objectVending.EndTransaction(inputMoney, noOfItems);

            //Actual
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void Test_Use_Messeage_Cola()
        {
            //Actual
            string expectedMesseage = "THINGS GO BETTER WITH COLA,PLEASE ENJOY OUR COLA";
            string userProductName = "COLA";
            string actualMesseage;

            //Act
            VendingMachine objectVending = new VendingMachine();
            actualMesseage = objectVending.Use(userProductName);

            //Actual
            Assert.Equal(expectedMesseage ,actualMesseage);
        }
        [Fact]
        public void Test_Use_Messeage_Candy()
        {
            //Actual
            string expectedMesseage = "LIFE IS TOO SHORT MAKE IT SWEET, PLEASE ENJOY OUR CANDY";
            string userProductName = "CANDY";
            string actualMesseage;

            //Act
            VendingMachine objectVending = new VendingMachine();
            actualMesseage = objectVending.Use(userProductName);

            //Actual
            Assert.Equal(expectedMesseage, actualMesseage);
        }
        [Fact]
        public void Test_Use_Messeage_HealthySnack()
        {
            //Actual
            string expectedMesseage = "LIFE IS SHORT EAT THE DESSERT FIRST,  PLEASE ENJOY OUR CAKE";
            string userProductName = "CAKE";
            string actualMesseage;

            //Act
            VendingMachine objectVending = new VendingMachine();
            actualMesseage = objectVending.Use(userProductName);

            //Actual
            Assert.Equal(expectedMesseage, actualMesseage);
        }
    }
}
