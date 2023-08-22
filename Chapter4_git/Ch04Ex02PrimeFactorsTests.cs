using static Chapter4.Ch04Ex02PrimeFactorsLib;
using NUnit.Framework;

namespace Chapter4
{
    public class Ch04Ex02PrimeFactorsTests
    {
        [Test]
        public void Test5PrimeFactors()
        {
            int five = 5;
            String primes = PrimeFactors(five);
            Assert.AreEqual(primes, "Prime factors of 5 are: 5");
        }

        [Test]
        public void Test125PrimeFactors()
        {
            int one_two_five = 125;
            String primes = PrimeFactors(one_two_five);
            Assert.AreEqual(primes, "Prime factors of 125 are: 5 x 5 x 5");
        }

        [Test]
        public void Test12500PrimeFactors()
        {
            int one_two_five_zero_zero = 12500;
            String primes = PrimeFactors(one_two_five_zero_zero);
            Assert.AreEqual(primes, "Prime factors of 12500 are: 2 x 2 x 5 x 5 x 5 x 5 x 5");
        }

    }
}
