/*
 * Student ID :1690702038
 * Name       :Tanuphat
 * Section    :129C
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Critmultiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            currentHp = currentHp - 60;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //Part B

            string Name = "Animan";
            char Stage = 'A';
            int mastery = 6;
            int MAXHp = 200;
            int currentHP = 150;
            float ATK = 40.5f;
            double critRate = 2.25;
            bool isMonster = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Stage: {Stage}");
            Console.WriteLine($"HP: {MAXHp} / {currentHP}");
            Console.WriteLine($"ATK: {ATK}");
            Console.WriteLine($"Crit rate: {critRate}");
            Console.WriteLine($"Is monster: {isMonster}");

            string Name01 = "jane";
            char Stage01 = 'C';
            int mastery0 = 9;
            int MAXHp01 = 250;
            int currentHP01 = 150;
            float ATK01 = 43.5f;
            double critRate01 = 2.25;
            bool isMonster01 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {Name01}");
            Console.WriteLine($"Stage: {Stage01}");
            Console.WriteLine($"HP: {MAXHp01} / {currentHP01}");
            Console.WriteLine($"ATK: {ATK01}");
            Console.WriteLine($"Crit rate: {critRate01}");
            Console.WriteLine($"Is monster: {isMonster01}");

            string Name02 = "Kai";
            char Stage02 = 'S';
            int mastery02 = 40;
            int MAXHp02 = 400;
            int currentHP02 = 320;
            float ATK02 = 52.4f;
            double critRate02 = 3.45;
            bool isMonster02 = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {Name02}");
            Console.WriteLine($"Stage: {Stage02}");
            Console.WriteLine($"HP: {MAXHp02} / {currentHP02}");
            Console.WriteLine($"ATK: {ATK02}");
            Console.WriteLine($"Crit rate: {critRate02}");
            Console.WriteLine($"Is monster: {isMonster02}");

            string Name03 = "Kai";
            char Stage03 = 'S';
            int mastery03 = 40;
            int MAXHp03 = 400;
            int currentHP03 = 320;
            float ATK03 = 52.4f;
            double critRate03 = 3.45;
            bool isMonster03  = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {Name03}");
            Console.WriteLine($"Stage: {Stage03}");
            Console.WriteLine($"HP: {MAXHp03} / {currentHP03}");
            Console.WriteLine($"ATK: {ATK03}");
            Console.WriteLine($"Crit rate: {critRate03}");
            Console.WriteLine($"Is monster: {isMonster03}");
        }   
       
    }
}
