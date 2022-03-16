using System;
using Xunit;
using Lab_2;


namespace tsetATM
{
    public class UnitTest1
    {
         [Theory]
        [InlineData(150)]
        [InlineData(210.35)]
        public void TestWithdraw(decimal value)
        {
            decimal result = Program.Withdraw(value);
            Assert.Equal(result, Program.ViewBalance());

        }

        [Theory]
        [InlineData(150)]
        [InlineData(210.35)]
        public void TestDeposit(decimal value)
        {
            decimal result = Program.Deposit(value);
            Assert.Equal(result, Program.ViewBalance());
        }

    }
}
