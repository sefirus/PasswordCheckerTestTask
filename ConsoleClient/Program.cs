using PasswordChecker;

var reader = new PasswordReader();

var filePath = "D:/Repositories/trash/PasswordCheckerTestDate.txt";

var checker = new PasswordChecker.PasswordChecker();
Console.WriteLine(checker.CountValidPasswords(filePath));