
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine()??string.Empty);

// Using the static method from the sum class
int result1 = Sum.sumOfDigits(number);
Console.WriteLine($"Sum of digits using static method: {result1}");

// Using the instance method from the addition class
Addition additionInstance = new Addition();
int result2 = additionInstance.add(number);
Console.WriteLine($"Sum of digits using instance method: {result2}");

int result3 = SumofNunbers.GetInstance().sumOfDigits(number);
Console.WriteLine($"Sum of digits using singleton instance method: {result3}");

int result4 = SumofNunbers.GetInstance().sumOfDigits(number);
 Console.WriteLine($"Sum of digits using singleton instance method : {result4}");
static class Sum
{
    public static int sumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}

sealed class Addition
{
    public int add(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
}


public sealed class SumofNunbers
{
    private static readonly Lazy<SumofNunbers> Instance   = new Lazy<SumofNunbers>(()=> new SumofNunbers());

    public static SumofNunbers GetInstance() => Instance.Value;
     

    private SumofNunbers(){}
    public int sumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

}