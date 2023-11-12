using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizletWindows.ViewModels
{
    public class AchieveStatistics
    {
        public int NumberTitle { get; set; }
        public int NumberModule { get; set; }
        public int NumberTerms { get; set; }

        public int LongestSquence { get; set; }

        public int TotalClass { get; set; }

    }
    public class Badge
    {
        public string NameBadge { get; set; }
        public bool IsAchieved { get; set; }
        public string DateAchieved { get; set; }
        public string Image { get; set; }
    }
    public class LevelTerms
    {
        public string LevelName { get; set; }
        public int NumberTermsInLevel { get; set; } = 0;
    }
    public class UserAchivement
    {
        public List<LevelTerms> LevelTerms { get; set; }
        public List<string> SequenceDates { get; set; }
        public List<Badge> badges { get; set; }
        public AchieveStatistics AchieveStatistics { get; set; }

    }
    public class MarkAttendance
    {
        public int UserId { get; set; }
    }
}
