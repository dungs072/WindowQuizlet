using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms
{
    public static class Notification
    {
        public static void ShowNotification(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowDeleteWarning(string message)
        {
            DialogResult result = MessageBox.Show(message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }
    }
}
