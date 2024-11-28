class Hangman
{
    static void Main()
    {
        List<string> words = new List<string> { "apple", "banana", "cherry", "pineapple" };
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Count)];
        char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
        int attempts = 6;
        int tries = 0;
        List<char> guessedLetters = new List<char>();

        while (tries < attempts && new string(guessedWord) != wordToGuess)
        {
            Console.WriteLine($"Word: {new string(guessedWord)}");
            Console.WriteLine($"Attempts left: {attempts - tries}");
            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine()[0];

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("You already guessed that letter.");
                continue;
            }

            guessedLetters.Add(guess);

            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedWord[i] = guess;
                    }
                }
            }
            else
            {
                tries++;
            }
        }

        if (new string(guessedWord) == wordToGuess)
        {
            Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess} in {tries} tries");
        }
        else
        {
            Console.WriteLine("Game over! The word was: " + wordToGuess);
        }
    }
}