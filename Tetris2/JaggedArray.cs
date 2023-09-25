using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris2
{
    internal class JaggedArray
    {
        public void Run()
        {
            bool[][] data = new bool[20][]; // 20 řádků - počet sloupců neuvádím

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = new bool[10];
            }
            

            T(2, 2, data);
            Z(5, 7, data);

            while (true)
            {
                MainLoop(data);
                Thread.Sleep(1000);

            }


        }

        public void T(int x, int y, bool[][] data)
        {
            data[y][x] = true;
            data[y][x + 1] = true;
            data[y][x + 2] = true;
            data[y + 1][x + 1] = true;

            //tvar T
        }

        public void Z(int x, int y, bool[][] data)
        {
            data[y][x] = true;
            data[y][x + 1] = true;
            data[y + 1][x + 1] = true;
            data[y + 1][x + 2] = true;
            //tvar Z
        }

        public void MainLoop(bool[][] data)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            //nyní je třeba posunout kostičky dolů - projít to vícerozměrné pole data a posunout to o 1 níž

            for (int i = data.Length - 1; i > 0; i--) //celý řádek o jedno níž
            {
                data[i] = data[i - 1];
            }
            data[0] = new bool[data[0].Length]; //první řádek nahradím novým, prázdným řádkem

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            // \u2588 znak - 2 vedle sebe - kostička

            Console.CursorVisible = false;

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.Write(data[i][j] ? "\u2588\u2588" : "  ");

                }
                Console.WriteLine();
            }
        }
    }
}
