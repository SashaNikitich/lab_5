namespace lab_5
{
    /// <summary>
    /// Represents a rock music track.
    /// </summary>
    public class RockMusic : Track
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RockMusic"/> class
        /// with the specified title and duration.
        /// </summary>
        /// <param name="t">The title of the track.</param>
        /// <param name="d">The duration of the track.</param>
        public RockMusic(string t, double d) : base(t, d)
        {
            Genre = "Rock";
        }
    }
}