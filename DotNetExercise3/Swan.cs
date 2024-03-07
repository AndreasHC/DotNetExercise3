using System.Collections.Immutable;

namespace DotNetExercise3
{
    internal enum SwanSongPattern
    {
        Never,
        Intermittently,
        OnlyAtDeath
    }

    internal static class SwanSongPatternTranslator
    {
        private static ImmutableDictionary<SwanSongPattern, string> swedish = (new Dictionary<SwanSongPattern, string> { { SwanSongPattern.Never, "Aldrig" }, { SwanSongPattern.Intermittently, "Sporadiskt" }, { SwanSongPattern.OnlyAtDeath, "Bara vid döden" } }).ToImmutableDictionary();

        public static string Swedish(SwanSongPattern pattern)
        { 
            return swedish[pattern];
        }
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

        public override string Stats()
        {
            return base.Stats() + $"Sångmönster: {SwanSongPatternTranslator.Swedish(SongPattern)}\n";
        }
    }
}
