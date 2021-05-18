using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn
{
    class Program
    {
        static char[] b = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int[] mrd = { 49,58 };
        static int gov = 0; static int winner = 0; static int luot;
        static void Main(string[] args)
        {
            for (int l = 0;;)
            {
                char player;
                printboard();
                if (l > 0) gamecheck();
                if (gov == 1) break;
                Console.Write("\n Moi ban nhap nuoc di : ");
                string nhap = Console.ReadLine();
                if (char.TryParse(nhap, out player))
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if ((player == b[i]))
                        {
                            b[i] = 'X';
                            printboard();
                            l++;
                            char com;
                            gamecheck();
                            if (gov == 1) break;
                            for (int p = 0; p == 0; )
                            {
                                Random rd = new Random();
                                int com_int = rd.Next(mrd[0], mrd[1]);
                                com = Convert.ToChar(com_int);
                                for (int j = 0; j < 9; j++)
                                {
                                    if (com == b[j])
                                    {
                                        b[j] = 'O';
                                        Console.Clear();
                                        printboard();
                                        l++;
                                        p++;
                                    }
                                }
                            }
                        }
                        if (player == 'h')
                        {
                            Console.Write(">>enter code : ");
                            string pass = Console.ReadLine();
                            if (pass == "game.hack.bit64 <player> to winner_cross")
                            {
                                gov = 1; winner = 2;
                                for (int h = 0; h < 9; h++)
                                {
                                    b[h] = 'X';
                                }
                                break;
                            }
                            else break;

                        }
                        if (player == 'c')
                        {
                            Console.WriteLine(" Copyright Nguyen Anh Quan 2020");
                            Console.ReadLine();
                            break;
                        }
                    }
                }

            }
            Console.WriteLine("\nGame Over");
            if (winner == 1) Console.WriteLine("May chien thang ");
            else if (winner == 2) Console.WriteLine("Ban chien thang ");
            else if (winner == 3) Console.WriteLine("Hoa");

            Console.ReadLine();
        }

        static void printboard()
        {
            Console.Clear();
            Console.WriteLine("Tick tac toe 3x3 \n");
            for (int i = 0; ; i++)
            {
                Console.Write("{0,2}", b[i]);
                if ((i + 1) % 3 == 0) Console.WriteLine();
                if (i == 8) break;

            }
        }

        static void gamecheck()
        {
            for (int i = 1; i < 3; i++)
            {
                char x = 'X';
                if (i == 1)
                {
                    x = 'O';
                }
                else if (i == 2)
                {
                    x = 'X';
                }
                if ((b[0] == x && b[1] == x && b[2] == x)
                    || (b[3] == x && b[4] == x && b[5] == x)
                    || (b[6] == x && b[7] == x && b[8] == x)
                    || (b[0] == x && b[3] == x && b[6] == x)
                    || (b[1] == x && b[4] == x && b[7] == x)
                    || (b[0] == x && b[4] == x && b[8] == x)
                    || (b[2] == x && b[5] == x && b[8] == x)
                    || (b[2] == x && b[4] == x && b[6] == x)
                   )
                {
                    gov = 1; winner = i;
                    break;
                }
                else
                {
                    luot = luot + 1;
                }
                if (luot == 18)
                {
                    gov = 1; winner = 3;
                }
            }

        }

    }
}
