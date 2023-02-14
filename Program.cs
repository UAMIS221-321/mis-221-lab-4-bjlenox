//start main
int userChoice = AskUserChoice();
while (userChoice != 3)
{
    RouteMethod(userChoice);
    userChoice = AskUserChoice();
}

//end main

static void DisplayMenu()
{
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static int AskUserChoice()
{
    DisplayMenu();
    string userChoice = System.Console.ReadLine();
    if (IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else
    {
        BadChoice();
        return 0;
    }
    

}

static bool IsValidChoice(string userInput)
{
    if (userInput=="1" || userInput=="2" ||userInput=="3")
    {
        return true;
    }
    return false;
}

static void BadChoice()
{
    System.Console.WriteLine("Invalid input.");
}

static void RouteMethod(int userChoice)
{
    if (userChoice == 1)
    {
        FullTriangle();
    
    }
    else if (userChoice == 2)
    {
        PartialTriangle();
    }
    return;
}

static void FullTriangle()
{
    Random rnd = new Random();
    int number = rnd.Next (3,10);
    for(int count = 0;count <= number; count++)
    {
        PrintWholeLine(count);
            
    }
    return;

}

static void PartialTriangle()
{
    Random rnd = new Random();
    int number = rnd.Next (3,10);
    for(int count = 0;count <= number; count++)
    {
        PrintPartLine(count);
            
    }
    return;
}

static void PrintWholeLine(int number)
{
    for(int count = 0;count <= number; count++)
    {
        System.Console.Write(0);
    }
    System.Console.WriteLine("");

    return;
}

static void PrintPartLine(int number)
{
    for(int count = 0;count <= number; count++)
    {
        Random rnd = new Random();
        int numberPartial = rnd.Next (2);
        if (numberPartial == 1)
        {
          System.Console.Write(0);  
        }
        else if (numberPartial == 0)
        {
            System.Console.Write(" ");
        }
        
        
    }
    System.Console.WriteLine("");
}