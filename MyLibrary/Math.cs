namespace MyLibrary
{
    public static class Math
    {
        public static string Seconds2HoursTime (int timeSeconds)
        {
            if (timeSeconds < 0) throw new Exception("S'espera un número positiu");

            int hours = timeSeconds / 3600;
            int minutes = (timeSeconds % 3600)/60;
            int seconds = timeSeconds % 60;

            return $"{hours}hores {minutes}minuts {seconds}segons";
        }
    }
}
