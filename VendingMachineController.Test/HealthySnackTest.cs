using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;
using Xunit;


namespace VendingMachineController.Test
{
  public  class HealthySnackTest
    {
        [Fact]
        public void Test_ProductName_Is_Good()
        {
            //Arrange
            string myOrder = "cola";

            //Act
            HealthySnack objSnack = new HealthySnack(myOrder);

            //Assert
            Assert.Equal(myOrder, objSnack.Name);
        }
        [Fact]
        public void HelthySnack_ProductName_Test()
        {
            //Arrange
            string expected = "Cola";

            //Act
            HealthySnack objSnack = new HealthySnack(expected);

            //Assert
            Assert.Contains(expected, objSnack.Name);
        }
    }
}
