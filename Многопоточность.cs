using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    static void mythread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Поток 1 выводит " + i);
            
        }
        Console.WriteLine("-----------------------------------------------------------");
    }

    static void mythread2()
    {

        for (int i = 10; i < 20; i++)
        {
            Console.WriteLine(new String(' ', 18) + "Поток 2 выводит " + i);
            
        }
        Console.WriteLine("-----------------------------------------------------------");
    }

    static void mythread3()
    {
        for (int i = 20; i < 30; i++)
        {
            Console.WriteLine(new String(' ', 36) + "Поток 3 выводит " + i);
            
        }
        Console.WriteLine("-----------------------------------------------------------");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Информация по нитям: ");
        
        Thread thread1 = new Thread(mythread1);
        Thread thread2 = new Thread(mythread2);
        Thread thread3 = new Thread(mythread3);
        thread1.Priority = ThreadPriority.Highest;
        thread2.Priority = ThreadPriority.Normal;
        thread3.Priority = ThreadPriority.Lowest;
        Console.WriteLine($"Thread 1 Приоритет: {thread1.Priority}");
        Console.WriteLine($"Thread 2 Приоритет: {thread2.Priority}");
        Console.WriteLine($"Thread 3 Приоритет: {thread3.Priority}");
        Console.WriteLine();
        thread1.Start();
        thread2.Start();
        thread3.Start();

        Console.ReadLine();
    }

}



