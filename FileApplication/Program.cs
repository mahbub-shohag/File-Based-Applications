using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string nextWork = "sss";
            string fileLocation = @"D:\hohag\Files\myfile.txt";
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Append);
            StreamWriter aWriter=new StreamWriter(aFileStream);
            while (nextWork=="sss")
            {
                Console.WriteLine("Name :");
                aWriter.WriteLine(Console.ReadLine());
                Console.WriteLine("Roll :");
                aWriter.Write(Console.ReadLine());
                Console.WriteLine("Exit : 0    Continue :1");
                nextWork = Console.ReadLine();
                
            }
            aWriter.Close();


        }
    }
}
