using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class LibraryItemAbstract : ILoanable
    {
        private static int _nextId = 1;
        private int _id;
        private string _title = string.Empty;
        private string _authorOrCreator = string.Empty;
        private int _yearPublished;
        private bool _isAvailable = true;

        protected LibraryItemAbstract()
        {
            _id = _nextId++;
        }

        public virtual int Id
        {   get => _id;  set => _id = value;  }

        public virtual string Title
        {   get => _title; set => _title = value;  }

        public virtual string AuthorOrCreator
        {    get => _authorOrCreator;   set => _authorOrCreator = value; }

        public virtual int YearPublished
        { get => _yearPublished; set => _yearPublished = value; }

        public virtual bool IsAvailable
        {   get => _isAvailable;  set => _isAvailable = value;  }

        public abstract void DisplayInfo();

        public virtual int GetLoanPeriodDays()
        {
           return 14;
        }

        public virtual void Borrow(User user)
        {
            if (!IsAvailable)
            {
                Console.WriteLine($"Item \"{Title}\" is already borrowed.");
                return;
            }

            IsAvailable = false; 
            user.BorrowedItems.Add(this);
            Console.WriteLine($"Item \"{Title}\" successfully borrowed by {user.Name}.");
        }

        public virtual void ReturnItem()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"Item \"{Title}\" is already in the library.");
                return;
            }

            IsAvailable = true; 
            Console.WriteLine($"Item \"{Title}\" has been returned to the library.");
        }



    }
}
