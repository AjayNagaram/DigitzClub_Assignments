using BankingKata;
using BankKata.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankKata.Tests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        [DataRow(500, 100, 600)]
        [DataRow(230, 70, 300)]
        [DataRow(320, 100, 420)]
        public void Deposit_BalanceIncreasesWhenMakingADeposit(int balance, int amountToDeposit, int expectedBalance)
        {
            // Arrange
            Account account = new Account(balance);

            // Act
            account.Deposit(amountToDeposit);

            // Assert
            Xunit.Assert.Equal(expectedBalance, account.balance);
        }


        [TestMethod]
        [DataRow(500, 100, 400)]
        [DataRow(230, 70, 160)]
        [DataRow(320, 100, 220)]
        public void Withdraw_BalanceDecreseasWhenMakingAWithdrawal(int balance, int amountToWithdraw, int expectedBalance)
        {
            // Arrange
            Account account = new Account(balance);


            // Act
            account.Withdraw(amountToWithdraw);

            // Assert
            Xunit.Assert.Equal(expectedBalance, account.balance);
        }

        [TestMethod]
        [DataRow("Date            Amount  Balance\n8/8/2021\t-500\t500\n9/9/2021\t+200\t700\n")]
        public void PrintStatement_StatementShouldIncludeHeaderAndRegistryOperationsTable(string expectedStatement)
        {
            // Arrange

            // 0 for dummy data

            Account account = new Account(0);

            account.registry = Transactions.Data;

            // Act

            string printStatement = account.PrintStatement();

            // Assert

            Xunit.Assert.Equal(expectedStatement, printStatement);
        }
    }

    public class Transactions
    {
        public static List<IRegistryRecord> Data = new List<IRegistryRecord>
              {
                  new Withdrawal(500, 500, new DateTime(2021, 08, 08)),
                  new Deposit(700, 200, new DateTime(2021, 09, 09))
              };
    }
}
