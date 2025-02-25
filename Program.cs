Console.Clear();
int player = 1;
int NumberofSticks = 20;
int MaxSticks = 3;

while (NumberofSticks > 0)
{
    Console.Clear();
    if (NumberofSticks <= 3)
    {
        MaxSticks = NumberofSticks;
    }
    Console.WriteLine("Sticks Remaining: " + NumberofSticks);
    Console.Write("Player " + player + ", pick a number of sticks between 1 and " + MaxSticks + ". ");
    int number = Convert.ToInt32(Console.ReadLine());
    while (true)
        if (number > MaxSticks || number < 1)
        {
            Console.Write("Invalid Number, Try Again. ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            break;
        }
    NumberofSticks = (NumberofSticks - number);
    if (player == 1)
    {
        player = 2;
    }
    else
    {
        player = 1;
    }
}