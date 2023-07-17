using System;

namespace Std
{
	class Program
	{
		static void Main()
		{
            var account=new BankAccount("qianzhu233",114514);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
	}
}