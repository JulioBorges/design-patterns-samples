
using Strategy.FileReader.Contract;
using Strategy.FileReader.Converters;
using Strategy.FileReader;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Files. . .");
            Console.WriteLine();

            ProcessFile(new CSVClientConverter(), FileCSV(), "CSV File");
            ProcessFile(new CustomClientConverter(), CustomFile(), "Custom Layout File");

            Console.Read();
        }

        static void ProcessFile(AClientDataConverter converter, List<string> fileContents, string fileDescription)
        {
            ReadFileToEntities reader;

            Console.WriteLine($"Processing {fileDescription} . . .");
            // Process File
            reader = new ReadFileToEntities(converter);
            var clients = reader.ReadFile(fileContents);

            Console.WriteLine($"Clients from {fileDescription}: ");
            foreach (var client in clients)
                Console.WriteLine(client);

            Console.WriteLine();
        }

        static List<string> FileCSV()
        {
            return new List<string>
            {
                "1;Client 1;25",
                "2;Client 2;50",
                "3;Client 3;30"
            };
        }

        static List<string> CustomFile()
        {
            return new List<string>
            {
                "00004Client 4  15",
                "00005Client 5  60",
                "00006Client 6  9",
                "00007Client 7  10"
            };
        }
    }
}
