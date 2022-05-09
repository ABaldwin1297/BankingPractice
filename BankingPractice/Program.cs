using Banking;

var acct1 = new Account();
acct1.Name = "Checking";

var acct2 = new Account();
acct2.Name = "Savings";

acct1.Deposit(500);
acct1.Withdraw(200);
acct1.Transfer(100, acct2);

Console.WriteLine($"{acct1.Name} balance is {acct1.Balance}");
Console.WriteLine($"{acct2.Name} balance is {acct2.Balance}");