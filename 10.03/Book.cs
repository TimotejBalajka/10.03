using System;
using System.Collections.Generic;
using System.Text;

namespace _10._03
{
    internal class Book
    {
        public string title;
        public int pages;
        public string author;
        public string category;
        public int releaseDate;

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


        private string GetCategory() { return category; }
        public string SetCategory(string category)
        {
            this.category = category;
            return category;
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

        public void print()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(category);
            Console.WriteLine(releaseDate);
            Console.WriteLine(pages);
        }

    }
}


