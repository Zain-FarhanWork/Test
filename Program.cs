
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

int repeat = 1;
int choice;
int bookIndex;
Book[] Library = new Book[999];

for (int i = 0; i < Library.Length; i++)
{
    Library[i] = new Book();
}
do
{
    

    do
    {
        Console.WriteLine("Press 1 to view Book | Press 2 to Set Book");
        choice = Convert.ToInt32(Console.ReadLine());

    } 
    while (choice > 2 || choice < 1);

    if (choice == 1)
    {
        Console.Write("Enter Book Index: ");
        bookIndex = Convert.ToInt32(Console.ReadLine());
        bookIndex--;

        See(bookIndex);
    }
    else
    {
        Console.Write("Enter Book Index: ");
        bookIndex = Convert.ToInt32(Console.ReadLine());
        bookIndex--;

        Change(bookIndex);

    }

    do
    {
        Console.WriteLine("Press 1 to Continue - Press 2 to Exit");
        repeat = Convert.ToInt32(Console.ReadLine());
    }
    while (repeat < 1 || repeat > 2);  

    

} while (repeat == 1);




void See(int index)
{
    Console.WriteLine("Author: " + Library[index].author);
    Console.WriteLine("Publisher: " + Library[index].publisher);
    Console.WriteLine("Pages: " + Library[index].pages);
    Console.WriteLine("IMBC Number: " + Library[index].imbc);

}

Book Change(int index)
{
    string? tempString;
    int tempInt = 0;

    Console.Write("Author: ");
    tempString = Console.ReadLine();

    if (tempString != "")
    {
        Library[index].author = tempString;
    }

    Console.Write("Publisher: ");
    tempString = Console.ReadLine();

    if (tempString != "")
    {
        Library[index].publisher = tempString;
    }

    Console.Write("Pages: ");
    tempString = Console.ReadLine();

    try 
    {
        tempInt = Convert.ToInt32(tempString);
    }
    catch
    {

    }

    if (tempString != "")
    {
        Library[index].pages = tempInt;
    }

    Console.Write("IMBC Number: ");
    tempString = Console.ReadLine();

    try 
    {
        tempInt = Convert.ToInt32(tempString);
    }
    catch
    {

    }

    if (tempString != "")
    {
        Library[index].imbc = tempInt;
    }

    return Library[index];


}

class Book
{
    public string? author = "<EMPTY>";
    public string? publisher = "<EMPTY>";
    public int pages;
    public int imbc;

}