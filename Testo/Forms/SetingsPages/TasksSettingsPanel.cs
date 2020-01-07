using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Testo.Forms.SetingsPages
{
    public partial class TasksSettingsPanel : SetingsPanel
    {
        List<string> files = new List<string>();
        public TasksSettingsPanel()
        {
            InitializeComponent();
            string[] Subs = { };
            if (!Directory.Exists("Subjects")) Directory.CreateDirectory("Subjects");
            Subs = Directory.GetFiles("Subjects");
            foreach (string fil in Subs)
            {
                if (!(fil.EndsWith(".fos"))) continue;
                else
                {
                    files.Add((fil.Substring(0, fil.Length - ".fos".Length)).Split('\\')[1]);
                }
            }
            foreach (string fl in files)
            {
                SubjectsList.Items.Add(fl);
            }
        }

        private void TasksSettingsPanel_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SubjectsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < SubjectsList.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(55, 16, 105) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = SubjectsList.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, SubjectsList.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

        private void SubjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
