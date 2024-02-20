using System;

namespace Prime.Services
{
    public class PrimeService
    {
public bool IsPrime(int num)
{
    // Check edge cases
    if (num < 2)
        return false;

    // Check divisibility by 2 and 3
    if (num == 2 || num == 3)
        return true;

    if (num % 2 == 0 || num % 3 == 0)
        return false;

    // Check divisibility by numbers between 5 and sqrt(num)
    double maxDivider = Math.Sqrt(num);
    for (int i = 5; i <= maxDivider; i += 6)
    {
        if (num % i == 0 || num % (i + 2) == 0)
            return false;
    }

    return true;
}

    }
}