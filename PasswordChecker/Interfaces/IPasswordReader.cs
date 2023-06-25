using PasswordChecker.Models;

namespace PasswordChecker.Interfaces;

public interface IPasswordReader
{
    public IEnumerable<PasswordEntry> ReadPasswords(string filename);

}