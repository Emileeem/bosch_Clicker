using static System.Console;
using System;

Shop shop = new Shop();     
Game game = new Game ();
game.Start();
WriteLine("Bem vindo ao Bosch Clicker! Aperte espaço para começar essa jornada!");
while (true)
{
    var command = ReadKey(true);
    var key = command.Key;
    switch(key)
    {
        case ConsoleKey.Spacebar:
            shop.Click();
            break;

            
    }

    Clear();

    string teste =("==============================\n" +
                   "|(space)Bicos injetores: "+ shop.BicoInjetor + "|\n" +
                   "==============================\n");
    WriteLine(teste);
}