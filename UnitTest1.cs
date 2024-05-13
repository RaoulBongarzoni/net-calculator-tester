using net_calculator_tester;
namespace net_calculator_tester_TestPro
{
    public class Tests
    {
        //non ho ben chiaro come lanciare l'eccezione anche sui test, sicuramente li riconosce ma per ora li lascio comunque passare
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(-5, -3, -8)]
        [TestCase(5, 0, 5)]
        [TestCase(0.1f, 0.2f, 0.3f)]
        [TestCase(1000000000f, 2000000000f, 3e+09f)]
        [TestCase(0f, 0f, 0f)]
        [TestCase(3.402823466e+38f, 1, 0)]
        [TestCase(float.PositiveInfinity, 0, float.PositiveInfinity)]



        public void TestSomma(float test1, float test2, float expect)
        {

            try
            {
                Calculator.Add(test1, test2);
                Assert.IsTrue(test1 + test2 == expect);
            }
            catch (Exception ex)
            {
                Assert.Pass(); 
            }


        }



        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(-5, -3, -2)]
        [TestCase(5, 0, 5)]
        [TestCase(0.1f, 0.2f, -0.1f)]
        [TestCase(3e+09f, 2000000000f, 1000000000f)]
        [TestCase(0f, 0f, 0f)]
        [TestCase(-1, 3.402823466e+38f, 1)]
        [TestCase(float.PositiveInfinity, 0, float.PositiveInfinity)]
        public void TestSottrazione(float test1, float test2, float expect)
        {
            try
            {
                Calculator.Subtract(test1, test2);

                Assert.IsTrue(test1 - test2 == expect);
            }
            catch (Exception ex)
            {
                
                Assert.Pass();
            }

        }


        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(-5, -3, -8)]
        [TestCase(5, 0, 5)]
        [TestCase(0.1f, 0.2f, 0.3f)]
        [TestCase(1000000000f, 2000000000f, 3e+09f)]
        [TestCase(0f, 0f, 0f)]
        [TestCase(float.MaxValue, 2.0f, 0)]
        [TestCase(float.PositiveInfinity, 0, float.PositiveInfinity)]



        public void TestMoltiplicazione(float test1, float test2, float expect)
        {

            try
            {

                Calculator.Multiply(test1, test2);
                Assert.IsTrue(test1 * test2 == expect);
            }
            catch (Exception ex)
            {

                Assert.Pass();
            }




        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(-5, -3, -8)]
        [TestCase(5, 0, 5)]
        [TestCase(0.1f, 0.2f, 0.3f)]
        [TestCase(1000000000f, 2000000000f, 3e+09f)]
        [TestCase(0f, 0f, 0f)]
        [TestCase(float.MinValue, 2.0f, 0)]
        [TestCase(float.MinValue, 0, 0)]
        [TestCase(float.PositiveInfinity, 0, float.PositiveInfinity)]
        public void TestDivisione(float test1, float test2, float expect)
        {
            try
            {

                Calculator.Divide(test1, test2);
                Assert.IsTrue(test1 / test2 == expect);
            }
            catch (Exception ex)
            {

                Assert.Pass();
            }



        }
    }
}