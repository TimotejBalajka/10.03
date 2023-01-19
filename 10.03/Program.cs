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
        Book LOTR = new Book("Kni�ka pre (ne)poslu�n� deti", 64, "Miro Jaro�", "Kids", 1);
        LOTR.print();

        Book LOTR1 = new Book();
        Book LOTR2 = new Book("Gr�zlik Gabo", 96);
        Book Hobit = new Book("Hobbit ", 232, "J.R.R Tolkien", "Sci-fi", 1937);
        LOTR1.print();
        LOTR2.print();
        Hobit.print();


        Library schoolLibrary = new Library();
        schoolLibrary.numberOfBooks = 4;
        schoolLibrary.NumberofStudents = 2;

        schoolLibrary.studentsList.Add("Poul");
        schoolLibrary.studentsList.Add("John");

        schoolLibrary.booksList.Add(LOTR);
        schoolLibrary.booksList.Add(LOTR1);

        schoolLibrary.booksList.Add(LOTR2);
        schoolLibrary.booksList.Add(Hobit);

        Console.WriteLine(schoolLibrary.ToString());



    }
}