sealed class nottobeinherited
{
    public int sum(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        nottobeinherited obj = new nottobeinherited();
        int result = obj.sum(5, 10);
        Console.WriteLine("The sum is: " + result);
    }
}

