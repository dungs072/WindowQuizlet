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
        private int currentQuestionIndex = 0;
        public static int LearningModuleId { get; set; }
        public FrmObjectivePractice()
        {
            InitializeComponent();
        }

        private void FrmObjectivePractice_Load(object sender, EventArgs e)
        {
            objectivePacks = TerminologyApi.Instance.GetObjectivePacks(LearningModuleId);
           
            LoadNewQuestion(currentQuestionIndex);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = Math.Max(currentQuestionIndex - 1, 0);
            ResetColorRadioButton();
            LoadNewQuestion(currentQuestionIndex);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (radioA.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer=="A")
                {
                    radioA.ForeColor = Color.Green;
                }
                else
                {
                    radioA.ForeColor = Color.Red;
                }
                radioA.Checked = false;
            }
            else if (radioB.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer == "B")
                {
                    radioB.ForeColor = Color.Green;
                }
                else
                {
                    radioB.ForeColor = Color.Red;
                }
                radioB.Checked = false;
            }
            else if(radioC.Checked)
            {
                if (objectivePacks[currentQuestionIndex].Answer == "C")
                {
                    radioC.ForeColor = Color.Green;
                }
                else
                {
                    radioC.ForeColor = Color.Red;
                }
                radioC.Checked = false;
            }
            else
            {
                if (objectivePacks[currentQuestionIndex].Answer == "D")
                {
                    radioD.ForeColor = Color.Green;
                }
                else
                {
                    radioD.ForeColor = Color.Red;
                }
                radioD.Checked = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = Math.Min(currentQuestionIndex + 1, objectivePacks.Count - 1);
            ResetColorRadioButton();
            LoadNewQuestion(currentQuestionIndex);
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
            this.Close();
            
        }
        private void ResetColorRadioButton()
        {
            radioA.ForeColor = Color.Black; radioB.ForeColor = Color.Black;
            radioC.ForeColor = Color.Black; radioD.ForeColor = Color.Black;
        }
    }
}