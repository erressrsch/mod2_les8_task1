using System;

class Program
{
    static void Main()
    {
        int primeNumbersCount = 0;

        for (int i = 2; i <= 100; i++)
        {
            if (isPrime(i))
            {
                primeNumbersCount++;

            }
        }

        Console.WriteLine($"the number of prime numbers in the range is: {primeNumbersCount}");

    }
    static bool isPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;

            }
        }
        return true;
    }
}