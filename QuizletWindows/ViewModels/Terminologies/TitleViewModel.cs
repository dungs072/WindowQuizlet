using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizletWindows.ViewModels.Terminologies
{
    public class TitleViewModel
    {
        public int TitleId { get; set; } = 0;
        [Display(Name = "Title name")]
        [Required(ErrorMessage = "Title name is required")]
        public string TitleName { get; set; } = "";
        public string Describe { get; set; } = "";
        public int UserId { get; set; } = 0;
    }
}
