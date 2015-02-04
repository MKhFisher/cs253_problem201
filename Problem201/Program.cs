using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem201
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtractWords(new FileInfo(args[0]));
        }

        public static List<string> ExtractWords(FileInfo file)
        {
            if (file.GetType() == typeof(FileInfo))
            {
                try
                {
                    return Regex.Split(new StreamReader(file.FullName).ReadToEnd().Replace("_", ""), "\\W+").ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} error occured when opening: {1}", e.GetType(), file.FullName);
                    return new List<string>();
                }
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
