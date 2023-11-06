using DevExpress.XtraEditors;
using QuizletWindows.Forms;
using QuizletWindows.Forms.Class;
using QuizletWindows.Forms.Library;
using QuizletWindows.Forms.Library.Objective;
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
            CloseAllChildrenForm();
            ShowForm(typeof(FrmYourLibrary));
        }
        private void btnBarYourOwnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            ShowForm(typeof(FrmYourOwnClass));
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
                else if(tForm==typeof(FrmObjectivePractice))
                {
                    f = new FrmObjectivePractice();
                }
                else if(tForm==typeof(FrmYourOwnClass))
                {
                    f = new FrmYourOwnClass();
                }
                else if(tForm==typeof(FrmRegisterJoiningClass))
                {
                    f = new FrmRegisterJoiningClass();
                }
                else if(tForm==typeof(FrmClassDetail))
                {
                    f = new FrmClassDetail();
                }
                else if(tForm==typeof(FrmJoiningClass))
                {
                    f = new FrmJoiningClass();
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
        public void CloseAllChildrenForm()
        {
            foreach (var form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void btnBarCreateNewTitle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            FrmAddTitle frmAddTitle = new FrmAddTitle();
            frmAddTitle.Show();
        }

        private void btnBarCreateNewClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            FrmAddYourOwnClass frmAddClass = new FrmAddYourOwnClass();
            frmAddClass.Show();
        }

        private void btnBarJoiningClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            ShowForm(typeof(FrmJoiningClass));
        }
    }
}
