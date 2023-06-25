using PasswordChecker;

var reader = new PasswordReader();

var x = reader.ReadPasswords("D:/Repositories/trash/PasswordCheckerTestDate.txt");
foreach (var passwordEntry in x)
{
    Console.WriteLine(passwordEntry);
}