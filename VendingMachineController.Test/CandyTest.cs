using System;
using Xunit;
using VendingMachineController.Model;
using VendingMachineController.Data;

namespace VendingMachineController.Test
{
    public class CandyTest
    {
        [Fact]
        public void Test_ProductName_Is_Good()
        {
            //Arrange
            string myOrder = "candy";

            //Act
           Candy objCandy = new Candy(myOrder);

            //Assert
            Assert.Equal(myOrder, objCandy.Name);
        }
        [Fact]
        public void Candy_ProductName_Test()
        {
            //Arrange
            string expected = "Cola";

            //Act
            Candy objCandy = new Candy(expected);

            //Assert
            Assert.Contains(expected, objCandy.Name);
        }
    }
}
