using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile, outputFile, typeFile;

            if (args.Length != 3)
            {
                inputFile = "data.csv";
                outputFile = "result.xml";
                typeFile = "xml";
            }
            else
            {
                inputFile = args[0];
                outputFile = args[1];
                typeFile = args[2];
            }

            List<Student> studentList = ReadFile.ReadStudentsFromFile(inputFile);

            if (typeFile.Equals("xml"))
            {
                WriteToFile.writeToXML(studentList, outputFile);
            }


            Console.WriteLine("Obrobka danych udala sie!");

        }
    }
}
