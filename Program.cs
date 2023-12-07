using System;
using System.Collections.Generic;
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

            Console.CursorVisible = false;
            Console.SetCursorPosition(player1.PositionX, player1.PositionY);
            Console.WriteLine(player1.Icon);

            Console.SetCursorPosition(player2.PositionX, player2.PositionY);
            Console.WriteLine(player2.Icon);
        }

        class Player
        {
            private int _positionX;
            private int _positionY;
            private char _icon;

            public Player(char icon, int positionX = 0, int positionY = 0)
            {
                if (positionX > 0)      // Не ставлю равно, потому как поля изначально проинициализированны нулем
                    _positionX = positionX;

                if (positionY > 0)
                    _positionY = positionY;

                _icon = icon;
            }

            public int PositionX
            {
                get
                {
                    return _positionX;
                }
                private set
                {
                    if (value >= 0)
                        _positionX = value;
                }
            }

            public int PositionY
            {
                get
                {
                    return _positionY;
                }
                private set
                {
                    if (value >= 0)
                        _positionY = value;
                }
            }

            public char Icon
            {
                get
                {
                    return _icon;
                }
                private set
                {
                    _icon = value;
                }
            }
        }
    }
}
