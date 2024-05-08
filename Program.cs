using System.Security.Cryptography.X509Certificates;

namespace TicTacToe_ConsoleGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player playerOne = new Player("Player One","O");
            Player playerTwo = new Player("Player Two","X");
            do
            {
                string[,] board = new string[3,3]
                {
                { "1","2","3" },
                { "4","5","6" },
                { "7","8","9" }
                };

                do
                {
                    SetField(board);
                    PlayerInput(playerOne,board);
                } while( !WinChecker(board) );

                Console.ReadLine();
            } while( true );
        }

        private static void SetField(string[,] board)
        {
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

        private static void PlayerInput(Player player,string[,] board)
        {
            string input;
            Console.Write(player.PlayerName + ": ");
            input = Console.ReadLine();
            switch( input )
            {
                case "1":
                    if( board[0,0] != player.PlayerSign )
                        board[0,0] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "2":
                    if( board[0,1] != player.PlayerSign )
                        board[0,1] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "3":
                    if( board[0,2] != player.PlayerSign )
                        board[0,2] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "4":
                    if( board[1,0] != player.PlayerSign )
                        board[1,0] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "5":
                    if( board[1,1] != player.PlayerSign )
                        board[1,1] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "6":
                    if( board[1,2] != player.PlayerSign )
                        board[1,2] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "7":
                    if( board[2,0] != player.PlayerSign )
                        board[2,0] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "8":
                    if( board[2,1] != player.PlayerSign )
                        board[2,1] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                case "9":
                    if( board[2,2] != player.PlayerSign )
                        board[2,2] = player.PlayerSign;
                    else
                        Console.WriteLine("Already filled, Try Again! ");
                    break;

                default:

                    break;
            }
            Console.Clear();
        }

        private static bool WinChecker(string[,] board)
        {
            for( int row = 0, column = 0; row < board.GetLength(0); row++, column++ )
            {
                //Horizontal and Vertical Check 'X'
                if( board[row,0] == board[row,1] && board[row,1] == board[row,2] ||
                    board[0,row] == board[1,row] && board[1,row] == board[2,row] )
                    return true;
                //Diagonal and Reverse Diagonal Check 'X'
                if( board[0,0] == board[1,1] && board[1,1] == board[2,2] ||
                    board[0,2] == board[1,1] && board[1,1] == board[2,0] )
                    return true;

                ////Horizontal and Vertical Check 'O'
                //if( board[row,0] == board[row,1] && board[row,1] == board[row,2] && board[row,column] == "O" ||
                //    board[0,row] == board[1,row] && board[1,row] == board[2,row] && board[row,column] == "O" )
                //    return true;

                ////Diagonal and Reverse Diagonal Check 'O'
                //if( board[0,0] == board[1,1] && board[1,1] == board[2,2] && board[row,column] == "O" ||
                //    board[0,2] == board[1,1] && board[1,1] == board[2,0] && board[row,column] == "O" )
                //    return true;
            }

            return false;
        }
    }
}