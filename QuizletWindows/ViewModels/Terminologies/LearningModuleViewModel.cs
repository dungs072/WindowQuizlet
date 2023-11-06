using System.ComponentModel.DataAnnotations;

namespace QuizletWindows.ViewModels.Terminologies
{
    public class LearningModuleViewModel2
    {
        public int LearningModuleId { get; set; }
        [Display(Name = "Learning module name")]
        [Required(ErrorMessage = "Learning module name is required")]
        public string LearningModuleName { get; set; }
        public string Describe { get; set; }
        public int TitleId { get; set; }

        public TitleViewModel TitleView { get; set; }
    }
    public class LearningModuleViewModel
    {
        public int LearningModuleId { get; set; }
        public string LearningModuleName { get; set; }
        public string Describe { get; set; }
        public int TitleId { get; set; }
        public bool IsChoose { get; set; }
    }
}
