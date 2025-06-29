using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void Addition_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(0, 5, -5)]
        [TestCase(-1, -1, 0)]
        public void Subtraction_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(4, 5, 20)]
        [TestCase(-3, 2, -6)]
        [TestCase(0, 10, 0)]
        public void Multiplication_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(-8, 2, -4)]
        [TestCase(5, -1, -5)]
        public void Division_ReturnsCorrectResult(double a, double b, double expected)
        {
            var result = calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }

        [Test]
        public void AllClear_ResetsResultToZero()
        {
            calculator.Addition(10, 5);
            calculator.AllClear();
            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }
    }
}