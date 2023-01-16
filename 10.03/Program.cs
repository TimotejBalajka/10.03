using _10._03;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        LOTR.releaseDate = 1;
        LOTR.print();

        Book LOTR1 = new Book();
        Book LOTR2 = new Book("Grázlik Gabo", 96);
        Book Hobit = new Book("Hobbit ", 232, "J.R.R Tolkien", "Sci-fi", 1937);
        LOTR1.print();
        LOTR2.print();
        Hobit.print();


    }
}