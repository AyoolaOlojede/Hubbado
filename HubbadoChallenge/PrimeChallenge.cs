using System.Collections.Generic;
using System;

public class PrimeChallenge
{

    public void GeneratePrimesOfTableCells(int N)
    {
        var primes=GeneratePrimes(N);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                var result=AddPrimesByIndex(i,j,primes);
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }

    public List<int> GeneratePrimes(int N)
    {
    List<int> primes = new List<int>();
    primes.Add(2);
    int nextPrime = 3;
    while (primes.Count < N)
    {
        int sqrt = (int)Math.Sqrt(nextPrime);
        bool isPrime = true;
        for (int i = 0; (int)primes[i] <= sqrt; i++)
        {
            if (nextPrime % primes[i] == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            primes.Add(nextPrime);
        }
        nextPrime += 2;
    }
    return primes;
    }

    public long AddPrimesByIndex(int a,int b,List<int> primes)
    {
      return primes[a]+primes[b];
    }
    
}