using DevExpress.XtraEditors;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            try
            {
                using (var webClient = new WebClient())
                {
                    var stream = webClient.OpenRead(image);

                    if (stream != null)
                    {
                        // Load SVG using SvgDocument
                        var svgDocument = SvgDocument.Open<SvgDocument>(stream);

                        // Render SVG to a Bitmap
                        var bitmap = svgDocument.Draw();

                        txtImage.Image = bitmap;
                        // Close the stream
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }
    }
}
