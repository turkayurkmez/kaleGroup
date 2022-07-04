namespace ThreadingProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //
            withThreads();
            //withTasks();

        }

        private static void withTasks()
        {
            PrintComponent printComponent = new PrintComponent();
            Task[] tasks = new Task[5];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(() => printComponent.PrintNumbers());
                tasks[i].Start();
                tasks[i].Wait();
                
            }
        }

        private static void withThreads()
        {
            PrintComponent printComponent = new PrintComponent();
            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(printComponent.PrintNumbers));
                threads[i].Start();


            }
        }
    }
}