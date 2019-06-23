using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EduAtmo.GUI
{
    public partial class ActiveTest : Form
    {
        public List<Bitmap> images = new List<Bitmap>();
        private Timer timetopass = new Timer();
        public ActiveTest()
        {
            InitializeComponent();
        }

        private void ActiveTest_Load(object sender, EventArgs e)
        {

        }

        public void PrepareForm(string sub)
        {
            SubjectNameLable.Text = sub;
        }

        public void ImportTask(EduAtmo.Elements.Task tsk)
        {
            Labellabel.Text = tsk.Name;
            string tasktext = DefinePictures(tsk.Text);
            TskTextLabel.Text = tasktext;
            TestIDLabel.Text = Convert.ToString(tsk.ID);

            if (tsk.Timer <= 0) TimeLabel.Text = "--:--";
            else TimeLabel.Text = $"{tsk.Timer/60}:{tsk.Timer%60}";

            SubjectNameLable.Text = Shell.subject;
            foreach (Bitmap img in images)
            {
                PictureBox pb = new PictureBox();
                pb.Image = img;
                
                pb.Location = new Point(5, TskTextLabel.Size.Height + 5);
                Size pbsize = new Size();
                pbsize.Width = panel2.Size.Width - 10;
                pbsize.Height = img.Height * (pbsize.Width/img.Width);
                pb.Size = pbsize;
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                panel2.Controls.Add(pb);
            }
        }

        private string DefinePictures(string task)
        {
            if (task.Contains("<pic>"))
            {
                int start, cut;
                start = task.IndexOf("<pic>");
                if (task.Contains("</pic>") == false) return task;
                cut = task.IndexOf("</pic>") + 6;
                string file = task.Substring(start, cut-start-6);
                task = task.Substring(0, start) + task.Substring(cut + 6);
                Bitmap img;
                if (File.Exists(file))
                {
                    img = new Bitmap(file);
                }
                else
                {
                    img = new Bitmap(Properties.Resources.No_Pic);
                }
                images.Add(img);
                DefinePictures(task);
            }
            return task;
        }

        private void InitTimer(int time)
        {

        }

        private void ActiveTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shell.Close();
        }
    }
}
