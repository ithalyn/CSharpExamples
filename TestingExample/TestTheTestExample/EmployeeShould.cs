using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using TestingExample;


namespace TestTheTestExample {
    [TestClass]
    public class EmployeeShould {
        [TestMethod]
        public void HaveFullStomachWhenToldToEatPizza() {
            //Arrange
            var employee = new TestingExample.Employee();
            //Act
            employee.EatPizza();
            //Assert
            Assert.IsTrue(employee.IsFull);
        }

        [TestMethod]
        public void Gain200CaleriesWhenEatingAPepperoniPizzaSlice(){
            //Arrange
            var employee = new TestingExample.Employee();
            var slice = Mock.Create<SliceOfPizza>();
            Mock.Arrange(() => slice.CalculateCalories()).Returns(200);
            //Act
            employee.EatPizza(slice);
            //Assert
            Assert.AreEqual(200, employee.Calories);
        }
    }
}
