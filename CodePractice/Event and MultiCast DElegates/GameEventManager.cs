using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_and_MultiCast_DElegates
{
    public class GameEventManager
    {
        //New delegate type GameEvent
        public   delegate void GameEvent();
        //Create 2 delegate Variable 
        public static event GameEvent OnStart, OnGameOver;
        public static void TriggerGameStart()
        {
            if (OnStart != null)
            {
                Console.WriteLine(  "Game Has Start");
                OnStart();
            }
            
        }
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("Game Has Over");
                OnGameOver();
            }

        }

    }
}
