namespace TicTacToe
{
    /* TIC TAC TOE
     * Created by rene.jock@outlook.de
     * DATE: 03/24/2023
     */
    internal class Program
    {
        static char player1 = 'X';
        static char player2 = 'O';

        static void Main(string[] args)
        {
            char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine(field[0] + " | " + field[1] + " | " + field[2]);
            Console.WriteLine("---------");
            Console.WriteLine(field[3] + " | " + field[4] + " | " + field[5]);
            Console.WriteLine("---------");
            Console.WriteLine(field[6] + " | " + field[7] + " | " + field[8]);

            Console.ReadKey();
        }
    }
}