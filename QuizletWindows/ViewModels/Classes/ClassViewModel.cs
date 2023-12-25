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

    public class ClassLearningModuleViewModel
    {
        public int LearningModuleId { get; set; }
        public string LearningModuleName { get; set; }
        public string Describe { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberTerms { get; set; }
        public string CastFormatCreatedDate { get { return AddedDate.ToString("dd/MM/yyyy"); } }
    }
    public class UserParticipant
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gmail { get; set; }
        public DateTime RegisterDate { get; set; }
        public string CastFormatCreatedDate { get { return RegisterDate.ToString("dd/MM/yyyy"); } }
    }
    public class LearningModuleDetail
    {
        public int LearningModuleDetailId { get; set; }
        public int ClassId { get; set; }
        public int LearningModuleId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class RegisterDetailClass
    {
        public int RegisterDetailClassId { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsAccepted { get; set; }
    }

    public class Participant
    {
        public int RegisterDetailClassId { get; set; }
        public int ClassId { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsAccepted { get; set; }
        public int UserId { get; set; }
        public string Gmail { get; set; } = "";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string CastFormatCreatedDate { get { return RegisterDate.ToString("dd/MM/yyyy"); } }
    }

}
