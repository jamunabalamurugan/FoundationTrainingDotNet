using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prjFilesExceptions
{
    class ReadWriteXML
    {
        public void GetMovies()
        {
            string fname = @"E:\AT\NewMovieRatings.xml";
            string bname = @"E:\AT\Day11\Bookstore.xml";
            XElement books = XElement.Load(bname);
            foreach (var item in books.Descendants("title"))
            {
                Console.WriteLine(item);
            }

            XElement Movies = XElement.Load(fname);

            var selectedmovies = from movie in Movies.Descendants("Movie")
                         where Int32.Parse(movie.Element("Rating").Value) >= 4
                         select movie;


            foreach (var item in selectedmovies)
            {
                Console.WriteLine(item);
            }
        }

        public void CreateMovies()
        {
            XElement Movies = new XElement("Movies",
                new XElement("Movie",
                    new XElement("Name", "Sivaji"),
                    new XElement("Director", "Shankar"),
                    new XElement("Producer", "XXX"),
                    new XElement("Cast", "Rajinikanth"),
                    new XElement("Rating", 5)
                    ),

                new XElement("Movie",
                    new XElement("Name", "Pettai"),
                    new XElement("Director", "AAA"),
                    new XElement("Producer", "BBB"),
                    new XElement("Cast", "Rajinikanth"),
                    new XElement("Rating", 4)
                    )
                );
            Movies.Save(@"E:\AT\NewMovieRatings.xml");
        }
        public static void Main()
        {
            ReadWriteXML obj = new ReadWriteXML();
           // obj.CreateMovies();
            obj.GetMovies();

            Console.ReadKey();
        }
    }
}
