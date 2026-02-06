namespace lab_5
{
    /// <summary>
    /// Represents a metal music track.
    /// </summary>
    public class MetalMusic : Track
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetalMusic"/> class
        /// with the specified title and duration.
        /// </summary>
        /// <param name="t">The title of the track.</param>
        /// <param name="d">The duration of the track.</param>
        public MetalMusic(string t, double d) : base(t, d)
        {
            Genre = "Metal";
        }
    }
}