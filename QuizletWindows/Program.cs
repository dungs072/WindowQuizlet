using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraWaitForm;
using QuizletWindows.API;
using QuizletWindows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;


namespace QuizletWindows
{
    

    internal static class Program
    {
        public static int UserId;
        public static string UserName;
        public static string TypeUser;
        public static FrmMainMenu mainMenu;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetUp();
            FrmLogin fLogin = new FrmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                mainMenu = new FrmMainMenu();
                Application.Run(mainMenu);
            }
            else
            {
                Application.Exit();
            }
        }
        static void SetUp()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:8001/");

            UserApi.Instance.SetHttpClient(httpClient);
            TerminologyApi.Instance.SetHttpClient(httpClient);
        }
    }
}
