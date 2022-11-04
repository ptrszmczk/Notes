using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Forms
{
    public partial class NoteControl : UserControl
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public NoteControl()
        {
            InitializeComponent();
        }

        public void WriteTexts()
        {
            this.lblTitle.Text = Title;
            this.txtContent.Text = Content;
            this.lblDate.Text = Date;
            if (this.txtContent.Text.Split('\n').Length >= 9) txtContent.ScrollBars = ScrollBars.Vertical;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("adsf");
        }
    }
}
