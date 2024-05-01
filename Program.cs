namespace ThreadsVSTasks
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Thread thread = new Thread(DoWork);
        //    thread.Start();

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Main thread: Working...");
        //        Thread.Sleep(500);
        //    }

        //    thread.Join();
        //    Console.WriteLine("Main thread: Other thread has finished.");
        //}

        static async Task Main()
        {
            Task task = Task.Run(DoWork);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread: Working...");
                await Task.Delay(500);
            }

            await task;
            Console.WriteLine("Main thread: Other task has finished.");
        }

        static async Task DoWork()
        {
            // Code executed by the other task
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Other task: Working...");
                await Task.Delay(1000); // Simulate some work being done by the other task
            }
            Console.WriteLine("Other task: Finished.");
        }

        //static void DoWork()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Other thread: Working...");
        //        Thread.Sleep(1000);
        //    }
        //    Console.WriteLine("Other thread: Finished.");
        //}
    }
}
