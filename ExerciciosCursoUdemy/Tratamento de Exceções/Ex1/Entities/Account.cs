using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex1.Entities.Exceptions;

namespace Ex1.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > this.WithDrawLimit)
            {
                throw new AccountException("O valor de saque não pode ser maior que o limite de saque !!!");
            }
            else if(this.Balance < amount)
            {
                throw new AccountException("O valor de saque não pode ser maior que o valor existente na conta !!!");
            }
            else{
                this.Balance -= amount;
            }
        }
    }
}