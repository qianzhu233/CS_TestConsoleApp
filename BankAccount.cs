using System;

namespace Std
{
    public class BankAccount
    {
        public string Number { get; }//识别数字
        public string Owner { get; set; }//所有者
        public decimal Balance { get; }//存款数
        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)//存款
        {

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)//取款
        {

        }
    }
}
