using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo.Forms.SetingsPages
{
    public partial class SetingsPanel : UserControl
    {
        private SetingsPanel sp;
        public SetingsPanel ChildPanel
        {
            get { return sp; }
            private set
            {
                sp = value;
                ChildChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public delegate void chilchanged(object sender, EventArgs e);
        public event chilchanged ChildChanged;
        public delegate void closed();
        public event closed ChildClosed;

        public SetingsPanel()
        {
            InitializeComponent();
        }

        private void SetingsPanel_Load(object sender, EventArgs e)
        {

        }

        public void Close()
        {
            ChildClosed?.Invoke();
        }
    }
}
