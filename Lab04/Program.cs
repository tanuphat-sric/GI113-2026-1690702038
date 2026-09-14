/*
 * Student ID :1690702038
 * Name       :Tanuphat
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            
            Console.Write("Name your hero: ");
            Console.Write(">>>");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {playerName}. You journey begins..");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      DIFFICULTY SELECT       |");
            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Choose diffulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty {difficulty} selected. Good luck out there...");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|       ITEM SHOP      |");
            Console.WriteLine("+------------------------------+");

            Console.Write("How many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");/*

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}"); 

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");*/

            const string GameTitle = "ADVENTURE OF SKIBIDI";

            var DummyName = "Cameraman";
            var Rank = 'B';
            int Level = 7;
            float DMGcrit = 0.67f;
            double speed = 37.5;
            bool isPlayable = true;

            Console.WriteLine($"<<<<<<<<<<< {GameTitle} >>>>>>>>>>>>");
            Console.WriteLine($"<>Hero Name   : {DummyName}");
            Console.WriteLine($"<>Rank        : {Rank}");
            Console.WriteLine($"<>Level       : {Level}");
            Console.WriteLine($"<>Crit Chance : {DMGcrit}");
            Console.WriteLine($"<>Speed       : {speed}");
            Console.WriteLine($"<>Playable    : {isPlayable}");

            Console.WriteLine($"-<>--<>--<>--<>--<>--<>--<>--<>--<>--<>--<>-");

            double DummyLevelAsDouble = Level;
            Console.WriteLine($"<:>Level as double (implicit): {DummyLevelAsDouble}");

            int staminaTruncated = (int)speed;
            int staminaRounded = Convert.ToInt32(speed);
            Console.WriteLine($"<:>Speed cast   : {staminaTruncated}");
            Console.WriteLine($"<:>Speed Convert   : {staminaRounded}");

            Console.WriteLine($" ____   ___  ____    ____   ___  ____   __   _______ ______   _______ ____  _ \r\n|  _ \\ / _ \\|  _ \\  |  _ \\ / _ \\|  _ \\  \\ \\ / / ____/ ___\\ \\ / / ____/ ___|| |\r\n| | | | | | | |_) | | | | | | | | |_) |  \\ V /|  _| \\___ \\\\ V /|  _| \\___ \\| |\r\n| |_| | |_| |  __/  | |_| | |_| |  __/    | | | |___ ___) || | | |___ ___) |_|\r\n|____/ \\___/|_|     |____/ \\___/|_|       |_| |_____|____/ |_| |_____|____/(_)");
        }
    }
}
