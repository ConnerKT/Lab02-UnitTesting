using Xunit;

namespace UnitTest
{

    public class Lab2Tests
    {
        [Theory]
        [InlineData("12")]
        [InlineData("22")]

        public void ViewBalanceTest(string balance)
        {
            var deciamalBalance = Convert.ToDecimal(balance);
            Assert.Equal(deciamalBalance, Program.ViewBalanceTest(deciamalBalance));
        }
    }