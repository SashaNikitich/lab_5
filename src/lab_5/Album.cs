namespace lab_5
{
    /// <summary>
    /// Represents a music album that contains a collection of tracks
    /// and provides methods to manage and analyze them.
    /// </summary>
    public class Album
    {
        private List<Track> _tracks = new();

        /// <summary>
        /// Adds a new track to the album.
        /// </summary>
        /// <param name="track">The track to add.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the provided track is null.
        /// </exception>
        public void AddTrack(Track track)
        {
            if (track == null)
                throw new ArgumentException("Track can't be empty");
            
            _tracks.Add(track);
        }

        /// <summary>
        /// Sorts tracks by genre, then by duration,
        /// and finally by title.
        /// </summary>
        public void SortByStyle()
        {
            _tracks = _tracks
                .OrderBy(t => t.Genre)
                .ThenBy(t => t.Duration)
                .ThenBy(t => t.Title)
                .ToList();
        }

        /// <summary>
        /// Calculates the total duration of all tracks in the album.
        /// </summary>
        /// <returns>
        /// Total duration of the album.
        /// </returns>
        public double GetTotalDuraton()
        {
            return _tracks.Sum(t => t.Duration);
        }

        /// <summary>
        /// Finds tracks with duration within the specified range.
        /// </summary>
        /// <param name="min">Minimum track duration.</param>
        /// <param name="max">Maximum track duration.</param>
        /// <returns>
        /// List of tracks whose duration is between
        /// <paramref name="min"/> and <paramref name="max"/>.
        /// </returns>
        public List<Track> FindByDuration(double min, double max)
        {
            return _tracks
                .Where(t => t.Duration >= min && t.Duration <= max)
                .ToList();
        }

        /// <summary>
        /// Prints all tracks in the album to the console.
        /// </summary>
        public void PrintTracks()
        {
            _tracks.ForEach(Console.WriteLine);
        }

        /// <summary>
        /// Gets a read-only list of tracks in the album.
        /// </summary>
        /// <returns>
        /// Read-only collection of tracks.
        /// </returns>
        public IReadOnlyList<Track> GetTracks()
        {
            return _tracks.AsReadOnly();
        }
    }
}
