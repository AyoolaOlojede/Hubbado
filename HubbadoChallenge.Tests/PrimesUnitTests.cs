using System;
using Xunit;
using HubbadoChallenge;



namespace HubbadoChallenge.Tests
{
    public class PrimesUnitTests
    {

        private readonly PrimeChallenge primeChallenge;
        public PrimesUnitTests()
        {
            primeChallenge=new PrimeChallenge();
        }

       [Fact]
        public void Prime_CheckIsValidPrime_ShouldReturnTrue()
        {
        var result=primeChallenge.GeneratePrimes(10);
         Assert.Equal(2,result[0]);
         Assert.Equal(3,result[1]);
         Assert.Equal(5,result[2]);
         Assert.Equal(7,result[3]);
         Assert.Equal(11,result[4]);
         Assert.Equal(13,result[5]);
         Assert.Equal(17,result[6]);
         Assert.Equal(19,result[7]);
         Assert.Equal(23,result[8]);
         Assert.Equal(29,result[9]);
         
        }

        [Fact]
        public void Prime_CountNoOfPrimes_ShouldReturnCountOfValidPrimes()
        {
         var result=primeChallenge.GeneratePrimes(3);
         Assert.Equal(3,result.Count);
        }


       [Fact]
        public void Prime_AddTheContentOfTheCellPrimes_ShouldReturnSumOfIndexPrimes()
        {
         var primes=primeChallenge.GeneratePrimes(3);
         var totalCellValue1=primeChallenge.AddPrimesByIndex(0,0,primes);//row 1 col 1
         var totalCellValue2=primeChallenge.AddPrimesByIndex(0,1,primes);//row 1 col 2
         var totalCellValue3=primeChallenge.AddPrimesByIndex(0,2,primes);//row 1 col 3

         Assert.Equal(4,totalCellValue1);
         
         Assert.Equal(5,totalCellValue2);
         Assert.Equal(7,totalCellValue3);
        }




    }
}
