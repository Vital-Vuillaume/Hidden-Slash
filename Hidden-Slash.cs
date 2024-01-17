using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            
            // Random nb
            Random rng = new Random();
            int nbRng = rng.Next(0, 101);

            // Input validity
            int inputResult;
            bool isValidInput = false;
            
            // Sentence
            string sentence = "Entrez un nombre entre 1 et 100 : ";
            Console.WriteLine(sentence);
            
            do
            {
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out inputResult);
                
                if (!isValidInput)
                {
                    Console.WriteLine(sentence);
                }
                else if (inputResult > nbRng)
                {
                    Console.WriteLine("Le nombre " + inputResult + " est trop grand.");
                }
                else if (inputResult < nbRng)
                {
                    Console.WriteLine("Le nombre " + inputResult + " est trop petit.");
                }
                
            } while (!isValidInput || inputResult != nbRng);

            // Result
            Console.WriteLine("Bien joue c'etait le nombre " + nbRng + ".");
        }
    }
}
