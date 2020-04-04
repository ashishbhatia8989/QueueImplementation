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
            object dequeudobj = 0;

            try
            {

                while ((line = file.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                    queue.Enqueue((object)line);

                }


                Console.WriteLine("Starting to Read Queue");
                object[] copyofqueue = queue.ReturnQueue();
                for (int entry = 0; entry < copyofqueue.Length; entry++)
                {
                    Console.WriteLine(copyofqueue[entry].ToString());
                }



                Console.WriteLine("Starting DeqUeue");
                counter = 0;
                do
                {
                    dequeudobj = queue.DeQueue();
                    Console.WriteLine(dequeudobj.ToString());
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
