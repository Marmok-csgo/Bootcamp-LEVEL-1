namespace N26_T1;

class Program
{
    static void Main()
    {
        List<Meeting> meetingList = new List<Meeting>
        {
            new Meeting("Tournament", TimeSpan.FromHours(5)),
            new Meeting("Conference", TimeSpan.FromHours(2)),
            new Meeting("Lecture", TimeSpan.FromHours(3)),
            new Meeting("Party", TimeSpan.FromHours(5))
        };
        
        var totalDuration = TimeSpan.Zero;

        foreach (var meeting in meetingList)
        {
            Console.WriteLine($"Meeting: {meeting.Name}, Duration: {meeting.Duration}");
            totalDuration += meeting.Duration;
        }
        
        Console.WriteLine($"Total Duration: {totalDuration}");
        
        Meeting combinedMeeting = meetingList[0] + meetingList[1];
        Console.WriteLine($"Combined Meeting: {combinedMeeting.Name}, Duration: {combinedMeeting.Duration}");

    }
}
