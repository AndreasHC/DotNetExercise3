namespace DotNetExercise3
{
    internal enum SwanSongPattern
    {
        Never,
        Intermittently,
        OnlyAtDeath
    }
    internal class Swan : Bird
    {
        private SwanSongPattern songPattern;

        public SwanSongPattern SongPattern
        {
            get { return songPattern; }
            set { songPattern = value; }
        }

        public Swan(string name, double weight, int age, double wingSpan, SwanSongPattern songPattern) : base(name, weight, age, wingSpan)
        {
            SongPattern = songPattern;
        }
    }
}
