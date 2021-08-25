﻿using System;

namespace BankingDomain
{
    public enum AccountType { Standard, Gold}
    public class BankAccount
    {
        private decimal _balance = 5000;
        public decimal GetBalance()
        {
            return _balance;
        }

        public AccountType Type = AccountType.Standard;

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
                throw new OverdraftException();
            }
            else
            {
                _balance -= amountToWithdraw;
            }
        }

        public void Deposit(decimal amountToDeposit)
        {
            decimal bonus = 0;
            if (Type == AccountType.Gold)
            {
                bonus = amountToDeposit * .10M;
            }
            _balance += amountToDeposit + bonus;
        }
    }
}