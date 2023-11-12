namespace QuizletWindows.ViewModels.Terminologies
{
    public class ObjectivePack
    {
        public string Question { get; set; }
        public string ChoiceA { get; set; } = "";
        public string ChoiceB { get; set; } = "";
        public string ChoiceC { get; set; } = "";
        public string ChoiceD { get; set; } = "";
        public string Answer { get; set; }
        public int TermId { get; set; }
        public bool IsChooseRight { get; set; }
        public string GetAnswer
        {
            get
            {
                if (Answer == "A")
                {
                    return ChoiceA;
                }
                if (Answer == "B")
                {
                    return ChoiceB;
                }
                if (Answer == "C")
                {
                    return ChoiceC;
                }
                if (Answer == "D")
                {
                    return ChoiceD;
                }
                return "";
            }

        }
    }
}
