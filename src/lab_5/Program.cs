namespace lab_5
{
    /// <summary>
    /// Entry point of the application.
    /// Demonstrates working with the Album class:
    /// adding tracks, sorting them, calculating total duration,
    /// and searching tracks by duration range.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of the program.
        /// </summary>
        static void Main()
        {
            try
            {
                var album = new Album();

                // Adding tracks of different music genres
                album.AddTrack(new PopMusic("You Belong With Me", 3.51));
                album.AddTrack(new MetalMusic("One", 7.26));
                album.AddTrack(new RockMusic("Sweet Child O' Mine", 5.56));
                album.AddTrack(new PopMusic("I Kissed A Girl", 2.59));
                album.AddTrack(new MetalMusic("Domination", 5.05));
                album.AddTrack(new RockMusic("Paradise City", 6.45));

                Console.WriteLine("\nInitial list\n");
                album.PrintTracks();

                Console.WriteLine($"\nTotal duration: {album.GetTotalDuraton()}\n");

                Console.WriteLine("\nSorted list\n");
                album.SortByStyle();
                album.PrintTracks();

                double min = 4.0, max = 7.0;
                Console.WriteLine($"\nTracks in range: {min}-{max} minutes\n");

                foreach (var track in album.FindByDuration(min, max))
                {
                    Console.WriteLine(track);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}