﻿/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            IScoreHouse n = new ScoreHouse();  //need to come fix here
            IScoreHouse v = new ScoreHouse();
            Player one = new Player("Player 1",n);
            Player two = new Player("Player 2",v);
            Board b = new Board(one, two);
            // rest left as exercise to reader!
        }
    }
}
