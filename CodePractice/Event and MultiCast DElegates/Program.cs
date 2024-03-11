using Event_and_MultiCast_DElegates;


using System;

AudioSystem audio = new AudioSystem();
RanderingEngine randeringEngine = new RanderingEngine();
Players players1 = new Players("shubham");

GameEventManager.TriggerGameStart();


Console.ReadKey();
GameEventManager.TriggerGameOver();
