using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_and_MultiCast_DElegates
{
    public class RanderingEngine
    {
        public RanderingEngine()
        {
            //Subscribe to the StartGame ,GameOver
            GameEventManager.OnStart += StartGame;
            GameEventManager.OnGameOver += GameOver;

        }
        //At the Start of the game 
        private  void StartGame()
        {
            Console.WriteLine("Rendring Engine Started");
            Console.WriteLine("Drowing Visuals");
        }
        private void GameOver() 
        {
            Console.WriteLine("Rendring Engine Stop ");
        }
    }
}
