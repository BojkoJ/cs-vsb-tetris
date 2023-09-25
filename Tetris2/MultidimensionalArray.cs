using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris2
{
    internal class MultidimensionalArray
    {
        public void Run()
        {
            bool[,] data = new bool[10, 20];

            T(2, 2, data);
            Z(5, 7, data);

            while(true)
            {
                MainLoop(data);
                Thread.Sleep(1000);

            }


        }

        public void T(int x, int y, bool[,] data)
        {
            data[x, y] = true;
            data[x + 1, y] = true;
            data[x + 2, y] = true;
            data[x + 1, y + 1] = true;

            //tvar T
        }

        public void Z(int x, int y, bool[,] data)
        {
            data[x, y] = true;
            data[x + 1, y] = true;
            data[x + 1, y + 1] = true;
            data[x + 2, y + 1] = true;

            //tvar Z
        }

        public void MainLoop(bool[,] data)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            //nyní je třeba posunout kostičky dolů - projít to vícerozměrné pole data a posunout to o 1 níž

            for (int i = data.GetLength(1) - 1; i > 0; i--)
            {
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    data[j, i] = data[j, i - 1];
                }
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            // \u2588 znak - 2 vedle sebe - kostička

            // .Length vrátí šířku * výšku - počet hodnot v poli
            // nás ale zajímá kolik jich je horizontálně a kolik vertikálně

            // getLength(0) by měl vrátit horizontální rozměr
            // getLength(1) by měl vrátit vertikální rozměr

            Console.CursorVisible = false;

            for(int i = 0; i < data.GetLength(1); i++)
            {
                for(int j = 0; j < data.GetLength(0); j++)
                {
                    Console.Write(data[j, i] ? "\u2588\u2588" : "  ");

                }
                Console.WriteLine();
            }
        }
    }
}
