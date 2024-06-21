using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);

            Assert.IsTrue(false); // vai galhar o teste
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(1, 1);

            // Assert
            Assert.AreEqual(2, actual);
        }
        [TestMethod]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(2, 2);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(2, 2);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            Assert.IsNull(actual);
        }
    }
}