using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Event_and_MultiCast_DElegates
{
    public class Players
    {
        public string PlayersName { get; set; }
        public Players(string name)
        {
            //Subscribe to the StartGame ,GameOver
          
            this.PlayersName = name;
            Console.WriteLine($"Player Name is: {PlayersName}");
            GameEventManager.OnStart += StartGame;
            GameEventManager.OnGameOver += GameOver;


        }
        private void StartGame()
        {
            Console.WriteLine("+++++++++++++++++---Start Game ---+++++++++++++++++");

            Console.WriteLine($"Player Name is: { PlayersName}");
        }
        private void GameOver()
        {
            Console.WriteLine($"Player Name is { PlayersName}");
    
            Console.WriteLine("+++++++++++++++++---OVER---+++++++++++++++++");
        }
    }

}
