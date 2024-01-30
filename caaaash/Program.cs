using caaaash;

Guy Joe = new Guy() { Cash = 50, Name = "Joe"};
Guy Bob = new Guy() { Cash = 100, Name = "Bob"};

while (true)
{
    Joe.WriteMyInfo();
    Bob.WriteMyInfo();

    Console.Write("Enter an amount: ");
    string howMuch = Console.ReadLine();
    if (howMuch == "")
        return;
    if (int.TryParse(howMuch, out int sum))
    {
        Console.Write("Who should give the cash: ");
        string whichGuy = Console.ReadLine();
        if (whichGuy == "Joe")
        {
            Joe.GiveCash(sum);
            Bob.ReceiveCash(sum);
        }
        else if (whichGuy == "Bob")
        {
            Bob.GiveCash(sum);
            Joe.ReceiveCash(sum);
        }
        else
        {
            Console.WriteLine("Please enter 'Joe' or 'Bob'");
        }
    }
    else
        Console.WriteLine("Please enter an amount (or a blank line to exit).");
}