using System;

namespace RotateCharacters
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter some text: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Your text is now rotated to: ");
            Console.WriteLine(RotateThirteen(inputString));
            Console.Read();
        }

        public static string RotateThirteen(string input)
        {
            bool upperCase = false;
            char[] chatArray = input.ToCharArray();

            for (int i = 0; i < chatArray.Length; i++)
            {
                char letter = chatArray[i];

                if (letter == ' ')
                    letter = ' ';
                else
                {
                    // Checking if the letter is upper case
                    if (char.IsUpper(letter))
                    {
                        upperCase = true;
                        letter = char.ToLower(letter);
                    }
                    else
                        upperCase = false;

                    // Rotating the letter by 13 characters
                    letter = (char)(letter + 13);

                    // Checking is letter is at the end of the alphabet, to start again
                    if (letter > 'z')
                        letter = (char)(letter - 26);
                    else if (letter < 'a')
                        letter = (char)(letter + 26);
                }

                // Adds letter to final array
                if (upperCase == true)
                    chatArray[i] = char.ToUpper(letter);
                else
                    chatArray[i] = letter;
            }

            return new string(chatArray);
        }
    }
}
