namespace N32_T4;

public class OptimizedMusicService : MusicService
{
    private Music[] songs;
    private int currentIndex;


    public OptimizedMusicService(Music[] InitialSongs)
    {
        songs = InitialSongs;
        currentIndex = 0;
    }

    private void SwitchToFirst()
    {
        currentIndex = 0;
    }
    
    private void SwitchToLast()
    {
        currentIndex = songs.Length - 1;
    }

    private bool IsCurrentTheLastOne()
    {
        return currentIndex == songs.Length - 1;
    }
    
    private bool IsCurrentTheFirstOne()
    {
        return currentIndex == 0;
    }

    public override void SwitchNext()
    {
        if(!IsCurrentTheLastOne())
            currentIndex++;
    }

    public override void SwitchPrevious()
    {
        if (!IsCurrentTheFirstOne())
            currentIndex--;
    }

    public override void DisplayCurrentSong()
    {
        Console.WriteLine(MessageConstants.CurrentMusicMessage
            .Replace(MessageConstants.MusicNameToken, songs[currentIndex].Name)
            .Replace(MessageConstants.SingerNameToken, songs[currentIndex].SingerName));
    }

    public override void Add(string name, string singerName)
    {
        var newSong = new Music(songs.Length + 1, name, singerName);
        
        Array.Resize(ref songs, songs.Length + 1);
        songs[songs.Length - 1] = newSong;
    }
}