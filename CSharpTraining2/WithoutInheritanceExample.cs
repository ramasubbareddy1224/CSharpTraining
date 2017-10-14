using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining2
{
    public class EBook
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public DateTime PublishedOn { get; set; }
        public String DownloadLink { get; set; }

        public double Size { get; set; }

        public EBook()
        {
            Name = "Wings Of Fire";
            ISBN = "123-5454-544";
            Description = "APJ Biography";
            Author = "APJ";
            Price = 350;
            PublishedOn = DateTime.Today;
            DownloadLink = "http://amazon.com/book/123-34343";
            Size = 24.5;
        }

        //public void AssinBookDetails()
        //{

        //    Name = "Wings Of Fire";
        //    ISBN = "123-5454-544";
        //    Description = "APJ Biography";
        //    Author = "APJ";
        //    Price = 350;
        //    PublishedOn = Convert.ToDateTime("10/14/2017");
        //    DownloadLink = "http://amazon.com/book/123-34343";

        //}

        public void BuyBook()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Description:" + Description);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Link:" + DownloadLink);
        }


    }

    public class PaperBook
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public DateTime PublishedOn { get; set; }

        public int NoOfPages { get; set; }

        public PaperBook()
        {
            Name = "Wings Of Fire";
            ISBN = "123-5454-544";
            Description = "APJ Biography";
            Author = "APJ";
            Price = 350;
            PublishedOn = DateTime.Today;
        }

        public void BuyBook()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Description:" + Description);
            Console.WriteLine("Price:" + Price);
        }


    }
}
