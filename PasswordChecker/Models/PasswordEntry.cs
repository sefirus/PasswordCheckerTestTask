namespace PasswordChecker.Models;

public struct PasswordEntry
{
    public ValidationRule Rule { get; set; }
    public ReadOnlyMemory<char> Password { get; set; }
}