using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadWrite
{
    public static class Program
    {
        private static void Main()
        {

            const string fileName = @"\somerandomtext.txt";

            // Read file 1
            var counter3 = Stopwatch.StartNew();
            string file = new StreamReader(fileName).ReadToEnd();
            counter3.Stop();
            Console.WriteLine(counter3.ElapsedMilliseconds);
            string[] line = file.Split('\n');
            Console.WriteLine(line.Count());

            // Read file 2
            var counter2 = Stopwatch.StartNew();
            List<string> lines = File.ReadAllLines(fileName).ToList();
            counter2.Stop();
            Console.WriteLine(counter2.ElapsedMilliseconds);
            Console.WriteLine(lines.Count());

            // Read file 3
            using (StreamReader sr = File.OpenText(fileName))
            {
                StringBuilder sb = new StringBuilder();
                Stopwatch counter = Stopwatch.StartNew();
                sb.Append(sr.ReadToEnd());
                counter.Stop();
                // Console.WriteLine(sb.ToString());
                Console.WriteLine(counter.ElapsedMilliseconds);
            }

            Console.ReadLine();
        }
    }
}
