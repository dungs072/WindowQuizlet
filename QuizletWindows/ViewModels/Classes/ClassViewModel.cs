using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace QuizletWindows.ViewModels.Classes
{
    public class ClassViewModel
    {
        public int ClassId { get; set; }
        [Display(Name = "ClassName")]
        [Required(ErrorMessage = "Class name is required")]
        public string ClassName { get; set; }
        public string Describe { get; set; }
        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "Created date is required")]
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }

        public int NumberParticipants { get; set; } = 0;
        public int NumberLearningModules { get; set; } = 0;

        public string CastFormatCreatedDate { get { return CreatedDate.ToString("dd/MM/yyyy"); } }
    }
}
