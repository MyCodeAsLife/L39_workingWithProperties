using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L39_workingWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char playerIcon1 = '@';     // Фифра 1 в названии потому как заранее неизвестно какие иконки будут подгруженны из файла
            char playerIcon2 = '$';

            int playerPositionX = 12;
            int playerPositionY = 10;

            Player player1 = new Player(playerIcon1);
            Player player2 = new Player(playerIcon2, playerPositionX, playerPositionY);

            Renderer.WritePlayer(player1);
            Renderer.WritePlayer(player2);
        }

        class Player
        {
            private int _positionX;
            private int _positionY;
            private char _icon;

            public Player(char icon, int positionX = 0, int positionY = 0)
            {
                SetPosition(positionX, positionY);
                SetIcon(icon);
            }

            public int PositionX
            {
                get
                {
                    return _positionX;
                }
            }

            public int PositionY
            {
                get
                {
                    return _positionY;
                }
            }

            public char Icon
            {
                get
                {
                    return _icon;
                }
            }

            private void SetPosition(int positionX, int positionY)
            {
                if (positionX >= 0)
                    _positionX = positionX;

                if (positionY >= 0)
                    _positionY = positionY;
            }

            private void SetIcon(char icon)
            {
                _icon = icon;
            }
        }

        class Renderer
        {
            public static void WritePlayer(Player player)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(player.PositionX, player.PositionY);
                Console.WriteLine(player.Icon);
            }
        }
    }
}
