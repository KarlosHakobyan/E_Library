using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book : LibraryItemAbstract
    {
        public int PageCount { get; set; }
        public string Genre {  get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} , Title: {Title} , Author: {AuthorOrCreator} , Year: {YearPublished} , Availability: {IsAvailable} , " +
                $"PageGount: {PageCount} , Genre: {Genre}");
        }

        public int GetDaysForReturn()
        {
            return GetLoanPeriodDays();
        }
    }
}
