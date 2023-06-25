using PasswordChecker.Interfaces;
using PasswordChecker.Models;

namespace PasswordChecker;

public class PasswordValidator : IPasswordValidator
{
    public bool IsValid(PasswordEntry passwordEntry)
    {
        throw new NotImplementedException();
    }
}