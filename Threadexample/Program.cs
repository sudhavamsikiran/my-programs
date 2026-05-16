
class Program
{
    static async Task Main()
    {
        //  List<int> evenNumbers = Enumerable.Range(1, 100).Where(n => n % 2 == 0).ToList();
        // List<int> oddNumbers = Enumerable.Range(1, 100).Where(n => n % 2 != 0).ToList();
        //  Thread t1 = new Thread(() => { evenNumbers.ForEach(n => System.Console.WriteLine($"Even: {n}"));   });
        // Thread t2 = new Thread(() => { oddNumbers.ForEach(n => System.Console.WriteLine($"Odd: {n}")); });
        // t1.Start();
        // t2.Start();
        // t1.Join();
        // t2.Join();

         Task tEven= Task.Run(() => Evenodd.PrintEvenAsync());
         Task tOdd= Task.Run(() => Evenodd.PrintOddAsync());
        await Task.WhenAll(tEven, tOdd);    

    }
}
 
static class Evenodd
{
     
     public static async Task PrintEvenAsync()
    {
        await Task.WhenAll(
    Enumerable.Range(1, 100)
        .Where(i => i % 2 == 0)
        .Select(async i =>
        {
            Console.WriteLine($"Even: {i}");
            await Task.Delay(10);
        }));
    }

    public static async Task PrintOddAsync()
    {
        await Task.WhenAll(
    Enumerable.Range(1, 100)
        .Where(i => i % 2 != 0)
        .Select(async i =>
        {
            Console.WriteLine($"Odd: {i}");
            await Task.Delay(10);
        }));
    }
}
