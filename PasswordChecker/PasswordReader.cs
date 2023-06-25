using PasswordChecker.Interfaces;
using PasswordChecker.Models;

namespace PasswordChecker;

public class PasswordReader : IPasswordReader
{
    public IEnumerable<PasswordEntry> ReadPasswords(string filename)
    {
        throw new NotImplementedException();
    }
}