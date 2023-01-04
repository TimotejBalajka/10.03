using _10._03;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Book LOTR = new Book();
        LOTR.title = "Knižka pre (ne)poslušné deti";
        LOTR.pages = 64;
        LOTR.author = "Miro Jaroš";
        LOTR.category = "Kids";
        LOTR.releaseDate = 2020;
        LOTR.print();


    }
}