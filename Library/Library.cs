using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        private readonly List<LibraryItemAbstract> _items = new List<LibraryItemAbstract>();
        private readonly List<User> _users = new List<User>();

        public void AddItem(LibraryItemAbstract item)
        {
            if (item != null)
            {
                _items.Add(item);
                Console.WriteLine($"Item\"{item.Title}\" has added succesful.");
            }

            else
            {
                Console.WriteLine($"Item\"{item.Title}\" already added.");
            }
        }

        public void RegisterUser(User user)
        {
            if (user != null && !_users.Any(u => u.LibraryCardNumber == user.LibraryCardNumber))
            {
                _users.Add(user);
                Console.WriteLine($"User {user.Name} (Card: {user.LibraryCardNumber}) registered.");
            }
            else
            {
                Console.WriteLine("Error: User has already added or incorredt information.");
            }
        }

        public List<LibraryItemAbstract> FindItemsByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return new List<LibraryItemAbstract>();
            }

            return _items
                .Where(item => item.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void ShowAvailableItems()
        {
            var availableItems = _items.Where(item => item.IsAvailable).ToList();

            if (!availableItems.Any())
            {
                Console.WriteLine("There are no free Items now.");
                return;
            }

            Console.WriteLine("The free items");
            foreach (var item in availableItems)
            {
                item.DisplayInfo(); 
                Console.WriteLine(new string('-', 30));
            }
        }

    }
}
