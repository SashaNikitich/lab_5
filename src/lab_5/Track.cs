namespace lab_5
{
    /// <summary>
    /// Represents a base class for a music track.
    /// Contains common properties such as title, duration, and genre.
    /// </summary>
    public abstract class Track
    {
        /// <summary>
        /// Gets the title of the track.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the duration of the track in minutes.
        /// </summary>
        public double Duration { get; }

        /// <summary>
        /// Gets the genre of the track.
        /// </summary>
        public string? Genre { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="title">The title of the track.</param>
        /// <param name="duration">The duration of the track in minutes.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the title is null or empty,
        /// or when the duration is less than or equal to zero.
        /// </exception>
        protected Track(string title, double duration)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title can't be empty");

            if (duration <= 0)
                throw new ArgumentException("Track duration can't be <= 0");

            Title = title;
            Duration = duration;
        }

        /// <summary>
        /// Returns a string representation of the track.
        /// </summary>
        /// <returns>
        /// A formatted string containing the genre, title, and duration.
        /// </returns>
        public override string ToString()
        {
            return $"[{Genre}], {Title} ({Duration} minutes)";
        }
    }
}