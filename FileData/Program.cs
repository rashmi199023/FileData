using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // task 1
            var arg1 = args[0];
            var arg2 = args[1];
             FileDetails f = new FileDetails();
            var version= f.Version(arg2);
            Console.WriteLine("text file version is - " +version);
            Console.ReadLine();

            //==============

            // TASK2

            if (arg1 == "-v" || arg1 == "--v" || arg1 == "/v" || arg1=="--version")
            {
                var version2 = f.Version(arg2);
                Console.WriteLine("text file version2 is - " + version2);
                Console.ReadLine();
            }
            if (arg1 == "-s" || arg1 == "--s" || arg1 == "/s" || arg1 == "--size")
            {
                var size = f.Size(arg2);
                Console.WriteLine("text file size  is - " + size);
                Console.ReadLine();
            }
        }
    }
}
