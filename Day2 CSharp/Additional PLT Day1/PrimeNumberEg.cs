using System;

class PrimeNumber
{
    public void PrimeNum(int Num)
    {
        Boolean isPrime = true;
        Console.WriteLine("\nThe prime numbers between 1-{0} is:", Num);

        for (int i = 0; i <= Num; i++)
        {
            for (int j = 2; j <= Num; j++)
            {
                if (i != j && i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime == true)
            {
                if(i!=1)
                Console.WriteLine("{0}", i);

            }
            isPrime = true;
        }
    }




}

class EntryPoint
{
    static void Main(string[] args)
    {
        int Num;
        PrimeNumber FindPrimeNo = new PrimeNumber();
        string str;
        Console.WriteLine("Enter the number till which you want to show the prime Numbers");
        str = Console.ReadLine();
        Num = Convert.ToInt32(str);
        FindPrimeNo.PrimeNum(Num);
        Console.ReadLine();

    }
}

