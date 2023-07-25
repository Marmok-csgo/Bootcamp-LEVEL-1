namespace N11_HT2;

public class MusicPlayer
{
    public readonly List<Track> MP3List = new List<Track>();
    public int Track = 0;
    public bool IsPause = true;


    public void Previous()
    {
        if (Track > 0)
            Track--;
        else
            Track = MP3List.Count - 1;

        IsPause = true;
        Play();
    }



    public void Pause()
    {
        if (!IsPause)
        {
            Console.WriteLine($"\"Paused - {MP3List[Track].Author} - {MP3List[Track].Name}\"");
            IsPause = true;
        }
        else
        {
            Console.WriteLine("The music is paused!");
        }
    }

    public void Next()
    {
        if (Track == MP3List.Count - 1)
            Track = 0;
        else
            Track++;

        IsPause = true;
        Play();
    }

    public void Play()
    {
        if (IsPause)
        {
            Console.WriteLine($"\"Playing - {MP3List[Track].Author} - {MP3List[Track].Name}\"");
            IsPause = false;
        }
        else
        {
            Console.WriteLine("The music is playing");
        }
    }
}