using System;
using Xunit;
using ConsoleApp1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidWithdraw()
        {
            Assert.Equal(100, Class1.Withdraw(100));
            
        }
        [Fact]
        public void TestValidDeposit()
        {
            Assert.Equal(200, Class1.Deposit(200));

        }
    }
}
