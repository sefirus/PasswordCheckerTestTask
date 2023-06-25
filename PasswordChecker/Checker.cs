using PasswordChecker.Interfaces;

namespace PasswordChecker;

public class Checker
{
    private IPasswordValidator _validator;
    private IPasswordReader _reader;

    public Checker SetReader(IPasswordReader reader)
    {
        _reader = reader;
        return this;
    }
    
    public Checker SetDefaultReader()
    {
        _reader = new PasswordReader();
        return this;
    }
    
    public Checker SetValidator(IPasswordValidator validator)
    {
        _validator = validator;
        return this;
    }
    
    public Checker SetDefaultValidator()
    {
        _validator = new PasswordValidator();
        return this;
    }
    
    public int CountValidPasswords(string filename)
    {
        var passwordEntries = _reader.ReadPasswords(filename);
        var validCount = passwordEntries.Count(entry => _validator.IsValid(entry));
        return validCount;
    }
}