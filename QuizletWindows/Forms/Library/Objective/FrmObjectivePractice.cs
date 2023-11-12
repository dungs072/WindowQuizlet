using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library.Objective
{
    public partial class FrmObjectivePractice : DevExpress.XtraEditors.XtraForm
    {
        private List<ObjectivePack> objectivePacks;
        private List<ResultTest> resultTestList;
        private int currentQuestionIndex = 0;
        public static int LearningModuleId { get; set; }
        public FrmObjectivePractice()
        {
            InitializeComponent();
        }

        private void FrmObjectivePractice_Load(object sender, EventArgs e)
        {
            objectivePacks = TerminologyApi.Instance.GetObjectivePacks(LearningModuleId);
            resultTestList = new List<ResultTest>();    
            LoadNewQuestion(currentQuestionIndex);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = Math.Max(currentQuestionIndex - 1, 0);
            ResetColorRadioButton();
            LoadNewQuestion(currentQuestionIndex);
        }

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            ResultQuestion question = new ResultQuestion();
            question.TermId = objectivePacks[currentQuestionIndex].TermId;
            
            if (radioA.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer=="A")
                {
                    radioA.ForeColor = Color.Green;
                    question.IsRightAnswer = true;
                }
                else
                {
                    radioA.ForeColor = Color.Red;
                    question.IsRightAnswer = false;
                    resultTestList.Add(new ResultTest() { TermName = objectivePacks[currentQuestionIndex].Question, Explanation = objectivePacks[currentQuestionIndex].GetAnswer });
                }
                radioA.Checked = false;
            }
            else if (radioB.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer == "B")
                {
                    radioB.ForeColor = Color.Green;
                    question.IsRightAnswer = true;
                }
                else
                {
                    radioB.ForeColor = Color.Red;
                    question.IsRightAnswer = false;
                    resultTestList.Add(new ResultTest() { TermName = objectivePacks[currentQuestionIndex].Question, Explanation = objectivePacks[currentQuestionIndex].GetAnswer });
                }
                radioB.Checked = false;
            }
            else if(radioC.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer == "C")
                {
                    radioC.ForeColor = Color.Green;
                    question.IsRightAnswer = true;
                }
                else
                {
                    radioC.ForeColor = Color.Red;
                    question.IsRightAnswer = false;
                    resultTestList.Add(new ResultTest() { TermName = objectivePacks[currentQuestionIndex].Question, Explanation = objectivePacks[currentQuestionIndex].GetAnswer });
                }
                radioC.Checked = false;
            }
            else
            {
                if (objectivePacks[currentQuestionIndex].Answer == "D")
                {
                    radioD.ForeColor = Color.Green;
                    question.IsRightAnswer = true;
                }
                else
                {
                    radioD.ForeColor = Color.Red;
                    question.IsRightAnswer = false;
                    resultTestList.Add(new ResultTest() { TermName = objectivePacks[currentQuestionIndex].Question, Explanation = objectivePacks[currentQuestionIndex].GetAnswer });
                }
                radioD.Checked = false;
            }
            var state = await TerminologyApi.Instance.UpdateTermTest(question);
        }

        private void LoadNewQuestion(int currentQuestion)
        {
            QuestionName.Text = objectivePacks[currentQuestion].Question.Trim();
            radioA.Text = objectivePacks[currentQuestionIndex].ChoiceA.Trim();
            radioB.Text = objectivePacks[currentQuestionIndex].ChoiceB.Trim();
            radioC.Text = objectivePacks[currentQuestionIndex].ChoiceC.Trim();
            radioD.Text = objectivePacks[currentQuestionIndex].ChoiceD.Trim();
            QuestionName.Location = new Point((panel1.Width - QuestionName.Width) / 2, (panel1.Height - QuestionName.Height) / 2);
        }

        private void btnBarExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = Notification.ShowDeleteWarning("Do you want to exit ?");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
            
        }
        private void ResetColorRadioButton()
        {
            radioA.ForeColor = Color.Black; radioB.ForeColor = Color.Black;
            radioC.ForeColor = Color.Black; radioD.ForeColor = Color.Black;
        }

        private void btnNextTo_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = Math.Min(currentQuestionIndex + 1, objectivePacks.Count);
            if(currentQuestionIndex==objectivePacks.Count)
            {
                FrmResultTest frmResultTest = new FrmResultTest();
                frmResultTest.SetResults(resultTestList);
                frmResultTest.SetPractice(this);
                frmResultTest.SetResultText($"{resultTestList.Count}/{objectivePacks.Count} answers are wrong");
                frmResultTest.ShowDialog();
            }
            else
            {
                ResetColorRadioButton();
                LoadNewQuestion(currentQuestionIndex);
            }
            
        }
    }
}