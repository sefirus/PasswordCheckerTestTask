using PasswordChecker.Interfaces;
using PasswordChecker.Models;

namespace PasswordChecker;

public class PasswordValidator : IPasswordValidator
{
    public bool IsValid(PasswordEntry passwordEntry)
    {
        var charCount = passwordEntry.Password.Count(c => c == passwordEntry.Rule.RequiredChar);
        var isValid = charCount >= passwordEntry.Rule.Min && charCount <= passwordEntry.Rule.Max;
        return isValid;
    }
}