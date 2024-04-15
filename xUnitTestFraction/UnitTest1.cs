namespace xUnitTestFraction;
using FractionLibrary;
    public class FractionTests
    {
        [Fact]
        public void TestAdd()
        { 
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);
            Fraction expected = new Fraction(5, 6);

            Fraction result = f1.Add(f2);

        Assert.Equal(expected.Result(), result.Result());
    }

        [Fact]
        public void TestSubtract()
        {

            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(1, 2);
            Fraction expected = new Fraction(1, 4);

            Fraction result = f1.Subtract(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestMultiply()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(3, 5);
            Fraction expected = new Fraction(2, 5);

            Fraction result = f1.Multiply(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestDivide()
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(2, 3);
            Fraction expected = new Fraction(9, 8);

            Fraction result = f1.Divide(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

    [Fact]
        public void TestReciProcal()
        {
            Fraction f1 = new Fraction(2, 8);
            Fraction expected = new Fraction(8, 2);

            Fraction result = f1.ReciProcal();

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestInvert()
        {
            Fraction f1 = new Fraction(2, 8);
            Fraction expected = new Fraction(-2, 8);

            Fraction result = f1.Invert();

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestSimplify()
        {

            Fraction f1 = new Fraction(2, 8);
            Fraction expected = new Fraction(1, 4);

            Fraction result = f1.Simplify();

            Assert.Equal(expected.Result(), result.Result());
        }
        [Fact]
        public void TestResult()
        {
            Fraction f1 = new Fraction(3, 4);
            string expected = "0,75";

            string result = f1.Result();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestToString()
        {
            Fraction f1 = new Fraction(3, 4);
            string expected = "3/4";

            string result = f1.ToString();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAdd_WithNegativeFraction()
        {
            Fraction f1 = new Fraction(-1, 2);
            Fraction f2 = new Fraction(1, 3);
            Fraction expected = new Fraction(-1, 6);

            Fraction result = f1.Add(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestSubtract_WithNegativeResult()
        {
            Fraction f1 = new Fraction(1, 4);
            Fraction f2 = new Fraction(3, 2);
            Fraction expected = new Fraction(-5, 4);

            Fraction result = f1.Subtract(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestMultiply_ByZero()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(0, 5);
            Fraction expected = new Fraction(0, 1);

            Fraction result = f1.Multiply(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestDivide_ByZero()
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(0, 3);
            Fraction expected = new Fraction(0, 1);

            Fraction result = f1.Divide(f2);

            Assert.Equal(expected.Result(), result.Result());
        }

        [Fact]
        public void TestSimplify_WithNegativeFraction()
        {
            Fraction f1 = new Fraction(-2, 8);
            Fraction expected = new Fraction(-1, 4);

            Fraction result = f1.Simplify();

            Assert.Equal(expected.Result(), result.Result());
        }
}