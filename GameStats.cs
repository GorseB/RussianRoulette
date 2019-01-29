namespace RussianRoulette
{
    internal static class GameStats
    {
        public static int GamesPlayed = 0;
        public static int Won = 0;
        public static int Lost = 0;
        public static int Streak = 0;
        public static bool LostLast = false;
        public static int RouletteMissles = 0;
        public static bool Isplaying = false;
        // Most of our globals are kept here, so that everyone can see them \(o_o)/
        public static string[] textinfo = new string[3];
    }
}