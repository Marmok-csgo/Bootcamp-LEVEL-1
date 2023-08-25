namespace DownloadAndTranslate;

class Program
{
    static async Task Main()
    {
        var check = true;
        while (check)
        {
            Console.WriteLine($"1 - Download Video.\t2 - Translate text.");
            Console.Write("Enter your choice: ");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Enter URL: ");
                    string url = Console.ReadLine() ?? throw new InvalidOperationException();
                    await DownloadVideoAsync(url);
                    break;
                case "2":
                    Console.Write("Enter a text: ");
                    var text = Console.ReadLine();
                    await TranslateTextAsync(text ?? throw new InvalidOperationException());
                    break;
            }
        }
    }


    private static async Task DownloadVideoAsync(string videoUrl)
    {
        string filePath = @"D:\project\Bootcamp-LEVEL-1\DownloadAndTranslate\DownloadVIDEO\Video.mp4";
        Console.WriteLine("Downloading video...");
        using (var httpClient = new HttpClient())
        {
            var videoData = await 
                httpClient.GetByteArrayAsync(videoUrl);

            await File.WriteAllBytesAsync(filePath, videoData);
        }
    }


    private static async Task TranslateTextAsync(string text)
    {
        var api = $"https://translate.google.com/?hl=ru&sl=en&tl=uz&text={text}&op=translate";
        using (HttpClient client = new HttpClient())
        {
            var httpResponce = await client.GetAsync(api);
            if (httpResponce.IsSuccessStatusCode)
            {
                var result = await httpResponce.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }
    }
}