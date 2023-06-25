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
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            yield return ParseLine(line);
        }
    }

    private static PasswordEntry ParseLine(ReadOnlySpan<char> line)
    {
        line = line.Trim();
        var spaceIndex = line.IndexOf(' ');
        var requiredChar = line.Slice(0, spaceIndex)[0];
        line = line.Slice(spaceIndex + 1).TrimStart();

        var dashIndex = line.IndexOf('-');
        if (!int.TryParse(line.Slice(0, dashIndex), out var min))
        {
            throw new InvalidOperationException();
        }
        line = line.Slice(dashIndex + 1).TrimStart();

        var colonIndex = line.IndexOf(':');
        if (!int.TryParse(line.Slice(0, colonIndex), out var max))
        {
            throw new InvalidOperationException();
        }
        line = line.Slice(colonIndex + 1).TrimStart();
        
        return new PasswordEntry
        {
            Rule = new ValidationRule
            {
                RequiredChar = requiredChar,
                Min = min,
                Max = max
            },
            Password = line.Trim().ToString()
        };
    }
}