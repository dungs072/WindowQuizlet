using DevExpress.XtraEditors;
using QuizletWindows.Forms;
using QuizletWindows.Forms.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizletWindows
{
    public partial class FrmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            tsNameUser.Text = Program.UserName;
            tsTypeUser.Text = Program.TypeUser;
        }

        private void btnBarLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(typeof(FrmYourLibrary));
        }


        public void ShowForm(Type tForm)
        {
            Form frm = CheckExists(tForm);
            if (frm != null) frm.Activate();
            else
            {
                Form f;
                if (tForm == typeof(FrmYourLibrary))
                {
                    f = new FrmYourLibrary();
                }
                else if(tForm==typeof(FrmYourModules))
                {
                    f=new FrmYourModules();
                }
                else if(tForm==typeof(FrmTerms))
                {
                    f = new FrmTerms();
                }
                else
                {
                    f = new FrmLogin();
                }
                f.MdiParent = this;
                f.Show();
            }
            
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnBarCreateNewTitle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(var form in this.MdiChildren)
            {
                form.Close();
            }
            FrmAddTitle frmAddTitle = new FrmAddTitle();
            frmAddTitle.Show();
        }
    }
}
