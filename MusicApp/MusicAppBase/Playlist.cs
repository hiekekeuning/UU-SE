namespace MusicApp
{
    public class Playlist
    {
        private readonly List<Song> _list = [];
        private readonly List<Song> _lib;
        private RecommenderMode _songRecMode;

        public Playlist(RecommenderMode songRecMode, List<Song> lib)
        {
            _lib = lib;
            _songRecMode = songRecMode;
        }

        public void AddSong(Song s)
        {
            _list.Add(s);
        }

        public void Start()
        {
            Console.WriteLine("*Playlist started*");

            foreach (var s in _list)
            {
                s.Play();
            }

            Song recSong = null;
            if (_songRecMode == RecommenderMode.Random)
            {
                int randomIndex = new Random().Next(_lib.Count - 1);
                recSong = _lib[randomIndex];
            }
            else if (_songRecMode == RecommenderMode.Wildcard)
            {
                var myGenre = _lib.FindAll(s => s.Genre == _list[0].Genre);
                int randomIndex = new Random().Next(myGenre.Count - 1);
                recSong = myGenre[randomIndex];
            }
            else if (_songRecMode == RecommenderMode.KnownArtist)
            {
                throw new NotImplementedException("implement yourself");
            }

            Console.WriteLine("*Playlist finished*");
            recSong.Play();
        }
    }
}