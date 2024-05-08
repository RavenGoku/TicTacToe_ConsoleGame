using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_ConsoleGame
{
    internal class Player
    {
        public Player(string pName,string pSign)
        {
            PlayerName = pName;
            PlayerSign = pSign;
        }

        ~Player()
        {
        }

        //Properties
        public string PlayerName { get; }

        public string PlayerSign { get; }

        //Functions
    }
}