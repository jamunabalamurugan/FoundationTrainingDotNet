using System;


    class VowelConsotant
    {
        static void Main(string[] args)
        {
            char Alphabet;

            Console.WriteLine("Enter the Alphabet");
	    Alphabet = Convert.ToChar(Console.ReadLine());
            switch (Alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("The Alphabet you have entered is a vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet you have entered is a consonant");
                    break;
            }
            Console.ReadLine();
        }

    }
