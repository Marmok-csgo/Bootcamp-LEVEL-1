namespace AsyncReadWrute;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = @"D:\project\Bootcamp-LEVEL-1\AsyncReadWrute\news.txt";
         await WriteToCosoleAsync(filePath);
         
    }

    static async Task<string> ReadFileAsync(string filePath)
    {                
        string Result = null;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = await reader.ReadLineAsync())!= null)
            {
                Result += line;
            }
        }
        return Result; 
    }

    static async Task WriteToCosoleAsync(string filePath)
    {
        string result = await ReadFileAsync(filePath);
        Console.WriteLine(result);
    }
}