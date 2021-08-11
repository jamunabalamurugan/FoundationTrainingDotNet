using System;
class Program
{
    string[] names_array;
    static string no_of_players;
    static bool a = true;
    int i = 0;

    public void acceptDetails(int players)
    {
        names_array = new string[players];

        for (i = 0; i < players; i++)
        {
            Console.WriteLine("Enter the name of the player:");
            names_array[i] = Console.ReadLine();
        }

    }
    public void displayDetails()
    {
        Console.WriteLine("The Names of the players are:");
        for (int j = 0; j < names_array.Length; j++)
        {
            Console.WriteLine(names_array[j]);
        }
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Please enter the number of players who want to play the game (between 1-4): ");
        do
        {

            no_of_players = Console.ReadLine();
            int value;
            if (int.TryParse(no_of_players, out value))
            {

                if (value >= 1 && value <= 4)
                {
                    p.acceptDetails(value);
                    p.displayDetails();
                    a = false;
                }
                else
                {
                    Console.WriteLine("Please enter a value between 1 - 4");
                    a = true;
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Numeric Value between 1 - 4");
                a = true;
            }
        }
        while (a);

    }
}


