using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuizletWindows.Forms.Controls
{
    public partial class BadgeControl : DevExpress.XtraEditors.XtraUserControl
    {
        public BadgeControl()
        {
            InitializeComponent();
        }
        public void SetNameBadge(string name)
        {
            txtNameBox.Text = name;
        }
        public void SetCheckBox(bool state)
        {
            checkBox.Checked = state;
        }
        public void SetDateText(string text)
        {
            txtDateAchievement.Text = text;
        }
        public void SetImage(string image)
        {
            /txtImage.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead("https://firebasestorage.googleapis.com/v0/b/quizlet-c9cab.appspot.com/o/main%2FFlashCard.png?alt=media&token=9a3befe7-f2f5-4eb2-9f6d-69e5b831d52f"));
        }
    }
}
