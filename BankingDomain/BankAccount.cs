﻿using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        public decimal GetBalance()
        {
            return _balance;
        }

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

        public virtual void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }
    }
}