using System;
using System.IO;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the circular Queue");
            Queue<int> intqueue = new Queue<int>();
            Queue<string> strqueue = new Queue<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\abhatia\source\repos\QueueImplementation\QueueImplementation\TextFile1.txt");
            string line;
            int counter = 0;
            int dequeudintobj = 0;
            string dequeudstrobj = string.Empty;
            

            try
            {

                while ((line = file.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                     
                    if (int.TryParse(line, out dequeudintobj))
                    { 
                    intqueue.Enqueue(int.Parse(line));
                    }
                    else
                    {
                        strqueue.Enqueue(line);
                    }

                }


                Console.WriteLine("Starting to Read Queue");
                int[] copyofintqueue = intqueue.ReturnQueue();
                string[] copyofstrqueue = strqueue.ReturnQueue();

                for (int entry = 0; entry < copyofintqueue.Length; entry++)
                {
                    Console.WriteLine("Reading Int Queue");
                    Console.WriteLine(copyofintqueue[entry].ToString());
                }

                for (int entry = 0; entry < copyofstrqueue.Length; entry++)
                {
                    if(copyofstrqueue[entry] != null)
                    { 
                        Console.WriteLine("Reading String Queue");
                        Console.WriteLine(copyofstrqueue[entry].ToString());
                    }
                    else { break; }

                }

                Console.WriteLine("Starting Int DeqUeue");
                counter = 0;
                do
                {
                    dequeudintobj = intqueue.DeQueue();
                    Console.WriteLine(dequeudintobj.ToString());
                    counter++;
                }
                while (counter <= copyofintqueue.Length);

                Console.WriteLine("Starting String DeqUeue");
                counter = 0;
                do
                {
                    dequeudstrobj = strqueue.DeQueue();
                    Console.WriteLine(dequeudstrobj);
                    counter++;
                }
                while (counter <= copyofstrqueue.Length);





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
