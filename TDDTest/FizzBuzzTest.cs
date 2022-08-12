
namespace TDDTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        FizzBuzzE fb = new FizzBuzzE();
        [TestMethod]
        public void Given15Expect_FizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = fb.FizzBuzz(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given3Expect_Fizz()
        {
            var expected = "Fizz";
            var actual = fb.FizzBuzz(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given5Expect_Buzz()
        {
            var expected = "Buzz";
            var actual = fb.FizzBuzz(5);
            Assert.AreEqual(expected, actual);
        }

        
    }
}