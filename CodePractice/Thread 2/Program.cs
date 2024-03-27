class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started ");

        Thread thread1 = new Thread(Thread1Func);
        Thread thread2 = new Thread(Thread2Func);

        thread1.Start();
        thread2.Start();
        if (thread2.Join(1000))
        {
            Console.WriteLine("Thrade 2 func Done ");
        }
        else
        {
            Console.WriteLine("Thrade 2 func not Done within 1 sec  so it Terminited");
        }
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(500);
            Console.WriteLine($"Now runing in :-{i}");

            if (thread2.IsAlive)
            {
                Console.WriteLine("thread 2 is Still Alive 🆗");
            }
            else
            {
                Console.WriteLine("thread 2 is Still Not Alive ❌ ");
            }
        }

        Console.WriteLine("Join  ");//if thread 2 func is not done within 1 sec hen its all other thread to run 

        Console.WriteLine("Main Thread End  ");
    }
    public static void Thread1Func()
    {

        Console.WriteLine("Theade 1 start");
        Thread.Sleep(1000);
        Console.WriteLine("Theade 2 start");

    }
    public static void Thread2Func()
    {
        Console.WriteLine("Theade 2 start");
        Thread.Sleep(3000);
        Console.WriteLine("thrade 2 func coming to main");
    }

    
    
}

