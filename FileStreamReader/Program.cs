using System;
using System.IO;

namespace FileStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    //using (StreamReader sr = new StreamReader(fs)) {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            ////FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    //fs = new FileStream(path, FileMode.Open);
            //    //sr = new StreamReader(fs);
            //    sr = File.OpenText(path);

            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    //if (fs != null) fs.Close();
            //}
        }
    }
}
