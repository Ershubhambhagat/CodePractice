using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_and_MultiCast_DElegates
{
    public class AudioSystem
    {

        public AudioSystem()
        {
            //Subscribe to the StartGame ,GameOver
            GameEventManager.OnStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }
        //At the Start of the game 
        private void StartGame()
        {
            Console.WriteLine("Audio  Started");
            Console.WriteLine("********************");
        }
        private void GameOver()
        {
            Console.WriteLine();
            Console.WriteLine("Audio  Stop");
            Console.WriteLine("********************");
        }

    }
}
