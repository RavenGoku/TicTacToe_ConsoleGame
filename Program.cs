using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe_ConsoleGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create two players Type from basic player class contain sign and player name
            Player playerOne = new Player("Player One","O");
            Player playerTwo = new Player("Player Two","X");

            //endless while loop.
            do
            {
                //Game start
                string[,] board = new string[3,3]
                {
                { "1","2","3" },
                { "4","5","6" },
                { "7","8","9" }
                };

                bool isWon = false;
                SetField(board);
                // while loop is used till one of player will not win.
                // then game starts again
                do
                {
                    PlayerInput(playerOne,board);
                    SetField(board);
                    if( WinChecker(board,playerOne) )
                    {
                        isWon = true;
                        break;
                    }

                    PlayerInput(playerTwo,board);
                    SetField(board);
                    if( WinChecker(board,playerTwo) )
                    {
                        isWon = true;
                        break;
                    }
                } while( !isWon );

                Console.WriteLine("Press any key to restart game...");
                Console.ReadLine();
            } while( true );
        }

        //----------------------------Functions----------------------------------------------

        // ********************************************************************************
        /// <summary>
        /// Setting field of TicTacToe that will display the game
        /// </summary>
        /// <param name="string"></param>
        /// <param name="board"></param>
        // <created>Kamil Mikolajewski,09/05/2024</created>
        // <changed>Kamil Mikolajewski,09/05/2024</changed>
        // ********************************************************************************
        private static void SetField(string[,] board)
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",board[0,0],board[0,1],board[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",board[1,0],board[1,1],board[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",board[2,0],board[2,1],board[2,2]);
            Console.WriteLine("     |     |     ");
        }

        // ********************************************************************************
        /// <summary>
        /// Player should input to what field he wants to put his sign "X" or "O"
        /// </summary>
        /// <param name="player"></param>
        /// <param name="string"></param>
        /// <param name="board"></param>
        // <created>Kamil Mikolajewski,09/05/2024</created>
        // <changed>Kamil Mikolajewski,09/05/2024</changed>
        // ********************************************************************************
        public static void PlayerInput(Player player,string[,] board)
        {
            string input;
            // boolean needed to check if player will not overwrite others player sign
            bool isValidInput = false;
            do
            {
                //gets player name and wait for proper input.
                Console.Write(player.PlayerName + ": ");
                input = Console.ReadLine();

                switch( input )
                {
                    case "1":
                        if( board[0,0] != "X" && board[0,0] != "O" )
                        {
                            board[0,0] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "2":
                        if( board[0,1] != "X" && board[0,1] != "O" )
                        {
                            board[0,1] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "3":
                        if( board[0,2] != "X" && board[0,2] != "O" )
                        {
                            board[0,2] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "4":
                        if( board[1,0] != "X" && board[1,0] != "O" )
                        {
                            board[1,0] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "5":
                        if( board[1,1] != "X" && board[1,1] != "O" )
                        {
                            board[1,1] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "6":
                        if( board[1,2] != "X" && board[1,2] != "O" )
                        {
                            board[1,2] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "7":
                        if( board[2,0] != "X" && board[2,0] != "O" )
                        {
                            board[2,0] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "8":
                        if( board[2,1] != "X" && board[2,1] != "O" )
                        {
                            board[2,1] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;

                    case "9":
                        if( board[2,2] != "X" && board[2,2] != "O" )
                        {
                            board[2,2] = player.PlayerSign;
                            isValidInput = true;
                        }
                        else
                            Console.WriteLine("Already filled, Try Again! ");
                        break;
                }
            } while( !isValidInput );
        }

        // ********************************************************************************
        /// <summary>
        /// Function that check for vertical, horizontal, diagonal and reverse diagonal
        /// match ups on the board, if so then return true
        /// </summary>
        /// <param name="board"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        // <created>Kamil Mikolajewski,09/05/2024</created>
        // <changed>Kamil Mikolajewski,09/05/2024</changed>
        // ********************************************************************************
        public static bool WinChecker(string[,] board,Player player)
        {
            for( int row = 0, column = 0; row < board.GetLength(0); row++, column++ )
            {
                //Horizontal and Vertical Check
                if( board[row,0] == board[row,1] && board[row,1] == board[row,2] ||
                    board[0,row] == board[1,row] && board[1,row] == board[2,row] )
                {
                    Console.WriteLine();
                    Console.WriteLine(player.PlayerName + " Won!");
                    return true;
                }
                //Diagonal and Reverse Diagonal Check
                if( board[0,0] == board[1,1] && board[1,1] == board[2,2] ||
                    board[0,2] == board[1,1] && board[1,1] == board[2,0] )
                {
                    Console.WriteLine();
                    Console.WriteLine(player.PlayerName + " Won!");
                    return true;
                }
            }

            return false;
        }
    }
}