using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.Forms;
using QuizletWindows.Forms.Class;
using QuizletWindows.Forms.Library;
using QuizletWindows.Forms.Library.Objective;
using QuizletWindows.Forms.Statistics;
using QuizletWindows.Forms.User;
using QuizletWindows.ViewModels;
using QuizletWindows.ViewModels.User;
using System;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

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
            FirstLoad();
        }
        private void FirstLoad()
        {
            tsNameUser.Text = Program.UserName;
            tsTypeUser.Text = Program.TypeUser;
            MarkAttendance mark = new MarkAttendance();
            mark.UserId = Program.UserId;
            bool canMark =  AchivementApi.Instance.MarkAttendance(mark);
            if (canMark)
            {
                Notification.ShowNotification("Welcome my friend, a new day :)))");   
            }
        }
        public void SetNameAndTypeUser(string name, string type)
        {
            tsNameUser.Text = name;
            tsTypeUser.Text = type;
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


        public Form ShowForm(Type tForm)
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
                else if(tForm==typeof(FrmJoiningClassDetail))
                {
                    f = new FrmJoiningClassDetail();
                }
                else if(tForm==typeof(FrmStatisticsDisplay))
                {
                    f = new FrmStatisticsDisplay();
                }
                else if(tForm==typeof(FrmAchievement))
                {
                    f = new FrmAchievement();
                }
                else
                {
                    f = new FrmLogin();
                }
                f.MdiParent = this;
                f.Show();
                return f;
            }
            return null;
            
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

        private void btnBarLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearUser();
            CloseAllChildrenForm();
            FrmLogin fLogin = new FrmLogin();
            if(fLogin.ShowDialog() == DialogResult.OK)
            {
                FirstLoad();
            }
        }
        private void ClearUser()
        {
            tsNameUser.Text = "";
            tsTypeUser.Text = "";
        }

        private void btnBarStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            ShowForm(typeof(FrmStatisticsDisplay));
        }

        private void btnBarAchievement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllChildrenForm();
            ShowForm(typeof(FrmAchievement));
        }

        private async void btnBarUserInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserViewModel user = await UserApi.Instance.GetProfile(Program.UserId);
            FrmProfile profile = new FrmProfile();
            profile.SetUserViewModel(user);
            profile.ShowDialog();
        }

        private void btnBarChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChangePass frmChangePass = new FrmChangePass();
            frmChangePass.ShowDialog();
        }
    }
}
