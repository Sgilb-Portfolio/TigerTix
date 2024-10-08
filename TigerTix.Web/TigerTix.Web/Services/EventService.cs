using System.Collections.Generic;
using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{
    public class EventService : IEventService
    {
        private readonly List<Event> _events = new List<Event>
        {
            new Event { Sport = "Football", Opponent = "Georgia", Date = new DateTime(2024, 8, 24), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "App State", Date = new DateTime(2024, 9, 7), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "NC State", Date = new DateTime(2024, 9, 21), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Stanford", Date = new DateTime(2024, 9, 28), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "FSU", Date = new DateTime(2024, 10, 5), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Wake Forest", Date = new DateTime(2024, 10, 12), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Virginia", Date = new DateTime(2024, 10, 19), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Louisville", Date = new DateTime(2024, 11, 2), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Virginia Tech", Date = new DateTime(2024, 11, 9), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Pittsburgh", Date = new DateTime(2024, 11, 16), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "Citadel", Date = new DateTime(2024, 11, 23), Location = "TBD"},
            new Event { Sport = "Football", Opponent = "South Carolina", Date = new DateTime(2024, 11, 30), Location = "TBD"},

            new Event { Sport = "Baseball", Opponent = "Georgia Tech", Date = new DateTime(2024, 5, 3), Location = "Home"},
            new Event { Sport = "Baseball", Opponent = "Georgia Tech", Date = new DateTime(2024, 5, 4), Location = "Home"},
            new Event { Sport = "Baseball", Opponent = "Georgia Tech", Date = new DateTime(2024, 5, 5), Location = "Home"},
            new Event { Sport = "Baseball", Opponent = "Charlotte", Date = new DateTime(2024, 5, 7), Location = "Away"},
            new Event { Sport = "Baseball", Opponent = "Wake Forest", Date = new DateTime(2024, 5, 10), Location = "Away"},
            new Event { Sport = "Baseball", Opponent = "Wake Forest", Date = new DateTime(2024, 5, 11), Location = "Away"},
            new Event { Sport = "Baseball", Opponent = "Wake Forest", Date = new DateTime(2024, 5, 12), Location = "Away"},
            new Event { Sport = "Baseball", Opponent = "Coastal Carolina", Date = new DateTime(2024, 5, 14), Location = "Away"},
            new Event { Sport = "Baseball", Opponent = "Boston College", Date = new DateTime(2024, 5, 16), Location = "Home"},
            new Event { Sport = "Baseball", Opponent = "Boston College", Date = new DateTime(2024, 5, 17), Location = "Home"},
            new Event { Sport = "Baseball", Opponent = "Boston College", Date = new DateTime(2024, 5, 18), Location = "Home"},

            new Event { Sport = "Soccer", Opponent = "Coker", Date = new DateTime(2024, 8, 12), Location = "Home"},
            new Event { Sport = "Soccer", Opponent = "Furman", Date = new DateTime(2024, 8, 15), Location = "Home"},
            new Event { Sport = "Soccer", Opponent = "Georgia State", Date = new DateTime(2024, 8, 19), Location = "Away"},
            new Event { Sport = "Soccer", Opponent = "UCF", Date = new DateTime(2024, 8, 24), Location = "Home"},
            new Event { Sport = "Soccer", Opponent = "UNC Wilmington", Date = new DateTime(2024, 8, 28), Location = "Home"},
            new Event { Sport = "Soccer", Opponent = "South Carolina", Date = new DateTime(2024, 9, 1), Location = "Home"},
        };

        public int Create(Event model)
        {
            // Add the event to the list and return its ID
            // This is a simple example and doesn't provide a real ID
            _events.Add(model);
            return _events.Count;
        }

        public Event Get(int id)
        {
            // Retrieve the event from the list
            // This is a simple example and doesn't handle cases where the ID is invalid
            return _events[id - 1];
        }
        public IEnumerable<Event> GetAll()
        {
            return _events;
        }

    }


}
