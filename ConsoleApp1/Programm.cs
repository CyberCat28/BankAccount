using Classes;

var account = new BankAccount("Vika", 1000);
Console.WriteLine($"Акаунт {account.Number} Создан {account.Owner}. На нём {account.Balance} баланс.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negativebalance");
   
    Console.WriteLine(e.ToString());
    return;
}

try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}
Console.WriteLine(account.GetAccountHistory());