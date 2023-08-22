namespace N28_HT2;

class Program
{
    static void Main()
    {
        ClonableList<StorageFile> originalList = new ClonableList<StorageFile>
        {
            new StorageFile(1, "file.txt", "Text file", 1024),
            new StorageFile(2, "image.jpg", "Image file", 2048),
            new StorageFile(3, "video.mp4", "Video file", 4096)
        };
        
        ClonableList<StorageFile> clonedList = originalList.Clone();
        
        originalList[0].Name = "updated_file.txt";
        
        
        Console.WriteLine("Original List: ");
        foreach (var file in originalList)
        {
            Console.WriteLine(file.Name);
        }
        
        
        Console.WriteLine("Cloned List: ");
        foreach (var file in clonedList)
        {
            Console.WriteLine(file.Name);
        }
        
    }
}
