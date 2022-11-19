using Course.Entities;

namespace Course
{
    class Course
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            HashSet<LogRecord> userSet = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string user = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        userSet.Add(new LogRecord(user, instant));
                    }
                }

                Console.WriteLine("Total users: " + userSet.Count());
            }
            catch (IOException e)
            {
                Console.WriteLine("An exception ocurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception: " + e.Message);
            }
        }
    }
}