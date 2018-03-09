using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileProcessingHelper;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an input file path");
            var inputFilePath = Console.ReadLine();
            Console.WriteLine("Please provide an output file path");
            var outputFilePath = Console.ReadLine();
            PreProcessFile.Start(inputFilePath, outputFilePath);
        }
    }
}
