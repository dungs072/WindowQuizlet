using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraScheduler;
using QuizletWindows.API;
using QuizletWindows.Forms.Controls;
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

namespace QuizletWindows.Forms.Statistics
{
    public partial class FrmAchievement : DevExpress.XtraEditors.XtraForm
    {
        private List<string> sequenceDates;
        private List<Badge> badges;
        public FrmAchievement()
        {
            InitializeComponent();
        }
        private void FrmAchievement_Load(object sender, EventArgs e)
        {
            sequenceDates = AchivementApi.Instance.GetSequenceDates(Program.UserId);
            badges = AchivementApi.Instance.GetBadges(Program.UserId);
            LoadBadgeToPanel();
        }
        private void LoadBadgeToPanel()
        {
            int count = 0;
            badges = badges.OrderBy(a => a.NameBadge.Split(',')[1]).ToList();
           
            foreach(var badge in badges) 
            {
                count++;
                if(count==badgePanel.ColumnCount)
                {
                    RowStyle newRowStyle = new RowStyle(SizeType.Absolute,233);
                    badgePanel.RowStyles.Add(newRowStyle);
                }
                BadgeControl badgeControl = new BadgeControl();

                badge.NameBadge = badge.NameBadge.Split(',')[0];
                badgeControl.SetNameBadge(badge.NameBadge);
                badgeControl.SetCheckBox(badge.IsAchieved);
                badgeControl.SetImage(badge.Image);
                badgeControl.SetDateText(badge.DateAchieved);
                badgeControl.Dock = DockStyle.Fill;
                badgePanel.AddControl(badgeControl);
                
            }
        }


        private void dateNavigator1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            
            if(sequenceDates.Contains(e.Date.ToString("yyyy-MM-dd")))
            {
                e.Style.BackColor = Color.Yellow;
                e.Style.ForeColor = Color.Black;
            }
        }

        
    }
}