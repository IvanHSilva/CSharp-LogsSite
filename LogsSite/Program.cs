using System;
using System.Collections.Generic;
using System.IO;

namespace LogsSite {
    internal class Program {
        static void Main(string[] args) {
            string path = "E:\\DEV-Files\\C#\\";
            string file = "Log.txt";

            try {
                using (StreamReader sr = new StreamReader($"{path}{file}")) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine($"Erro: {e.Message}");
            }
            Console.WriteLine();
        }
    }
}
