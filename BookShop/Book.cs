using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;
        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Aurhor = author;
            this.Price = price;
        }
        public string Title
        {
            get
            {
                return this.title;
            }
           protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("title", "Title cannot be null");
                }
                this.title = value;
            }
        }
        public string Aurhor
        {
            get
            {
                return this.author;
            }
          protected  set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("author", "Author cannot be null");
                }
                this.author = value;
            }
        }
        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
         protected   set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negativ.");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            sb.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            sb.AppendFormat("-Author: {0}{1}", this.Aurhor, Environment.NewLine);
            sb.AppendFormat("-Price: {0:F2}", this.Price);
            return sb.ToString();
        }
    }
}
