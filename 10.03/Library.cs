using System;
using System.Collections.Generic;
using System.Text;

namespace _10._03
{
    internal class Library
    {
        public List<Book> booksList = new List<Book>();
        public int numberOfBooks;
        public int numberOfStudents;
        public List<String> studentsList = new List<String>();

        public int Numberofbooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        }
        public int NumberofStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }
        public List<String> Studentlist
        {
            get { return studentsList; }
        }
        public List<Book> Booklist
        {
            get { return booksList; }
        }
        public override string ToString()
        {
            string students = string.Empty;
            string books = string.Empty;
            foreach (var v in booksList)
            {
                books += v;
            }
            foreach (var v in studentsList)
            {
                students += v;
            }
            return String.Format($"{numberOfBooks} , {numberOfStudents}, {books}, {students}  ");
        }

    }
}