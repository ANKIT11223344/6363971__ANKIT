using System;

public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObj = new object();

    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created");
    }


    public static Singleton GetInstance()
    {

        lock (lockObj)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
        }
        return instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        Console.WriteLine(object.ReferenceEquals(s1, s2));  
    }
}