
using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] letters = { "a", "c", "s", "m", "k", "b", "p" };

        Random rng = new Random();

        int rngIndex = rng.Next(0, letters.Length);
        int slashIndex = rng.Next(0, 305);

        Console.WriteLine("Find the letter and write it down:\n");

        string stringWithSlashes = $"/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////\n/////////////////////////////////";

        // Convertir la chaîne en tableau de caractères pour pouvoir modifier les éléments individuellement
        char[] charArray = stringWithSlashes.ToCharArray();

        // Remplacer le slash à l'index aléatoire par une lettre aléatoire
        charArray[slashIndex] = Convert.ToChar(letters[rngIndex]);

        Console.WriteLine(new string(charArray));

        Console.WriteLine("\nWrite it down at the bottom:");
        string input = Console.ReadLine();

        while (input != letters[rngIndex])
        {
            Console.WriteLine("You're wrong");
            Console.WriteLine("Try again:");
            input = Console.ReadLine();
        }

        switch (input)
        {
            case "a":
                Console.WriteLine("   \\\n  (o>\n\\\\_//)\n \\_/_)");
                break;
            case "c":
                Console.WriteLine("\n / \\__\n(    @\\___\n /         O\n/   (_____/\n/_____/   U");
                break;
            case "s":
                Console.WriteLine(@"
                Singe
                
                            ,.-"" ""-.,
                           /   ===   \
                          /  =======  \
                       __|  (o)   (0)  |__      
                      / _|    .---.    |_ \         
                     | /.----/ O O \----.\ |       
                      \/     |     |     \/        
                      |                   |            
                      |                   |           
                      |                   |          
                      _\   -.,_____,.-   /_         
                  ,.-""  ""-.,_________,.-""  ""-.,
                 /          |       |          \  
                |           l.     .l           | 
                |            |     |            |
                l.           |     |           .l             
                 |           l.   .l           | \,     
                 l.           |   |           .l   \,    
                  |           |   |           |      \,  
                  l.          |   |          .l        |
                   |          |   |          |         |
                   |          |---|          |         |
                   |          |   |          |         |
                   /""-.,__,.-""\   /""-.,__,.-""\""-,_,.-""\
                  |            \ /            |         |
                  |             |             |         |
                   \__|__|__|__/ \__|__|__|__/ \_|__|__/
                ");
                break;
            case "m":
                Console.WriteLine("   /\\_/\\ \n   (o o) \n   (  \"  ) \n   \\~*~/ \n   /   \\");
                break;
            case "k":
                Console.WriteLine("     \\ \n     (\\_ \n     (-\\ \n     / \\) \n   __\\_\\__ \n  (       ) \n   \\  |  / \n    \\ | / \n     \\|/");
                break;
            case "b":
                Console.WriteLine("   (\n  `-'-.\n  '( @ >\n   _) (\n  /    )\n /_,'  /\n   \\  /\n===m\"\"m===");
                break;
            case "p":
                Console.WriteLine("     /\\ \n    (o>\\ \n   //\\  \\> \n   V  \\ ) \n        |");
                break;
        }
    }
}
