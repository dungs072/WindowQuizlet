using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizletWindows.ViewModels.Terminologies
{
    public class TermViewModel
    {
        public int TermId { get; set; }
        [Display(Name = "Term name")]
        [Required(ErrorMessage = "Terminology name is required")]
        public string TermName { get; set; }
        [Display(Name = "Term Explanation")]
        [Required(ErrorMessage = "Explanation is required")]
        public string Explaination { get; set; }
        public string Image { get; set; }
        public int LearningModuleId { get; set; }
        public int LevelId { get; set; } = 1;
        public LearningModuleViewModel2 LearningModule { get; set; }
    }

    public class ResultQuestion
    {
        public int TermId { get; set; }
        public bool IsRightAnswer { get; set; }
    }

    public class ResultTest
    {
        public string TermName { get; set; }
        public string Explanation { get; set; }
    }
}
