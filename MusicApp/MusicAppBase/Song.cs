namespace MusicApp
{
    public enum Genre
    {
        Rock,
        Dance,
        Pop,
        Jazz,
        Metal,
        Classical
    }

    public class Song
    {
        public int NrOfPlays { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Artist Performer { get; set; }

        public Song(string title, Artist artist, Genre genre)
        {
            Title = title;
            Performer = artist;
            Genre = genre;
            NrOfPlays = new Random().Next(1000);
        }

        public void Play()
        {
            Console.WriteLine($"Playing {ToString()}");
            NrOfPlays++;
        }

        public void Pause()
        {
            Console.WriteLine("Pausing");
        }

        public override string ToString()
        {
            return $"{Title} by {Performer.Name}";
        }
    }
}