using System.Collections.Generic;

namespace QuickTeams.Models
{
    public class MsTeams
    {
        public class Team
        {
            public List<TeamsObject> value { get; set; }
        }

        public class TeamsObject
        {
            public string id { get; set; }
            public string displayName { get; set; }
            public string description { get; set; } = "";
            public bool isArchived { get;set; }
            public string folderId { get; set; } = "";
        }
    }
}