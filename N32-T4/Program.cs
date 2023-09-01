namespace N32_T4;

class Program
{
    static void Main(string[] args)
    {
        Music[] initialSongs =
        {
            new Music(1, "I Can Fly", "Xcho"),
            new Music(2, "Fireman", "Miyagi & Endshpil"),
            new Music(3, "Diamonds", "Rihanna"),
        };

        var musicService = new OptimizedMusicService(initialSongs);
        
        musicService.DisplayCurrentSong();
        musicService.SwitchNext();
        musicService.DisplayCurrentSong();
        musicService.SwitchPrevious();
        musicService.DisplayCurrentSong();
        
        musicService.Add("Moonlight", "xxxtentacion");
        musicService.SwitchNext();
        musicService.DisplayCurrentSong();
    }
}