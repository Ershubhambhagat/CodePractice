Console.WriteLine("Waiting");
Console.ReadKey();

int n = 100;

#region Thread


foreach (var item in Enumerable.Range(0, n).ToList())
{
    new Thread(() =>
    {
        Console.WriteLine($"Start Thread number {Thread.CurrentThread.ManagedThreadId} ");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread number End{Thread.CurrentThread.ManagedThreadId}");
    });
    // }).Start();
}
Console.ReadKey();
Enumerable.Range(0, n).ToList().ForEach(f =>
{
    new Thread(() =>
    {
        Console.WriteLine($"Start Thread number {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread number End{Thread.CurrentThread.ManagedThreadId}");
    });
    // }).Start();

});
Console.WriteLine("3 Waiting");

Console.ReadKey();
#endregion