namespace PasswordChecker.Models;

public struct ValidationRule
{
    public char RequiredChar { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }
}