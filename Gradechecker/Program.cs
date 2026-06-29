Console.WriteLine("DO YOU WANT TO PERFORM A GRADECHECKER: ");
string choice;
do
{
    //user input
    Console.Write("Enter Name: ");
    Console.ReadLine();
    Console.Write("Enter Course: ");
    Console.ReadLine();
    Console.Write("Enter score:");
    int score = 0;
    try
    {
        score = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("INVALID OPTION!");
        return;
    }
    if (score >= 80 && score <= 100)
    {
        Console.WriteLine("A");
    }
    else if (score >= 60 && score <= 79)
    {
        Console.WriteLine("B");
    }
    else if (score >= 50 && score <= 59)
    {
        Console.WriteLine("C");
    }
    else if (score >= 40 && score <= 49)
    {
        Console.WriteLine("D");
    }
    else
    {
        Console.WriteLine("F");
    }
    Console.WriteLine("DO YOU WANT TO PERFORM ANOTHER GRADE CHECK?: (YES/NO)");
     choice = Console.ReadLine();
}
while
(
choice.ToUpper() == "YES"
 );
Console.WriteLine("THAMK YOU");