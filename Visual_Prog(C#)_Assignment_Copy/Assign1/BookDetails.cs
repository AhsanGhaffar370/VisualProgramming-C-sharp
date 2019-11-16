using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class BookDetails
    {
        public BookDetails()
        {

        }
        private string title; 
        private string author;
        private string isbn; 
        private string url; 
        private int page;
        private int year;
        private string pic;

        public string Title
        {
            get
            {return title;}

            set
            {title = value; }
        }

        public string Author
        {
            get
            { return author;}

            set
            {  author = value;}
        }

        public string Isbn
        {
            get
            {return isbn;}

            set
            { isbn = value; }
        }

        public string Url
        {
            get
            { return url;}

            set
            { url = value;}
        }

        public int Page
        {
            get
            {return page;}

            set
            {page = value;}
        }

        public int Year
        {
            get
            {return year;}

            set
            { year = value;}
        }

        public string Pic
        {
            get
            {
                return pic;
            }

            set
            {
                pic = value;
            }
        }
    }
}
