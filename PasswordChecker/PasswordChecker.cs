using PasswordChecker.Interfaces;

namespace PasswordChecker;

public class PasswordChecker
{
    private readonly IPasswordValidator _validator;
    private readonly IPasswordReader _reader;

    public PasswordChecker()
    {
        //TODO: split to the Builder + Strategy patterns, move this creation to the Builder (may be overkill)
        _validator = new PasswordValidator();
        _reader = new PasswordReader();
    }
    
    public int CountValidPasswords(string filename)
    {
        var passwordEntries = _reader.ReadPasswords(filename);

        var validCount = passwordEntries.Count(entry => _validator.IsValid(entry));
        return validCount;
    }
}