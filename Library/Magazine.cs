using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Magazine : LibraryItemAbstract
    {
        public int IssueNumber { get; set; }
        public string Category { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} , Title: {Title} , Author: {AuthorOrCreator} , Year: {YearPublished} , Availability: {IsAvailable} , " +
                $"IssueNumber: {IssueNumber} , Category: {Category}");
        }

        public override int GetLoanPeriodDays()
        {
            return 7;
        }

    }
}
