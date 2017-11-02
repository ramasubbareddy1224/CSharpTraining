using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    public class Book
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
        public decimal Price { get; set; }
    }

    public class EBook : Book
    {
        public string DownloadURL { get; set; }
        public decimal Size { get; set; }

        public EBook()
        {
            ID = 100;
            Type = "Inspiration";
            Title = "Wings of Fire";
            Author = "APJ Abdul";
            DownloadURL = "http://amazon.com/books/123x";
            Size = 10;
        }

        public void PrintEBookDetails()
        {
            Console.WriteLine("Book Name:" + Title);
            Console.WriteLine("Book Author:" + Author);
            Console.WriteLine("Download URL:" + DownloadURL);
            Console.WriteLine("Size in MB:" + Size);
        }
    }
    public class PaperBook : Book
    {
        public decimal ShippingWeight { get; set; }
        public bool InStock { get; set; }

        public PaperBook()
        {
            ID = 100;
            Type = "Inspiration";
            Title = "Wings of Fire";
            Author = "APJ Abdul";
            ShippingWeight = 200;
            InStock = true;
        }

        public void PrintPaperBookDetails()
        {
            Console.WriteLine("Book Name:" + Title);
            Console.WriteLine("Book Author:" + Author);
            Console.WriteLine("Shipping Weight:" + ShippingWeight);
            Console.WriteLine("Is in Stock:" + InStock);
        }
    }
}
