namespace PasswordChecker.Models;

public struct PasswordEntry
{
    public ValidationRule Rule { get; set; }
    public string Password { get; set; }

    public override string ToString() => $"{Rule.RequiredChar}\t{Rule.Min}-{Rule.Max}:\t{Password}";
}