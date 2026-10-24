using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<LibraryItemAbstract> BorrowedItems { get; set; } = new List<LibraryItemAbstract>();
    }
}

