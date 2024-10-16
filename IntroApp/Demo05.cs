namespace IntroApp;

internal class Demo05
{
    string GetFullName(string firstName, string lastName)
    {
        var fn = firstName;
        var ln = lastName;
        var fn1 = $"{fn} {ln}";

        return fn1;
    }
}

