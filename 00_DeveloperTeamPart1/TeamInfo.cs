using System;

namespace _00_DeveloperTeamPart1_Repository
{
    public class TeamInfo
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public bool HasAccessPluralsight { get; set; }

        public TeamInfo() { }

        public TeamInfo(string id, string lastname, bool hasAccessPluralsight)
        {
            Id = id;
            LastName = lastname;
            HasAccessPluralsight = hasAccessPluralsight;
        }
    }
}
