double principal = 1000;
double rate = 3;
int compoundingFrequency = 12;
int years = 5;

double compoundInterest = CompoundInterestCalculator.CalculateCompoundInterest(principal, rate, compoundingFrequency, years);

Console.WriteLine($"Compound interest after {years} years: {compoundInterest}");

public static class CompoundInterestCalculator
{
    public static double CalculateCompoundInterest(double principal, double rate, double compoundingFrecuency, double time)
    {
        double coumpoundInterest = principal * Math.Pow(1 + (rate / compoundingFrecuency), time) - principal;
        return coumpoundInterest;
    }
}