using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Forms
{
    public partial class NoteControl : UserControl
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public NoteControl()
        {
            InitializeComponent();
        }

        public void WriteTexts()
        {
            this.lblTitle.Text = Title;
            this.txtContent.Text = Content;
        }
    }
}
