using PasswordChecker.Models;

namespace PasswordChecker.Interfaces;

public interface IPasswordValidator
{
    bool IsValid(PasswordEntry passwordEntry);
}