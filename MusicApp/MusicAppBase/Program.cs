namespace MusicApp
{
    public class Program
    {
        public static void Main()
        {
            // load DB of all songs
            var songDB = new List<Song>(SongDB.LoadSongDB());

            // Load preferences (from file or db, hard-coded for now)
            var recommenderSetting = RecommenderMode.Wildcard;

            // ..

            // Create playlist with a recommender setting
            var p = new Playlist(recommenderSetting, songDB);
            p.AddSong(new Song("Crazy what love can do", new Artist("David Guetta"), Genre.Pop));
            p.AddSong(new Song("As it was", new Artist("Harry Styles"), Genre.Pop));
            p.AddSong(new Song("Nemo", new Artist("Nightwish"), Genre.Metal));
            p.AddSong(new Song("Words", new Artist("Alesso"), Genre.Dance));
            p.AddSong(new Song("Snap", new Artist("Rosa Linn"), Genre.Rock));

            // Start playlist
            p.Start();
        }
    }
}