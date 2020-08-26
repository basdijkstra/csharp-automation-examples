using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void SavingsAccount_SufficientFunds_ExpectSuccessfulWithdrawal()
        {
            Account account = new Account(AccountType.SAVINGS, 1000);

            account.Withdraw(999);

            Assert.That(account.Balance, Is.EqualTo(1));
        }

        [Test]
        public void CheckingAccount_InsufficientFunds_ExpectSuccessfulWithdrawal()
        {
            Account account = new Account(AccountType.CHECKING, 1000);

            account.Withdraw(1005);

            Assert.That(account.Balance, Is.EqualTo(-5));
        }

        [Test]
        public void SavingsAccount_InsufficientFunds_ExpectSuccessfulWithdrawal()
        {
            Account account = new Account(AccountType.SAVINGS, 1000);

            account.Withdraw(1005);

            Assert.That(account.Balance, Is.EqualTo(-5));
        }
    }
}
