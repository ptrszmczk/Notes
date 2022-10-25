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
    public partial class NoteForm : Form
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public NoteForm()
        {
            InitializeComponent();
        }
    }
}
