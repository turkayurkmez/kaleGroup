namespace TaskScenerios
{
    internal class Program
    {
        static void printMessage()
        {
            Console.WriteLine("Print message fonksiyonu çalıştı!");
        }
        static void Main(string[] args)
        {
            Task task1 = new Task(()=>printMessage());
            Task task2 = Task.Run(()=>printMessage());
            Task task3 = Task.Factory.StartNew(()=>printMessage());


            task1.Start();
            task1.Wait();
            task2.Wait();
            task3.Wait();

        }
    }
}