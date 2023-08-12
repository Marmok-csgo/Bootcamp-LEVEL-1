namespace LinqMethods;

class Program
{
    static void Main()
    {
        List<Team> teams = new List<Team>()
        {
            new Team() { Id = 1, ClubName = "Barselona", City = "Ispaniya" },
            new Team() { Id = 2, ClubName = "Real Madrid", City = "Ispaniya" },
            new Team() { Id = 3, ClubName = "Manchester City", City = "Angliya" },
            new Team() { Id = 4, ClubName = "Bavariya", City = "Germaniya" },
            new Team() { Id = 5, ClubName = "Nasaf", City = "Uzbekistan" },
            new Team() { Id = 6, ClubName = "Zenit", City = "Rossiya" },
        };

        List<Player> players = new List<Player>()
        {
            new Player() { Id = 1, Name = "Messi", TeamId = 1, Level = 94},
            new Player() { Id = 2, Name = "Ronaldu", TeamId = 2, Level = 92},
            new Player() { Id = 3, Name = "Lewandowski", TeamId = 4, Level = 89},
            new Player() { Id = 4, Name = "De Bryune", TeamId = 3, Level = 88},
            new Player() { Id = 5, Name = "Neymar", TeamId = 1, Level = 90},
            new Player() { Id = 6, Name = "Suarez", TeamId = 1, Level = 88},
            new Player() { Id = 7, Name = "Haaland", TeamId = 3, Level = 86},
            new Player() { Id = 8, Name = "Myuller", TeamId = 4, Level = 84},
            new Player() { Id = 9, Name = "Bale", TeamId = 2, Level = 82},
            new Player() { Id = 10, Name = "Ismoilov", TeamId = 5, Level = 70},
            new Player() { Id = 11, Name = "Shomurodov", TeamId = 2, Level = 78},
            new Player() { Id = 12, Name = "Cherishev", TeamId = 2, Level = 78},
            new Player() { Id = 13, Name = "Vafoyev", TeamId = 2, Level = 78},
            new Player() { Id = 14, Name = "Denisov", TeamId = 2, Level = 78},
            new Player() { Id = 15, Name = "Latipov", TeamId = 2, Level = 78},
            new Player() { Id = 16, Name = "Jesus", TeamId = 2, Level = 78},
            new Player() { Id = 17, Name = "Genynrikh", TeamId = 2, Level = 78},
            new Player() { Id = 18, Name = "Modric", TeamId = 2, Level = 78},
            new Player() { Id = 19, Name = "Modric", TeamId = 2, Level = 78},
            new Player() { Id = 20, Name = "Modric", TeamId = 2, Level = 78},
            new Player() { Id = 21, Name = "Modric", TeamId = 2, Level = 78},
            new Player() { Id = 22, Name = "Modric", TeamId = 2, Level = 78},
        };

                                //Select
        // var querySelect = from player in players
        //     select new { player.Id, player.Name, player.Level };
        //
        // foreach (var item in querySelect)
        // {
        //     Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, level: {item.Level}");
        // }

                                //Where

        // var queryWhere = from player in players
        //     where player.TeamId == 2
        //     select new { player.TeamId, player.Name };
        //
        // foreach (var item in queryWhere)
        // {
        //     Console.WriteLine($"Name: {item.Name}, TeamId: {item.TeamId}");
        // }


                                //OrderBy: 

        // var queryOrderBy = from player in players
        //     orderby player.Level ascending
        //     select new { player.Name, player.Level };
        //
        // foreach (var item in queryOrderBy)
        // {
        //     Console.WriteLine($"Name: {item.Name}, Level: {item.Level}");
        // }

                                //OrderByDescending: 

        // var queryOrderByDescending = from player in players
        //     orderby player.Level descending 
        //     select new { player.Name, player.Level };
        //
        // foreach (var item in queryOrderByDescending)
        // {
        //     Console.WriteLine($"Name: {item.Name}, Level: {item.Level}");
        // }
        
                                //ThenBy: 

        // var queryThenBy = from player in players
        //     orderby player.Name ascending, player.Id descending
        //     select new { player.Name, player.Id };
        //
        // foreach (var item in queryThenBy)
        // {
        //     Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
        // }
        
        
                                //ThenByDescending: 
                                //Join: 

        // var queryThenByJoin = from player in players
        //     join team in teams
        //         on player.TeamId equals team.Id
        //     select new { team.ClubName, player.Name };
        //
        // foreach (var item in queryThenByJoin)
        // {
        //     Console.WriteLine($"Club: {item.ClubName}, player: {item.Name}");
        // }


                                    //Aggregate: 

        // int totalLevel = players.Aggregate(0, (sum, player) => sum + player.Level);
        //
        // Console.WriteLine($"Total PLayer Level: {totalLevel}");

                                    //GroupBy: 

        // var queryGroupBy = players.GroupBy(player => player.TeamId);
        // foreach (var group in queryGroupBy)
        // {
        //     Console.WriteLine($"Team ID: {group.Key}");
        //
        //     foreach (var item in group)
        //     {
        //         Console.WriteLine($"Player: {item.Name}, Level: {item.Level}");
        //     }
        // }        



                                        //ToLookup:

        // ILookup<int, Player> queryLookup = players.ToLookup(player => player.TeamId);
        //
        // int TeamIdLookUp = 2;
        //
        // foreach (var item in queryLookup[TeamIdLookUp])
        // {
        //     Console.WriteLine($"TeamId: {TeamIdLookUp}, Player: {item.Name}");
        // }

                                        //GroupJoin: 
        
        // var queryGroupJoin = from team in teams
        //     join player in players on team.Id equals player.TeamId into teamPlayers
        //     select new
        //     {
        //         TeamName = team.ClubName,
        //         players = teamPlayers
        //     };
        //
        // foreach (var teamGroup in queryGroupJoin)
        // {
        //     Console.WriteLine($"Team: {teamGroup.TeamName}");
        //     foreach (var item in teamGroup.players)
        //     {
        //         Console.WriteLine($"Player: {item.Name}, Level: {item.Level}");
        //     }
        // }
        
        
        //Reverse:

        players.Reverse();

        foreach (var item in players)
        {
            Console.WriteLine($"{item.Name}, {item.Level}");
        }
        

        //All:

        //Any: 

        //Contains: 

        //Distinct: 

        //Except: 

        //Union: 

        //Intersect: 

        //Count: 

        //Sum:

        //Average: 

        //Min:

        //Max:

        //Take:

        //Skip: 

        //TakeWhile: 

        //SkipWhile: 

        //Concat: 

        //Zip: 

        //First: 

        //FirstOrDefault: 

        //Single: 

        //SingleOrDefault: 

        //ElementAt: 

        //ElementAtOrDefault: 

        //Last: 

        //LastOrDefault:
    }
}