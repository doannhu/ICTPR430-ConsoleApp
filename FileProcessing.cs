using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ICTPR430_ConsoleApp
{
    class FileProcessing
    {
        public void WriteAndReadFile(string[] myArray1, string[] myArray2)
        {
            File.WriteAllText("C:\\temp\\csc.txt", String.Empty);
            File.AppendAllLines("C:\\temp\\csc.txt", myArray1);
            File.AppendAllLines("C:\\temp\\csc.txt", myArray2);
            string contents = File.ReadAllText("C:\\temp\\csc.txt");
            Console.WriteLine(contents);
        }
    }
}
