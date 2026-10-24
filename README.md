# E_Library
# 📚 Electronic Library System (C# OOP Practice)

A console-based **Electronic Library Management System** developed in C# as a practical project to master Object-Oriented Programming (OOP) principles.

## 🚀 Features

* **Object-Oriented Architecture**: Utilizes inheritance, polymorphism, abstract classes, and interfaces.
* **Item Management**: Support for different types of library assets:
  * 📖 **Books** (with page count and genre)
  * 📰 **Magazines** (with issue numbers and categories)
  * 💻 **Digital Media** (with file formats and duration)
* **Polymorphism in Action**: Dynamic dispatch for displaying specific item info and calculating loan periods (`14 days` for books, `7 days` for magazines, `3 days` for digital media).
* **User Registration & Management**: Register users with unique library card numbers and track their borrowed items.
* **Borrowing & Returning Workflow**: Implements the `ILoanable` interface to handle item checkout, availability status updates, and returns.
* **Search Functionality**: Quickly search inventory items by title using LINQ.
* **Automatic ID Generation**: Unique incremental IDs assigned to every library item upon creation.

---

## 🛠️ Technologies Used

* **Language**: C# (.NET 8.0)
* **Paradigm**: Object-Oriented Programming (OOP)
* **Collections & LINQ**: `List<T>`, `Where`, `Any`

---

## 📂 Project Structure

```text
Library/
│
├── Program.cs             # Entry point & console UI demonstration
├── Library.cs             # Main manager class for items and users
├── User.cs                # User model tracking borrowed assets
├── ILoanable.cs           # Interface for borrowable items
├── LibraryItemAbstract.cs # Abstract base class with shared properties & logic
├── Book.cs                # Book subclass
├── Magazine.cs            # Magazine subclass
└── DigitalMedia.cs        # Digital media subclass
