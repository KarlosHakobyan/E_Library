using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class DigitalMedia : LibraryItemAbstract
    {
        public string FileFormat { get; set; }
        public int DurationMinutes { get; set; }


        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} , Title: {Title} , Author: {AuthorOrCreator} , Year: {YearPublished} , Availability: {IsAvailable} , " +
                $"FileFormat: {FileFormat} , DurationMinutes: {DurationMinutes}");
        }

        public override int GetLoanPeriodDays()
        {
            return 3;
        }
    }
}
