using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class Book : BaseEntity
    {
        private Category Category { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool IsExcluded { get; set; }

        public Book(int id, Category category, string title, string description, int year)
        {
            Id = id;
            Category = category;
            Title = title;
            Description = description;
            Year = year;
            IsExcluded = false;
        }

        public override string ToString()
        {
            string bookReturn = "";
            bookReturn += "Category: " + Category + Environment.NewLine;
            bookReturn += "Title: " + Title + Environment.NewLine;
            bookReturn += "Description: " + Description + Environment.NewLine;
            bookReturn += "Year: " + Year + Environment.NewLine;
            return base.ToString();
        }

        public string returnTitle()
        {
            return Title;
        }

        public int returnId()
        {
            return Id;
        }

        public void Exclude()
        {
            IsExcluded = true;
        }
    }
}
