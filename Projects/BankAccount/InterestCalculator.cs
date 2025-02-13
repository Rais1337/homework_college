using System;

public static class InterestCalculator
{
    public static decimal CalculateInterest(decimal amount, decimal annualRate, int days)
    {
        decimal dailyRate = annualRate / 100 / 365;
        return amount * dailyRate * days;
    }

    public static decimal CalculateInterestWithChanges(decimal amount, (decimal rate, int days)[] rateChanges)
    {
        decimal totalInterest = 0m;
        foreach (var change in rateChanges)
        {
            decimal dailyRate = change.rate / 100 / 365;
            totalInterest += amount * dailyRate * change.days;
        }
        return totalInterest;
    }
}
