namespace TicTacToe_ConsoleGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SetField();
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",1,2,3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",1,2,3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ",1,2,3);
            Console.WriteLine("     |     |     ");
        }

        private bool WinChecker(string[,] board)
        {
            for( int row = 0, column = 0; row < board.GetLength(0); row++, column++ )
            {
                //Horizontal and Vertical Check 'X'
                if( board[row,0] == board[row,1] && board[row,1] == board[row,2] && board[row,column] == "X" ||
                    board[0,row] == board[1,row] && board[1,row] == board[2,row] && board[row,column] == "X" )
                    return true;
                //Diagonal and Reverse Diagonal Check 'X'
                if( board[0,0] == board[1,1] && board[1,1] == board[2,2] && board[row,column] == "X" ||
                    board[0,2] == board[1,1] && board[1,1] == board[2,0] && board[row,column] == "X" )
                    return true;

                //Horizontal and Vertical Check 'O'
                if( board[row,0] == board[row,1] && board[row,1] == board[row,2] && board[row,column] == "O" ||
                    board[0,row] == board[1,row] && board[1,row] == board[2,row] && board[row,column] == "O" )
                    return true;

                //Diagonal and Reverse Diagonal Check 'O'
                if( board[0,0] == board[1,1] && board[1,1] == board[2,2] && board[row,column] == "O" ||
                    board[0,2] == board[1,1] && board[1,1] == board[2,0] && board[row,column] == "O" )
                    return true;
            }

            return false;
        }
    }
}