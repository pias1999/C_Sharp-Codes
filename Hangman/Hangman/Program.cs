using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("\t\t\t\t\t***Hangman Game***\n");
        string[] listwords = new string[10];
        listwords[0] = "bangladesh";
        listwords[1] = "pakistan";
        listwords[2] = "india";
        listwords[3] = "america";
        listwords[4] = "london";
        listwords[5] = "germany";
        listwords[6] = "japan";
        listwords[7] = "australia";
        listwords[8] = "canada";
        listwords[9] = "china";
        Random randGen = new Random();
        var idx = randGen.Next(0, 9);
        string word = listwords[idx];
        char[] guess = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
            guess[i] = '*';

        for (; ; )
        {
            Console.Write("Please enter your guess: ");
            char playerGuess = char.Parse(Console.ReadLine());
            for (int j = 0; j < word.Length; j++)
            {
                if (playerGuess == word[j])
                    guess[j] = playerGuess;
            }
            Console.WriteLine(guess);
        }
    }
}