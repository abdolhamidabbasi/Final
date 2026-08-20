namespace Project0001.Models;

public class Student
{
    public string[]? FirstName { get; set; } = new string[2];
    public string[]? LastName { get; set; } = new string[2];
    public string[]? MobileNumber { get; set; } = new string[2];
    public string[]? CardNumber { get; set; } = new string[2];
    public string[]? BankName { get; set; } = new string[2];
    public string[]? YearofBirth { get; set; } = new string[2];
    public Guid[] Id { get; set; } = new Guid[2];
}
