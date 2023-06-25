using PasswordChecker.Interfaces;
using PasswordChecker.Models;

namespace PasswordChecker;

public class PasswordReader : IPasswordReader
{
    public IEnumerable<PasswordEntry> ReadPasswords(string filename)
    {
        var lines = File.ReadLines(filename);

        foreach (var line in lines)
        {
            yield return ParseLine(line);
        }
    }

    private static PasswordEntry ParseLine(ReadOnlySpan<char> line)
    {
        var index1 = line.IndexOf(' ');
        var index2 = line.IndexOf('-');
        var index3 = line.IndexOf(':');

        if (!int.TryParse(line.Slice(index1 + 1, index2 - index1 - 1), out var min)
            || !int.TryParse(line.Slice(index2 + 1, index3 - index2 - 2), out var max))
        {
            throw new InvalidOperationException();
        }
            
        var requiredChar = line[0];
        var password = line[(index3 + 2)..]; // Still need to convert to Memory<char> to use Trim()

        var rule = new ValidationRule
        {
            RequiredChar = requiredChar,
            Min = min,
            Max = max
        };

        return new PasswordEntry
        {
            Rule = rule,
            Password = password.ToArray()
        };
    }
}