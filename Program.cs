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
            char playerIcon1 = '@';
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
            public Player(char icon, int positionX = 0, int positionY = 0)
            {
                SetPosition(positionX, positionY);
                SetIcon(icon);
            }

            public int PositionX { get; private set; }

            public int PositionY { get; private set; }

            public char Icon { get; private set; }

            private void SetPosition(int positionX, int positionY)
            {
                if (IsCorrectPosition(positionX))
                    this.PositionX = positionX;

                if (IsCorrectPosition(positionY))
                    this.PositionY = positionY;
            }

            private void SetIcon(char icon)
            {
                Icon = icon;
            }

            private bool IsCorrectPosition(int position)
            {
                return position >= 0;
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
