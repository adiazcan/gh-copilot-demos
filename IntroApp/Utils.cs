using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroApp;

public class Utils
{
    public static int GetYearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }

    public static string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }

    public static string GetFullNameFromEmail(string email)
    {
        var parts = email.Split('@');
        return parts[0];
    }
}

