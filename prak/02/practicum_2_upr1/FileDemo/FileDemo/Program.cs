﻿using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText(@"C:\python\newfile.txt"); 
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?"); 
            writer.Close();
            StreamReader reader = File.OpenText(@"C:\python\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);

        }
    }
}
