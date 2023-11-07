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
    }
}
