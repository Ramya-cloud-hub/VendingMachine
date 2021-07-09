using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;
using Xunit;

namespace VendingMachineController.Test
{
  public  class ProductTest
    {
        [Fact]
        public void Test_ProductName_Cola_Is_Good()
        {
            //Arrange
            string myOrder = "Cola";

            //Act
            Products objCola = new Cola(myOrder);

            //Assert
            Assert.Equal(myOrder, objCola.Name);
        }
        [Fact]
        public void Test_ProductName_Candy_Is_Good()
        {
            //Arrange
            string myOrder = "Candy";

            //Act
            Products objCandy = new Candy(myOrder);

            //Assert
            Assert.Equal(myOrder, objCandy.Name);
        }
        [Fact]
        public void Test_ProductName_HealthySnack_Is_Good()
        {
            //Arrange
            string myOrder = "Cake";

            //Act
            Products objSnack = new HealthySnack(myOrder);

            //Assert
            Assert.Equal(myOrder, objSnack.Name);
        }
        [Fact]
        public void Snack_Productos_ProductName_Test()
        {
            //Arrange
            string expected = "Cake";

            //Act
            Products objSnack = new HealthySnack(expected);

            //Assert
            Assert.Contains(expected, objSnack.Name);
        }
        [Fact]
        public void Cola_Producto_ProductName_Test()
        {
            //Arrange
            string expected = "Cola";

            //Act
            Products objCola = new Cola(expected);

            //Assert
            Assert.Contains(expected, objCola.Name);
        }
        [Fact]
        public void Candy_Producto_ProductName_Test()
        {
            //Arrange
            string expected = "Candy";

            //Act
            Products objCandy = new Candy(expected);

            //Assert
            Assert.Contains(expected, objCandy.Name);
        }

    }
}
