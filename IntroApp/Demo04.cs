namespace IntroApp;

internal class Demo04
{
    string firstName = "John";
    string lastName = "Doe";
    string age = "25";

    //function to get the year of birth from the age
    int GetYearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }

    // function to get the full name
    string GetFullName(string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }
}

