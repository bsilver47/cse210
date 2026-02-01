using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main()
        {
            Scripture scripture = new Scripture("Doctrine and Covenants ", 121, 36, 37, "36 That the rights of the priesthood are inseparably connected with the powers of heaven, and that the powers of heaven cannot be controlled nor handled only upon the principles of righteousness. 37 That they may be conferred upon us, it is true; but when we undertake to cover our sins, or to gratify our pride, our vain ambition, or to exercise control or dominion or compulsion upon the souls of the children of men, in any degree of unrighteousness, behold, the heavens withdraw themselves; the Spirit of the Lord is grieved; and when it is withdrawn, Amen to the priesthood or the authority of that man.");
            while (true)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("All words are hidden. Exiting.");
                    break;
                }
            }
        }
    }
}
