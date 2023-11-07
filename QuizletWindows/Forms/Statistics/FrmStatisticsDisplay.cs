using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuizletWindows.Forms.Statistics
{
    public partial class FrmStatisticsDisplay : DevExpress.XtraEditors.XtraForm
    {
        private List<LevelTerms> levelTerms;
        private AchieveStatistics achieveStatistics;
        public FrmStatisticsDisplay()
        {
            InitializeComponent();
        }

        private void FrmStatisticsDisplay_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadStatistics();
        }

        private void LoadChart()
        {
            levelTerms = AchivementApi.Instance.GetLevelTerm(Program.UserId);
            statisticChart.DataSource = levelTerms;
            Series series = statisticChart.Series[0];
            series.XValueMember = "LevelName";
            series.YValueMembers = "NumberTermsInLevel";
            series.LegendText = "Terminology";
        }
        private void LoadStatistics()
        {
            achieveStatistics = AchivementApi.Instance.GetAchieveStatistics(Program.UserId);
            txtNumberModules.Text = achieveStatistics.NumberModule.ToString();
            txtNumberTerms.Text = achieveStatistics.NumberTerms.ToString();
            txtNumberTitles.Text = achieveStatistics.NumberTitle.ToString();
            txtLongestDays.Text = achieveStatistics.LongestSquence.ToString();
            txtTotalClasses.Text = achieveStatistics.TotalClass.ToString();
        }

    }
}