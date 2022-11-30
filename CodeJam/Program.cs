
using System;
using System.Collections.Generic;
namespace CodeJam
{
    class main
    {
        static void Main(String[] args)
        {
            string line = Console.ReadLine();
            int resultC = 0;
            int resultR = 0;
            string[] list = new string[2];
            main code = new main();
            for (int i = 0; i < int.Parse(line); i++)
            {
                string text = Console.ReadLine();
                list = text.Split(' ');
                Console.WriteLine("Case #" + (i + 1) + ": ");
                code.CodeJam2(int.Parse(list[0]), int.Parse(list[1]));

            }
        }
        public void CodeJam2(int R, int C)
        {
            if (R > 10 || R < 2 || C > 10 || C < 2)
            {
                return;
            }

            for (int i = 0; i < (2 * R) + 1; i++)
            {

                for (int j = 0; j < C; j++)
                {
                    if (i < 2 && j < 1)
                    {
                        Console.Write("..");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write("+-");
                    }
                    else
                    {
                        Console.Write("|.");
                    }

                }
                if (i % 2 == 0)
                {
                    Console.Write('+');
                }
                else
                {
                    Console.Write('|');
                }
                Console.WriteLine();
            }
        }

    }
}













































//namespace CodeJam
//{
//    class main
//    {
//        static void Main(String[] args)
//        {
//            //string line = Console.ReadLine();
//            //int resultC = 0;
//            //int resultR = 0;
//            //string[] list = new string[2];
//            //main code = new main();
//            //for (int i = 0; i < int.Parse(line); i++)
//            //{
//            //    string text = Console.ReadLine();
//            //    list = text.Split(' ');
//            //    Console.WriteLine("Case #" + (i + 1) + ": ");
//            //    code.CodeJam2(int.Parse(list[0]),int.Parse(list[1]));
                
//            //}

//            main code = new main();

//            int inputCaseCount = 0;
//            if (int.TryParse(Console.ReadLine(), out inputCaseCount))
//            {
//                if (inputCaseCount < 1 || inputCaseCount > 100)
//                {
//                    return;
//                }
//            }
//            List<int> list = new List<int>();
//            int result = 0;
//            int ret = 0;
//            for (int i = 0; i < inputCaseCount; i++)
//            {
//                int inputDiceCount = 0;
//                if (int.TryParse(Console.ReadLine(), out inputDiceCount))
//                {
//                    if (inputDiceCount < 1 || inputDiceCount > 10)
//                    {
//                        return;
//                    }
//                }

//                for (int j = 0; j < inputDiceCount; j++)
//                {
//                    if (int.TryParse(Console.ReadLine(), out result))
//                    {
//                        if (result < 4 || result > 20)
//                        {
//                            return;
//                        }
//                        list.Add(result);
//                    }

//                }
//                ret = code.CodeJamCase3(inputDiceCount, list);
//                Console.WriteLine("Case #{0}: {1}", i, ret);
//                list.Clear();
//            }

//        }

//        public void CodeJam(int num, int R, int C)
//        {
//            if (num > 82 || num < 0 || R > 10 || R < 2 || C > 10 || C < 2)
//            {
//                return;
//            }
//            List<string> Plus = new List<string>((2 * R) + 1);
//            List<string> II = new List<string>((2 * R) + 1);
//            List<string> PlusFirst = new List<string>((2 * R) + 1);
//            List<string> IIFirst = new List<string>((2 * R) + 1);

//            string PF = String.Empty;
//            string IF = String.Empty;
//            string P = String.Empty;
//            string I = String.Empty;
//            for (int i = 0; i < (2 * C) + 1; i++)
//            {
//                if (i > 1)
//                {
//                    if (i % 2 == 0)
//                    {
//                        PlusFirst.Add("+");
//                        IIFirst.Add("|");
//                    }
//                    else
//                    {
//                        PlusFirst.Add("-");
//                        IIFirst.Add(".");
//                    }
//                }
//                else
//                {
//                    PlusFirst.Add(".");
//                    IIFirst.Add(".");

//                }
//                if (i % 2 == 0)
//                {
//                    Plus.Add("+");
//                    II.Add("|");
//                }
//                else
//                {
//                    Plus.Add("-");
//                    II.Add(".");
//                }
//                PF += PlusFirst[i];
//                IF += IIFirst[i];
//                P += Plus[i];
//                I += II[i];

//            }
//            Console.WriteLine("Case #{0} : ", num + 1);
//            for (int j = 0; j < (2 * R) + 1; j++)
//            {
//                if (j > 1)
//                {
//                    if (j % 2 == 0)
//                    {
//                        Console.WriteLine("{0}", P);
//                    }
//                    else
//                    {
//                        Console.WriteLine("{0}", I);
//                    }
//                }
//                else
//                {
//                    if (j % 2 == 0)
//                    {
//                        Console.WriteLine("{0}", PF);
//                    }
//                    else
//                    {
//                        Console.WriteLine("{0}", IF);
//                    }
//                }
//            }

//            Plus.Clear();
//            PlusFirst.Clear();
//            II.Clear();
//            IIFirst.Clear();

//            PF = String.Empty;
//            IF = String.Empty;
//            P = String.Empty;
//            I = String.Empty;
//        }

//        public void CodeJam2( int R, int C)
//        {
//            if (R > 10 || R < 2 || C > 10 || C < 2)
//            {
//                return;
//            }

//            for (int i = 0; i < (2*R)+1; i++)
//            {

//                for (int j = 0; j < C; j++)
//                {
//                    if (i < 2 && j < 1)
//                    {
//                        Console.Write("..");
//                    }
//                    else if (i % 2 == 0)
//                    {
//                        Console.Write("+-");
//                    }
//                    else
//                    {
//                        Console.Write("|.");
//                    }

//                }
//                if (i % 2 == 0)
//                {
//                    Console.Write('+');
//                }
//                else
//                {
//                    Console.Write('|');
//                }
//                Console.WriteLine();
//            }
//        }

//        public int CodeJamCase3(int[] dice)
//        {
//            int count = 1;

//            Array.Sort(dice);

//            for (int i = 0; i < dice.Length; i++)
//            {
//                if (count <= dice[i])
//                {
//                    count++;
//                }
//            }
//            return count-1;
//        }
//    }
//}
//int inputT = int.Parse(Console.ReadLine());
//for (int i = 0; i < inputT; i++)
//{
//    int inputR = int.Parse(Console.ReadLine());
//    int inputC = int.Parse(Console.ReadLine());
//    //  code.CodeJam(i, inputR, inputC);
//    code.CodeJam2(i, inputR, inputC);
//}


//for (int i = 0; i < (2 * R) + 1; i++)
//{

//    for (int j = 0; j < C; j++)
//    {
//        if (i < 2 && j < 1)
//        {
//            Console.Write("..");
//        }
//        else if (i % 2 == 0)
//        {
//            Console.Write("+-");
//        }
//        else
//        {
//            Console.Write("|.");
//        }

//    }
//    if (i % 2 == 0)
//    {
//        Console.Write('+');
//    }
//    else
//    {
//        Console.Write('|');
//    }
//    Console.WriteLine();
//}