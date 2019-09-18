using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Testo
{
    public partial class EditSubject : Form
    {
        private SubjectClass subject = new SubjectClass();
        private string filename;
        private Mode md = Mode.SubjectEdit;
        private TaskClass runtime;
        private TreeNode selectednode;
        private bool usetimer = false;
        private bool limittasks = false;
        private bool activ;
        public bool UseTimer
        {
            get { return usetimer; }
            set
            {
                usetimer = value;
                refreshTimeUND();
            }
        }

        public bool LimitTasks
        {
            get { return limittasks; }
            set { limittasks = value;
                refreshTasksUND();
            }
        }

        private void refreshTasksUND()
        {
            if (LimitTasks) { limitasksUND.Enabled = true; limitasksUND.ForeColor = Color.Black; }
            else
            { limitasksUND.ForeColor = limitasksUND.BackColor; limitasksUND.Enabled = false;}
        }

        public Mode MODE
        {
            get { return md; }
            set { md = value;
                changeState();
            }
        }

        private void changeState()
        {
            if (MODE == Mode.SubjectEdit)
            {
                PropsPanel.Show();
                TaskInfoPanel.Hide();
            }
            if (MODE == Mode.TaskEdit)
            {
                PropsPanel.Hide();
                TaskInfoPanel.Show();
                if (selectednode.Text != "Добавить задание")
                {
                    foreach(TaskClass tsk in subject.Tasks)
                    {
                        if (selectednode.Text == tsk.Label) runtime = tsk;
                    }
                    HeaderTask.Text = runtime.Label;
                    TextTaskBox.Text = runtime.Text;
                    ImageList imglist = new ImageList();
                    ImageView.View = View.LargeIcon;
                    ImageView.Items.Clear();
                    int counter = 0;
                    foreach(KeyValuePair<Image,string> img in runtime.Images)
                    {
                        imglist.Images.Add(img.Key);
                        ListViewItem item = new ListViewItem();
                        item.Tag = img.Value;
                        if (img.Key.Tag != null) item.Text = (string)img.Key.Tag;
                        else item.Text = "В ресурсах";
                        item.ImageIndex = counter;
                        counter++;
                        ImageView.Items.Add(item);
                    }
                    imglist.ImageSize=new Size(80,80);
                    ImageView.LargeImageList = imglist;
                }
            }
        }


        private void refreshTimeUND()
        {
            TimeForTaskNUD.Enabled = usetimer;
        }

        public EditSubject()
        {
            InitializeComponent();
            UseTimer = false;
            TreeNode RootNode = TaskTree.Nodes[0];
            TaskTree.SelectedNode = RootNode;
        }

        private void SubjectNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SubjectFileNameTxtBox.Text == "" || SubjectNameTxtBox.Text.Contains(SubjectFileNameTxtBox.Text)) SubjectFileNameTxtBox.Text = SubjectNameTxtBox.Text;

        }

        private void SetupTimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UseTimer = !UseTimer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaskTree.ExpandAll();
        }

        private void TaskTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectednode = e.Node;
            if (selectednode.Text == "Параметры") MODE = Mode.SubjectEdit;
            else MODE = Mode.TaskEdit;
        }

        private void AnswersBtn_Click(object sender, EventArgs e)
        {
            AddAnswers form = new AddAnswers(runtime);
            form.Send += EnableForm;
            form.Show();
            this.Enabled = false;
        }

        private void EnableForm(List<string> answers, string right, AnswerType at)
        {
            
        }

        private void PropsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LimittasksCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (limittasksCKB.Checked) LimitTasks = true;
            else LimitTasks = false;
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (subject is SubjectClass) subject.Dispose();
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Title = "Выберите файл предмета";
            filedialog.Filter = "Файлы предметов (*.sft)|*.sft";
            filedialog.ShowDialog();
            string path = filedialog.SafeFileName;
            filename = filedialog.FileName;
            if (path == "") return;
            subject = new SubjectClass(filename);
            SubjectFileNameTxtBox.Text= path.Substring(0,path.Count()-4);
            SubjectNameTxtBox.Text = subject.Name;
            ShowRightCheckBox.Checked = subject.ShowRight;
            AllowReanswerCheckBox.Checked = subject.AllowRemake;
            RandomTaskCheckBox.Checked = subject.Randomtask;
            RandomAnswerCheckBox.Checked = subject.RandomAnswerOrder;
            UseTimer = subject.UseTime;
            LimitTasks = subject.LimitTasks;
            if (subject.LimitedTasksAmount < 1) limitasksUND.Value = subject.Tasks.Count;
            else limitasksUND.Value = subject.LimitedTasksAmount;
            if (subject.Time == -1) TimeForTaskNUD.Value = 180;
            else TimeForTaskNUD.Value = subject.Time;
            UpdateTaskList();
        }

        private void UpdateTaskList()
        {
            TreeNode paramnode = TaskTree.Nodes[0];
            paramnode.Nodes.Clear();
            foreach(TaskClass task in subject.Tasks)
            {
                TreeNode node = new TreeNode(task.Label);
                paramnode.Nodes.Add(node);
            }
            TreeNode nd = new TreeNode("Добавить задание");
            paramnode.Nodes.Add(nd);
        }

        private void ImageView_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListView)
            {
                ListView imgview = (ListView)sender;
                ListViewItem selected = imgview.SelectedItems[0];
                Form frm = new Form();
                frm.Text = $"Просмотр изображения: {selected.Text}";
                PictureBox pb = new PictureBox();
                pb.Size = new Size(1280, 720);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Dock = DockStyle.Fill;
                Image img = Image.FromFile((string)selected.Tag);
                pb.Image = img;
                frm.Size = pb.Size;
                frm.Controls.Add(pb);
                frm.Show();
            }
        }

        private void DeleteImageBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selected = ImageView.SelectedItems[0];
            foreach (KeyValuePair<Image,string> path in runtime.Images)
            {
                if (path.Value == (string)selected.Tag)
                {
                    runtime.Images.Remove(path.Key);
                    changeState();
                    break;
                }
            }
            MessageBox.Show((string)selected.Tag);
        }

        private void BroowseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = 
            dialog.Filter = "Изображения (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp";
            dialog.Title = "Выберите изображение";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newimage = dialog.FileName;
                Image img = Image.FromFile(newimage);
                PictureBox pb = new PictureBox();
                img.Tag = newimage;
                runtime.Images.Add(img, newimage);
                changeState();
            }
        }

        private void DeleteTaskBtn_Click(object sender, EventArgs e)
        {
            subject.Tasks.Remove(runtime);
            if (subject.Tasks.Count > 0) runtime = subject.Tasks[0];
            else
            {
                runtime = new TaskClass();
                subject.Tasks.Add(runtime);
            }
            UpdateTaskList();
            TaskTree.SelectedNode = TaskTree.Nodes[0].Nodes[0];
            TaskTree.Select();
            changeState();
        }

        private void HeaderTask_Leave(object sender, EventArgs e)
        {
            runtime.Label = HeaderTask.Text;
            UpdateTaskList();
        }

        private void EditSubject_Activated(object sender, EventArgs e)
        {
            if (activ==false)
            {
                SystemSounds.Beep.Play();
                this.Enabled = true;
            }
        }
    }
}
