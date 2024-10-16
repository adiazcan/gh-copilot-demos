object s_lock1 = new object();
object s_lock2 = new object();

void Method2()
{
    lock (s_lock2)
    {
        Console.WriteLine("Other thread acquire lock2");
        lock (s_lock1)
        {
            Console.WriteLine("Other thread acquire lock1");
        }
    }
}

lock (s_lock1)
{
    Console.WriteLine("Main thread acquire lock1");

    Task.Run(Method2);
    Thread.Sleep(2000);

    lock (s_lock2)
    {
        Console.WriteLine("Main thread acquire lock2");
    }
}

