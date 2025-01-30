using Classes;

var account = new BankAccount("Vika", 1000);
Console.WriteLine($"Акаунт {account.Number} Создан {account.Owner}. На нём {account.Balance} баланс.");