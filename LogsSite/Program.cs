using LogsSite.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace LogsSite {
    internal class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();
            string path = "E:\\DEV-Files\\C#\\";
            string file = "Log.txt";

            try {
                using (StreamReader sr = new StreamReader($"{path}{file}")) {
                    while (!sr.EndOfStream) {
                        string[] vect = sr.ReadLine().Split(' ');
                        set.Add(new LogRecord(vect[0], DateTime.Parse(vect[1])));
                    }
                    Console.WriteLine($"Total de usuários: {set.Count}");
                }
            } catch (IOException e) {
                Console.WriteLine($"Erro: {e.Message}");
            }
            Console.WriteLine();
        }
    }
}
