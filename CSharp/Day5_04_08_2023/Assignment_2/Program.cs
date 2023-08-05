using LibraryManagement;
Book[] arr = { new (1, "It end with us", "collen", true), new(2, "It Start with us", "Collen", true), new(3, "Deep", "collen", true), new(4, "Beauty of ocean", "collen", true) };
Library library = new Library(arr);
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose \n1.Borrow Book\n2.Return Book\n3.Display Book\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Book title: ");
        string title = Console.ReadLine();
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Book need to return: ");
        string title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }
}