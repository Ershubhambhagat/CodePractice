using System.ComponentModel;
using System.Security;

namespace TicTac
{

    class Programe()
    {
        #region The PlayField
        static char[,] PlayField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},

        };

        #endregion

      

        #region turns
        static int turns = 0;
        #endregion

        #region ResetField
        public static void ResetField()
        {  
        char[,] playFieldInitial =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
        };
        
            PlayField = playFieldInitial;
            setField();
            turns = 0;

        }
        #endregion

        #region Main

        static void Main(string[] args)
        {
            int playere = 2;
            int input = 0;
            bool inputCorrect = true;
            //Run Code Infinite

            do
            {
                if (playere == 2)
                {
                    playere = 1;
                    EnterXorO(playere, input);

                }
                else if (playere == 1)
                {

                    playere = 2;
                    EnterXorO(playere, input);

                }
                setField();

                #endregion

        #region Check Winner
                char[] playerCahrs = { 'X', 'O' };

                foreach (var playerCahr in playerCahrs)
                {
                    if (((PlayField[0, 0] == playerCahr) && (PlayField[0, 1] == playerCahr) && (PlayField[0, 2] == playerCahr))
                        || ((PlayField[1, 1] == playerCahr) && (PlayField[1, 2] == playerCahr) && (PlayField[1, 0] == playerCahr))
                        ||
                         ((PlayField[0, 0] == playerCahr) && (PlayField[0, 1] == playerCahr) && (PlayField[0, 2] == playerCahr))
                         ||
                          ((PlayField[0, 0] == playerCahr) && (PlayField[0, 1] == playerCahr) && (PlayField[0, 2] == playerCahr))
                          ||
                           ((PlayField[0, 0] == playerCahr) && (PlayField[0, 1] == playerCahr) && (PlayField[0, 2] == playerCahr))

                        )
                    {
                        if (playerCahr == 'X')
                        {
                            Console.WriteLine("Winner 2 Won ");
                        }
                        else
                        {
                            Console.WriteLine("Winner 1 Won ");
                        }
                        Console.WriteLine("Please Press any key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns==10)
                    {
                        Console.WriteLine(  "There is no any winner");
                        Console.WriteLine("Please Press any key to Reset the Game");
                        Console.ReadKey();
                        ResetField();
                    }
                }
                #endregion

        #region Test If Field is Already Taken
                do
                {

                    Console.WriteLine("\n Player {0}: Choose  your Field!", playere);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter Only Number");
                    }
                    if ((input == 1) && (PlayField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (PlayField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (PlayField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (PlayField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (PlayField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (PlayField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (PlayField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (PlayField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (PlayField[2, 2] == '9'))
                        inputCorrect = true;

                    else
                    {
                        Console.WriteLine("\n Incorrect Input ! Please use Anothor Field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            }
            while (true);



        }
        #endregion

        #region setField FrontEnd
        public static void setField()
        {
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[0, 0], PlayField[0, 1], PlayField[0, 2]);
            Console.WriteLine("__________|__________|__________");
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[1, 0], PlayField[1, 1], PlayField[1, 2]);
            Console.WriteLine("__________|__________|__________");
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[2, 0], PlayField[2, 1], PlayField[2, 2]);
            Console.WriteLine("__________|__________|__________");
            Console.WriteLine("          |          |          ");
            Console.WriteLine("          |          |          ");
            turns++;
        }

        #endregion

        #region EnterXorO
        public static void EnterXorO(int player, int input)
        {
            char playersign = ' ';
            if (player is 1)
            {
                playersign = 'X';
            }
            else
            {
                if (player is 2)
                {
                    playersign = 'O';
                }
            }
            switch (input)
            {
                case 1: PlayField[0, 0] = playersign; break;
                case 2: PlayField[0, 1] = playersign; break;
                case 3: PlayField[0, 2] = playersign; break;
                case 4: PlayField[1, 0] = playersign; break;
                case 5: PlayField[1, 1] = playersign; break;
                case 6: PlayField[1, 2] = playersign; break;
                case 7: PlayField[2, 0] = playersign; break;
                case 8: PlayField[2, 1] = playersign; break;
                case 9: PlayField[2, 2] = playersign; break;

            }

        }

        #endregion
    }
}