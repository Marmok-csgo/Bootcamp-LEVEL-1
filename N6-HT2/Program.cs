using System;
using System.Collections.Generic;
using System.Linq;

class Event
{
    public string Name { get; set; }
    public DateTime Time { get; set; }
}

class Program
{
    static List<Event> events = new List<Event>();

    static void Main(string[] args)
    {
        Console.WriteLine("Event Scheduler - Hodisalarni Rejalashtirish dasturi");

        string[] eventNames = new string[10]
        {
            "Ukam tug'ilgan kun",
            "Bootcamp boshlangan kun",
            "Bootcamp tugaydigan kun",
            "Karantin tugagan kun",
            "Yangi kompyuter olingan kun",
            "18 Yoshga to'ladigan kunim",
            "Alisher Navoiy vafot etgan kun",
            "DOTA o'ynashni o'rgangan kunim",
            "TO'YIM",
            "Foundation tugagan kun"
        };

        DateTime[] eventDates = new DateTime[10]
        {
            new DateTime(2010, 5, 15),
            new DateTime(2023, 7, 10),
            new DateTime(2024, 1, 15),
            new DateTime(2019, 6, 17),
            new DateTime(2023, 1, 4),
            new DateTime(2026, 8, 14),
            new DateTime(1503, 4, 5),
            new DateTime(2014, 3, 12),
            new DateTime(2028, 5, 14),
            new DateTime(2023, 5, 13)
        };

        for (int i = 0; i < eventNames.Length; i++)
        {
            events.Add(new Event { Name = eventNames[i], Time = eventDates[i] });
        }

        while (true)
        {
            Console.WriteLine("\nQuyidagilardan bittasini tanlang:");
            Console.WriteLine("1. Eventlarni saralash nomi bo'yicha");
            Console.WriteLine("2. Eventni nomi bo'yicha topish");
            Console.WriteLine("3. Eventni vaqti bo'yicha topish");
            Console.WriteLine("4. Kelayotgan eventlarni ko'rsatish");
            Console.WriteLine("5. O'tib ketgan eventlarni ko'rsatish");
            Console.WriteLine("6. Kelayotgan eventlarni ko'rsatish (yaqinligi bo'yicha)");
            Console.WriteLine("7. O'tib ketgan eventlarni ko'rsatish (yaqinligi bo'yicha)");
            Console.WriteLine("8. Dasturni yopish");

            Console.Write("Tanlangan komanda: ");
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    SortEventsByName();
                    break;
                case 2:
                    FindEventByName();
                    break;
                case 3:
                    FindEventByTime();
                    break;
                case 4:
                    ShowUpcomingEvents();
                    break;
                case 5:
                    ShowPastEvents();
                    break;
                case 6:
                    ShowUpcomingEventsByProximity();
                    break;
                case 7:
                    ShowPastEventsByProximity();
                    break;
                case 8:
                    Console.WriteLine("Dastur tugadi.");
                    return;
                default:
                    Console.WriteLine("Noto'g'ri komanda kiritildi.");
                    break;
            }
        }
    }

    static void SortEventsByName()
    {
        events = events.OrderBy(e => e.Name).ToList();
        Console.WriteLine("Eventlar nomi bo'yicha saralandi.");
        PrintEvents();
    }

    static void FindEventByName()
    {
        Console.Write("Qidiriladigan event nomini kiriting: ");
        string eventName = Console.ReadLine();

        Event foundEvent = events.FirstOrDefault(e => e.Name.Equals(eventName, StringComparison.OrdinalIgnoreCase));

        if (foundEvent != null)
        {
            Console.WriteLine("Quyidagi event topildi:");
            Console.WriteLine($"Nomi: {foundEvent.Name}");
            Console.WriteLine($"Vaqti: {foundEvent.Time}");
        }
        else
        {
            Console.WriteLine("Event topilmadi.");
        }
    }

    static void FindEventByTime()
    {
        Console.Write("Qidiriladigan event vaqtni kiriting (yyyy-MM-dd HH:mm): ");
        DateTime eventTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);

        Event foundEvent = events.FirstOrDefault(e => e.Time == eventTime);

        if (foundEvent != null)
        {
            Console.WriteLine("Quyidagi event topildi:");
            Console.WriteLine($"Nomi: {foundEvent.Name}");
            Console.WriteLine($"Vaqti: {foundEvent.Time}");
        }
        else
        {
            Console.WriteLine("Event topilmadi.");
        }
    }

    static void ShowUpcomingEvents()
    {
        DateTime now = DateTime.Now;

        var upcomingEvents = events.Where(e => e.Time > now).OrderBy(e => e.Time);

        Console.WriteLine("Kelayotgan eventlar:");
        PrintEvents(upcomingEvents);
    }

    static void ShowPastEvents()
    {
        DateTime now = DateTime.Now;

        var pastEvents = events.Where(e => e.Time < now).OrderByDescending(e => e.Time);

        Console.WriteLine("O'tib ketgan eventlar:");
        PrintEvents(pastEvents);
    }

    static void ShowUpcomingEventsByProximity()
    {
        Console.Write("Eventlarni qaysi kungacha (sana vaqtiga qarab) ko'rsatishni istaysiz? (sana formati: yyyy-MM-dd): ");
        DateTime date = DateTime.Now;

        var upcomingEvents = events.Where(e => e.Time.Date == date.Date).OrderBy(e => e.Time);

        Console.WriteLine($"Kun bo'yicha kelayotgan eventlar ({date.ToString("yyyy-MM-dd")}):");
        PrintEvents(upcomingEvents);
    }

    static void ShowPastEventsByProximity()
    {
        Console.Write("Eventlarni qaysi kungacha (sana vaqtiga qarab) ko'rsatishni istaysiz? (sana formati: yyyy-MM-dd): ");
        DateTime date = DateTime.Now;

        var pastEvents = events.Where(e => e.Time.Date == date.Date).OrderByDescending(e => e.Time);

        Console.WriteLine($"Kun bo'yicha o'tib ketgan eventlar ({date.ToString("yyyy-MM-dd")}):");
        PrintEvents(pastEvents);
    }

    static void PrintEvents(IEnumerable<Event> eventList = null)
    {
        if (eventList == null)
            eventList = events;

        foreach (var ev in eventList)
        {
            Console.WriteLine($"Nomi: {ev.Name}");
            Console.WriteLine($"Vaqti: {ev.Time}");
            Console.WriteLine();
        }
    }
}
