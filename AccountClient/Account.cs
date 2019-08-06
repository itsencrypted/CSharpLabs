using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClient
{
    class Account
    {
        public int accnumber;
        public string beneficialowner;
        public double balance;

       private void button1_Click (object sender) {
        Account acc = new Account();
        acc.accnumber = 1;
        acc.beneficialowner = "warren buffet";
        acc.balance = 100;
        }

        public bool Withdraw(double value)
        {
            if (this.balance >= value)
            {
                this.balance -= value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(double value)
        {
            this.balance += value;
        }

        public void Transfer(double value, Account from, Account to)
        {
            if(this.balance >= value)
            {
                this.balance -= value;
                to.balance += value;
            }
        }

        private void button2_Click(object sender)
        {
            Account accountwarren = new Account();
            accountwarren.beneficialowner = "Warren Buffet";
            accountwarren.accnumber = 0001;
            accountwarren.Deposit(11000);
            Console.WriteLine("Balance: " + accountwarren.balance);
            accountwarren.Withdraw(999);
            Console.WriteLine("Balance: " + accountwarren.balance);
        }

    }
}
