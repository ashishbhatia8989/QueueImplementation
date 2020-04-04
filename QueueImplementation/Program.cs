using System;
using System.IO;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the circular Queue");
            Queue queue = new Queue();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\abhatia\source\repos\QueueImplementation\QueueImplementation\TextFile1.txt");
            string line;
            int counter = 0;
            int dequeudint = 0;

            try
            {

                while ((line = file.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                    queue.Enqueue(int.Parse(line));

                }


                Console.WriteLine("Starting to Read Queue");
                int[] copyofqueue = queue.ReturnQueue();
                for (int entry = 0; entry < copyofqueue.Length; entry++)
                {
                    Console.WriteLine(copyofqueue[entry].ToString());
                }



                Console.WriteLine("Starting DeqUeue");
                counter = 0;
                do
                {
                    dequeudint = queue.DeQueue();
                    Console.WriteLine(dequeudint.ToString());
                    counter++;
                }
                while (counter <= copyofqueue.Length);

                               
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                file.Close();
                Console.ReadLine();
            }

            
        }
    }
}
