using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class BookBaseInheritance
    {
        public BookBaseInheritance()
        {
            Console.WriteLine("BookBaseInheritance");
        }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public DateTime PublishedOn { get; set; }

        protected void PrintBookDetails()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Description:" + Description);
            Console.WriteLine("Price:" + Price);
        }
    }

    public class EBookDerived : BookBaseInheritance
    {
        public EBookDerived()
        {
            Console.WriteLine("EBookDerived");
        }
        public String DownloadLink { get; set; }

        public double Size { get; set; }

        public void DownloadBook()
        {
            Name = "Wings Of Fire";
            ISBN = "123-5454-544";
            Description = "APJ Biography";
            Author = "APJ";
            Price = 350;
            PublishedOn = DateTime.Today;
            Size = 23.5;
            DownloadLink = "http://amazon.com/book/123";

            PrintBookDetails();
            Console.WriteLine("Download URL:" + DownloadLink);

        }
    }

    public class PaperBookDerived : BookBaseInheritance
    {
        public PaperBookDerived()
        {
            Console.WriteLine("PaperBookDerived");
        }
        public int NoOfPages { get; set; }


        public void CourerBook()
        {
            Name = "Wings Of Fire";
            ISBN = "123-5454-544";
            Description = "APJ Biography";
            Author = "APJ";
            Price = 350;
            PublishedOn = DateTime.Today;
            NoOfPages = 100;

            PrintBookDetails();
            Console.WriteLine("No.Of Pages:" + NoOfPages);
        }
    }
}



