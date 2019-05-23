using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalc
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void TestInit()
        {
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(2,4,6)]
        [TestCase(-2, 1, -1)]
        [TestCase(4, 0, 4)]
        public void Add_Two_Numbers(double number1, double number2, double expectedresult)
        {
            //Arrange
            _calculator.Number1 = number1;
            _calculator.Number2 = number2;
           
            //Act
            double result = _calculator.Add();
            //Assert
            Assert.AreEqual(expectedresult, result);
        }

        [Test]
        [TestCase(2, 4, -2)]
        [TestCase(-2, 1, -3)]
        [TestCase(4, 0, 4)]
        public void Subtract_Two_Numbers(double number1, double number2, double expectedresult)
        {
            //Arrange
            _calculator.Number1 = number1;
            _calculator.Number2 = number2;
            //Act
            double result = _calculator.Subtract();
            //Assert
            Assert.AreEqual(expectedresult, result);
        }

        [Test]
        [TestCase(-2, -4, 8)]
        [TestCase(-2, 1, -2)]
        [TestCase(4, 0, 0)]
        public void Multiply_Two_Numbers(double number1, double number2, double expectedresult)
        {
            //Arrange
            _calculator.Number1 = number1;
            _calculator.Number2 = number2;
            //Act
            double result = _calculator.Multiply();
            //Assert
            Assert.AreEqual(expectedresult, result);
        }

        [Test]
        [TestCase(-2, -4, 0.5)]
        [TestCase(-2, 1, -2)]
        [TestCase(4, -4, -1)]
        public void Successfully_Divide_Two_Numbers(double number1, double number2, double expectedresult)
        {
            //Arrange
            _calculator.Number1 = number1;
            _calculator.Number2 = number2;
            //Act
            double result = _calculator.Divide();
            //Assert
            Assert.AreEqual(expectedresult, result);
        }

        [Test]
        public void Divide_Two_Numbers_Throw_DivideByZeroException()
        {
            //Arrange
            _calculator.Number1 = 2;
            _calculator.Number2 = 0;
            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide());
        }

        private Calculator _calculator { get; set; }
    }
}
