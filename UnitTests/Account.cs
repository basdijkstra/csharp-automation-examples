using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    class Account
    {
        public AccountType AccountType { get; set; }
        public int Balance { get; set; }

        public Account(AccountType accountType, int balance)
        {
            AccountType = accountType;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance && AccountType == AccountType.SAVINGS)
            {
                throw new Exception($"Insufficient balance: cannot withdraw {amount} when balance is {Balance}");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
