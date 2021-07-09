using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineController.Model;
using VendingMachineController.Data;
using Xunit;

namespace VendingMachineController.Test
{
    public class ColaTest
    {
        [Fact]
        public void Test_ProductName_Is_Good()
        {
            //Arrange
            string myOrder = "cola";

            //Act
            Cola objCola = new Cola(myOrder);

            //Assert
            Assert.Equal(myOrder, objCola.Name);
        }
        [Fact]
        public void Cola_ProductName_Test()
        {
            //Arrange
            string expected = "COLA";

            //Act
            Cola objCola = new Cola(expected);

            //Assert
            Assert.Contains(expected, objCola.Name);
        }
       
    }
}
