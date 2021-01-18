using System;

namespace Books
{
    //URUNLERI DINAMIK OLARAK LİSTELEME;                                                   

    class Program
    {
        static void Main(string[] args)
        {


            //2.olarak; Product class'ımı cagırdım ve urun olarak kitaplar oluşturdum.
            Product product1 = new Product();
            product1.Name = "Simyacı";
            product1.Author = "Paulo Coelho";
            product1.Language = "Turkish";
            product1.ReleaseDate = "17.06.2019";
            product1.NumberOfPages = "184";
            product1.Price = 14;

            Product product2 = new Product();
            product2.Name = "1984";
            product2.Author = "George Orwell";
            product2.Language = "Turkish";
            product2.ReleaseDate = "25.04.2019";
            product2.NumberOfPages = "352";
            product2.Price = 13;

            Product product3 = new Product();
            product3.Name = "Momo";
            product3.Author = "Michael Ende";
            product3.Language = "Turkish";
            product3.ReleaseDate = "07.09.2017";
            product3.NumberOfPages = "304";
            product3.Price = 16;

            Product product4 = new Product();
            product4.Name = "Şeker Portakalı";
            product4.Author = "Jose Mauro De Vasconcelos";
            product4.Language = "Turkish";
            product4.ReleaseDate = "06.09.2019";
            product4.NumberOfPages = "182";
            product4.Price = 16;

            Product product5 = new Product();
            product5.Name = "Fahrenheit 451";
            product5.Author = "Ray Bradbury";
            product5.Language = "Turkish";
            product5.ReleaseDate = "08.06.2020";
            product5.NumberOfPages = "208";
            product5.Price = 15;

            Product product6 = new Product();
            product6.Name = "Arayış Mehmet'in Hikayesi";
            product6.Author = "Mehmet Yıldız";
            product6.Language = "Turkish";
            product6.ReleaseDate = "07.01.2021";
            product6.NumberOfPages = "192";
            product6.Price = 15;

            Product product7 = new Product();
            product7.Name = "Hayvan Çiftliği";
            product7.Author = "George Orwell";
            product7.Language = "Turkish";
            product7.ReleaseDate = "04.10.2019";
            product7.NumberOfPages = "152";
            product7.Price = 7;


            //3.olarak; urunleri bir listeye aktardım.
            Product[] products = new Product[]
            {
            product1,product2,product3,product4,product5,product6,product7

            };
            //son olarak foreach ile urunlerin/kitaplarin ozelliklerini döndürerek sayfaya yazdırdım.
            foreach (Product product in products)
            {
                Console.WriteLine("-------------BOOK-------------");
                Console.WriteLine("Book Name : " + product.Name);
                Console.WriteLine("Author : " + product.Author);
                Console.WriteLine("Language : " + product.Language);
                Console.WriteLine("Release Date : " + product.ReleaseDate);
                Console.WriteLine("Number of Pages : " + product.NumberOfPages);
                Console.WriteLine("Price : " + product.Price + " tl");
            }


        }
    }

    //urun class'ı olusturdum ve urunun ozelliklerini tüm ekledim.
    class Product
    {

        public string Name { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }
        public string Language { get; set; }
        public string NumberOfPages { get; set; }
        public int Price { get; set; }

    }
}
