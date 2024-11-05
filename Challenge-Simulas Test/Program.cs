// See https://aka.ms/new-console-template for more information

BoxState box = BoxState.locked;
string userAction = "";

while (true)
{
    if (box == BoxState.locked)
        while (userAction.ToLower() != "unlock")
        {
            Console.Write($"The chest is {box}. What do you want to do? ");
            userAction = Console.ReadLine();
        }

    if (box == BoxState.unlocked)
        while (userAction.ToLower() != "lock" && userAction.ToLower() != "open")
        {
            Console.Write($"The chest is {box}. What do you want to do? ");
            userAction = Console.ReadLine();
        }

    if (box == BoxState.open)
        while (userAction.ToLower() != "close")
        {
            Console.Write($"The chest is {box}. What do you want to do? ");
            userAction = Console.ReadLine();
        }

    if (userAction.ToLower() == "unlock")
        box = BoxState.unlocked;

    if (userAction.ToLower() == "lock")
        box = BoxState.locked;

    if (userAction.ToLower() == "open")
        box = BoxState.open;

    if (userAction.ToLower() == "close")
        box = BoxState.unlocked;
}

enum Action
{
    Unlock,
    Open,
    Close
}

enum BoxState
{
    open,
    locked,
    unlocked
}