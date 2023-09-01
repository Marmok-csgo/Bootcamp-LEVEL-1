namespace N32_T4;

public abstract class MusicService
{
    public abstract void SwitchNext();
    public abstract void SwitchPrevious();
    public abstract void DisplayCurrentSong();
    public abstract void Add(string name, string singerName);
}