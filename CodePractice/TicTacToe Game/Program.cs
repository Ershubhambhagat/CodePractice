using System.ComponentModel;
using System.Security;

namespace TicTac
{

    class programe()
    {

        #region The PlayField
        static char[,] PlayField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},

        };

        #endregion


        #region aaaaa

        #endregion


        #region aaaaa

        #endregion

        #region aaaaa

        #endregion

        static void Main(string[]args)
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

                do
                {

                    Console.WriteLine("\n Player {0}: Choose  your Field!",playere);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter Only Int");

                        throw;
                    }
                } while (!inputCorrect);
            }



            while (true);


        }
        #region setField FrontEnd
        public static void setField()
        {
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[0, 0] ,PlayField[0,1], PlayField[0, 2]);
            Console.WriteLine("__________|__________|__________");
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[1, 0], PlayField[1, 1], PlayField[1, 2]);
            Console.WriteLine("__________|__________|__________"); 
            Console.WriteLine("          |          |          ");
            Console.WriteLine("     {0}    |    {1}     |    {2}    ", PlayField[2, 0], PlayField[2, 1], PlayField[2,2]);
            Console.WriteLine("__________|__________|__________");
            Console.WriteLine("          |          |          ");
            Console.WriteLine("          |          |          ");
        }
        #endregion

        #region EnterXorO
        public static void EnterXorO(int player ,int input)
        {
            char playersign = ' ';
            if(player is 1)
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

        #region aaaaa

        #endregion


    }
}