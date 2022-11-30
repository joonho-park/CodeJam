using System;
using System.Collections.Generic;
using System.Linq;
namespace CodeJam
{
    class main
    {
        static void Main(String[] args)
        {
            string line = Console.ReadLine();
            int result = 0;
            main code = new main();
            for (int i = 0; i < int.Parse(line); i++)
            {
                int length = int.Parse(Console.ReadLine());
                string text = Console.ReadLine();

                result = code.CodeJamCase3(text.Split(' ').Select(t => int.Parse(t)).ToArray());
                Console.WriteLine("Case #" + (i + 1) + ": " + result);
            }
        }
        public int CodeJamCase3(int[] dice)
        {
            int count = 1;
            Array.Sort(dice);
            for (int i = 0; i < dice.Length; i++)
            {
                if (count <= dice[i])
                {
                    count++;
                }
            }
            return count - 1;
        }
    }
}
