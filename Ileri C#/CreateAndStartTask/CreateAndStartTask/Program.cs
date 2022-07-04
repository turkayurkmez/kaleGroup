
public class Program
{

    public static void Main()
    {
        Task task1 = new Task((obj) => printMessage(obj), "ilk task");      
        Task task2 = Task.Run(() => Console.WriteLine("ikinci task"));

        task1.Start();
       
    }

    static void printMessage(object message)
    {
        Console.WriteLine(message);
        Thread.Sleep(1000);

    }

}





