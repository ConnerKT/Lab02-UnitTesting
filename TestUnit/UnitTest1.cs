using ATM;

namespace UnitTest
{

    public class Lab2Tests
    {
        [Theory]
        [InlineData(20)]
        public void BalanceDoesReturnBalance(decimal value)
        {
            Numbersgame.Balance = 0;
            Numbersgame.Deposit(value);
            decimal Balance = Numbersgame.ViewBalance();
            Assert.Equal(value, Numbersgame.ViewBalance());
        }
        [Theory]
        [InlineData(0)]
        public void BalanceIsZeroByDefault(decimal value)
        {
            decimal balance = Numbersgame.ViewBalance();
            Assert.Equal(value, balance);
        }
        [Theory]
        [InlineData(20, 10)]
        public void WithdrawIsFunctioning(decimal value, decimal withdrawAmount)
        {
            Numbersgame.Balance = 0;
            Numbersgame.Deposit(value);
            decimal targetAmount = value - withdrawAmount;
            decimal finalAmount = Numbersgame.Withdraw(withdrawAmount);
            Assert.Equal(targetAmount, finalAmount);
        }
        [Theory]
        [InlineData(20, 0)]
        public void WithdrawingZeroFails(decimal value, decimal withdrawAmount)
        {
            Numbersgame.Balance = 0;
            Numbersgame.Deposit(value);
            Assert.Throws<Exception>(() => Numbersgame.Withdraw(withdrawAmount));
        }
        [Theory]
        [InlineData(-10)]
        public void DepositNegativeFails(decimal value)
        {
            Numbersgame.Balance = 0;
            Assert.Throws<Exception>(() => Numbersgame.Deposit(value));
        }
        [Theory]
        [InlineData(20)]
        public void DepositFunctions(decimal value)
        {
            Numbersgame.Balance = 0;
            Assert.Equal(20, Numbersgame.Deposit(value));
        }

    }

}
