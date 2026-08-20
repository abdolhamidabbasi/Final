using System.Data;
using System.Text.RegularExpressions;
using Project0001.Models;
namespace Project0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi dear");
            int i = 0;
            Student student = new();
            while (i < 2)
            {
                Console.WriteLine("Please fill the form.");
                while (true)
                {
                    Console.WriteLine("FirstName: ");
                    if (Regex.IsMatch(student.FirstName[i] = Console.ReadLine(), @"^[a-zA-Z. ]{3,50}$"))
                    {
                        break;
                    }
                    Console.WriteLine("\"" + student.FirstName[i] + "\"" + " is not valid FirstName!");
                }
                while (true)
                {
                    Console.WriteLine("LastName: ");
                    if (Regex.IsMatch(student.LastName[i] = Console.ReadLine(), @"^[a-zA-Z. ]{3,50}$"))
                    {
                        break;
                    }
                    Console.WriteLine("\"" + student.LastName[i] + "\"" + " is not valid LastName!");
                }
                Console.WriteLine("MobileNumber: ");
                while (true)
                {
                    if (Regex.IsMatch(student.MobileNumber[i] = Console.ReadLine(), @"^(\+98|98|0)?9\d{9}$"))
                    //+98,98 and 0 are optional, start with 9, follow by 9 numbers.
                    {
                        if (student.MobileNumber[i].Length == 10)
                        {
                            student.MobileNumber[i] = "0" + student.MobileNumber[i];
                            break;
                        }
                        else if (student.MobileNumber[i].Length == 13)
                        {
                            student.MobileNumber[i] = student.MobileNumber[i].Replace("+98", "0");
                            break;
                        }
                        else if (student.MobileNumber[i].Length == 12)
                        {
                            student.MobileNumber[i] = student.MobileNumber[i].Replace("98", "0");
                            break;
                        }
                        break;
                    }
                    Console.WriteLine("It is not a valid Number! \nTry again:");
                }
                int year = default;
                while (true)
                {
                    Console.WriteLine("Year of Birth: ");
                    if (Regex.IsMatch(student.YearofBirth[i] = Console.ReadLine(), @"^\d{4}$"))
                    {
                        year = Convert.ToInt32(student.YearofBirth[i]);
                        year = DateTime.Now.Year - year;
                        if (year <= 126 && year >= 18)
                        {
                            break;
                        }
                        year = year - 621;
                        if (year <= 105 && year >= 18)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("\"It is not a valid year!");
                    Console.WriteLine("*Notice*: The year must be between 1300 to 1387 or 1900 to 2008.");
                }
                while (true)
                {
                    Dictionary<string, string> card = new()
                {
                    { "603799", "Melli"},  { "627381", "Ansar"},    { "627412", "Eghtesad Novin"},
                    { "622106", "Parsian"},{ "639194", "Parsian"},  { "603769", "Saderat"},
                    { "627884", "Parsian"},{ "502229", "Pasargad"}, { "639347", "Pasargad"},
                    { "636214", "Ayandeh"},{ "627353", "Tejarat"},  { "502908", "Ta'avon"},
                    { "502938", "Dey"},    { "589463", "Refah"},    { "621986", "Saman"},
                    { "589210", "Sepah"},  { "639607", "Sarmayeh"}, { "639346", "Sina"},
                    { "606373", "Mehr"},   { "627488", "Karafarin"},{ "603770", "Keshavarzi"},
                    { "628023", "Mskan"},  { "627760", "Post"},     { "505785", "Iran Zamin"},
                    { "610433", "Mellat"}, { "502806", "Shahr"},    { "505416", "Gardeshgari"},
                    { "627961", "Sanat & Ma'dan"}
                };
                    Console.WriteLine("CardNumber?");
                    if (Regex.IsMatch(student.CardNumber[i] = Console.ReadLine(), @"^\d{16}$"))
                    {
                        if (card.TryGetValue(student.CardNumber[i][..6], out string? name))
                        {
                            student.BankName[i] = name;
                            break;
                        }
                    }
                    ;
                    Console.WriteLine("It is not a valid CardNumber! \nTry again:");
                }
                i++;
                for (int a = 0; a < i; a++)
                {
                    student.Id[a] = Guid.NewGuid();
                    Console.WriteLine("\nStudent " + (a + 1) + ": Guid:" + student.Id[a] + ", FullName: " +
                        student.FirstName[a].Replace(" ", "") + " " + student.LastName[a].Replace(" ", "") +
                        ", MobileNumber: " + student.MobileNumber[a] + ", age: " + year + ", CardNumber: " +
                        student.CardNumber[a] + " (" + student.BankName[a] + ")");
                }
                Console.WriteLine("\nEnter (e) to exit, otherwise press (Enter) to add a new student");
                string? NewStudent = Console.ReadLine().ToLower();
                if (NewStudent == "e")
                {
                    break;
                }
            }
        }
    }
}
