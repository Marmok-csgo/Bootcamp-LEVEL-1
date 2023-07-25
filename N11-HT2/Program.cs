namespace N11_HT2;

class Program
{
    static void Main(string[] args)
    {
        var music1 = new Track("I can Fly", "XCHO");
        var music2 = new Track("Moonlight", "XXXtentasion");
        var music3 = new Track("детство", "Rauf & Faik");

        var musicPlayer = new MusicPlayer();
        musicPlayer.MP3List.Add(music1);
        musicPlayer.MP3List.Add(music2);
        musicPlayer.MP3List.Add(music3);

        musicPlayer.Play();

        while (true)
        {
            Console.Write("Choose a command (next - n, previous - p, pause - pause, play - play, exit - exit): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "n" or "next":
                    musicPlayer.Next();
                    break;

                case "p" or "previous":
                    musicPlayer.Previous();
                    break;

                case "pause":
                    musicPlayer.Pause();
                    break;

                case "play":
                    musicPlayer.Play();
                    break;

                case "exit":
                    return;
            }
        }
    }
}