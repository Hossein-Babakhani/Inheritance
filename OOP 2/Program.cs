using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioBook book1 = new AudioBook("Animal Farm", "George Orwell", "John");
                book1.PrintInfo();
            PdfBook book2 = new PdfBook("Animal Farm", "George Orwell", "John Publications");
            book2.Price = 21.5;
            book2.PrintInfo();
            book2.PrintInfo(book2.Publisher, book2.Price);

            Console.ReadKey();

        }
    }
    public class Book
    {
        public string Name;
        public string Author;

        public virtual void PrintInfo()
        {
            Console.WriteLine(Name + "-" + Author);
        }
    }
    public class AudioBook:Book
    {
        public string Narrator;
        public AudioBook(string name,string author,string narrator)
        {
            Name = name;
            Author = author;
            Narrator = narrator;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(Name + "-" + Author + "(" + Narrator + ")");
        }
    }
    public class PdfBook:Book
    {
        public string Publisher;
        public double Price;
        public PdfBook(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }

        public void PrintInfo(string Publisher,double Price)
        {
            Console.WriteLine(Name + "-" + Author + "-" + Publisher + "-" + Price + "$");
        }
    }
}
