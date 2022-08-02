﻿using System.Windows.Forms;

namespace Digger
{
    public static class Game
    {
        private const string mapWithPlayerTerrain = @"
TTT TT T TT T T
TTP TT T TT T T
T T TT T TT T T
T T TT T TT T T
T T TT T TT T T
T T TT T TT T T
T T TT T TT T T
TT TTT T TT T T";

        private const string mapWithPlayerTerrainSackGold = @"
PTTGTT TS
TST  TSTT
TTTTTTSTT
T TSTS TT
T TTTG ST
TSTSTT TT";

        private const string mapWithPlayerTerrainSackGoldMonster = @"
PTTGTT TST
TST  TSTTM
TTT TTSTTT
T TSTS TTT
T TTTGMSTS
T TMT M TS
TSTSTTMTTT
S TTST  TG
 TGST MTTT
 T  TMTTTT";

        public static ICreature[,] Map;
        public static int Scores;
        public static bool IsOver;

        public static Keys KeyPressed;
        public static int MapWidth => Map.GetLength(0);
        public static int MapHeight => Map.GetLength(1);

        public static void CreateMap()
        {
            Map = CreatureMapCreator.CreateMap(mapWithPlayerTerrain);
        }
    }
}