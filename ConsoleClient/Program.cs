using PasswordChecker;

var reader = new PasswordReader();

var filePath = "D:/Repositories/trash/PasswordCheckerTestDate.txt";

var validPasswords = new Checker()
    .SetDefaultReader()
    .SetDefaultValidator()
    .CountValidPasswords(filePath);
Console.WriteLine(validPasswords);