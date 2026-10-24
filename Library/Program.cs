using Library;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize our library
        Library.Library myLibrary = new Library.Library();

        // 2. Create various library items (books, magazines, digital media)
        Book book1 = new Book
        {
            Title = "C# in Depth",
            AuthorOrCreator = "Jon Skeet",
            YearPublished = 2019,
            PageCount = 900,
            Genre = "Programming"
        };

        Book book2 = new Book
        {
            Title = "Clean Code",
            AuthorOrCreator = "Robert Martin",
            YearPublished = 2008,
            PageCount = 464,
            Genre = "Software Architecture"
        };

        Magazine magazine = new Magazine
        {
            Title = "National Geographic",
            AuthorOrCreator = "Various",
            YearPublished = 2023,
            IssueNumber = 5,
            Category = "Science"
        };

        DigitalMedia media = new DigitalMedia
        {
            Title = "C# Advanced Video Course",
            AuthorOrCreator = "Code Academy",
            YearPublished = 2022,
            FileFormat = "MP4",
            DurationMinutes = 120
        };

        // 3. Add items to the library inventory
        Console.WriteLine("=== ADDING ITEMS ===");
        myLibrary.AddItem(book1);
        myLibrary.AddItem(book2);
        myLibrary.AddItem(magazine);
        myLibrary.AddItem(media);

        Console.WriteLine(new string('-', 40));

        // 4. Register a user
        Console.WriteLine("=== USER REGISTRATION ===");
        User user1 = new User
        {
            Name = "Alex",
            LibraryCardNumber = "LIB-2026-01"
        };
        myLibrary.RegisterUser(user1);

        Console.WriteLine(new string('-', 40));

        // 5. Display available items (polymorphism in action)
        Console.WriteLine("=== AVAILABLE ITEMS IN LIBRARY ===");
        myLibrary.ShowAvailableItems();

        Console.WriteLine(new string('-', 40));

        // 6. Test search by title
        Console.WriteLine("=== SEARCH BY TITLE ('Code') ===");
        var searchResults = myLibrary.FindItemsByTitle("Code");
        foreach (var item in searchResults)
        {
            item.DisplayInfo();
            Console.WriteLine($"Loan period: {item.GetLoanPeriodDays()} days.");
        }

        Console.WriteLine(new string('-', 40));

        // 7. Test borrowing and returning (via ILoanable interface)
        Console.WriteLine("=== TESTING BORROW AND RETURN ===");

        // Borrow book1 ("C# in Depth")
        if (book1.IsAvailable == true)
        {
            book1.Borrow(user1);
        }

        Console.WriteLine("\nAvailable items after borrowing 'C# in Depth':");
        myLibrary.ShowAvailableItems();

        Console.WriteLine("\nReturning the book back to the library:");
        if (book1.IsAvailable == false)
        {
            book1.ReturnItem();
        }

        Console.WriteLine("\nAvailable items after returning:");
        myLibrary.ShowAvailableItems();

        // Keep console open until a key is pressed
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}