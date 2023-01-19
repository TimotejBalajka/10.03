using System;
using System.Collections.Generic;
using System.Text;

namespace _10._03
{
    internal class Book
    {
        private string title;
        private int pages;
        private string author;
        private string category;
        private int releaseDate;

        private string GetTitle() { return title; }
        public string SetTitle(string title)
        {
            this.title = title;
            return title;
        }


        private int GetPages() { return pages; }
        public int SetPages(int pages)
        {
            if (pages < 0) { return 1; }
            this.pages = pages;
            return pages;
        }


        private string GetAuthor() { return author; }
        public string SetAuthor(string author)
        {
            this.author = author;
            return author;
        }


        public string Category
        {

            set { this.category = value; }

        }


        private int GetReleaseDate() { return releaseDate; }
        public int SetReleaseDate(int releaseDate)
        {
            if ((releaseDate <= 2021) || (releaseDate >= 1450))
            {
                releaseDate = releaseDate;
            }
            else
            {
                releaseDate = -1;
            }
            this.releaseDate = releaseDate;
            return releaseDate;
        }

        public Book()
        {
            category = "-1";
            author = "-1";
            title = "-1";
            releaseDate = -1;
            pages = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            author = "-1";
            category = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string author, string category, int releaseDate)
        {
            this.author = author;
            this.category = category;
            this.releaseDate = releaseDate;
            this.pages = pages;
            this.title = title;
        }

        public void print()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(category);
            Console.WriteLine(releaseDate);
            Console.WriteLine(pages);
        }

        public override string ToString()
        {
            return String.Format($"{author}, {category}, {pages}, {releaseDate}; {title}");
        }
        ///

        public static readonly List<String> categoryList = new List<String>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

    }
}
