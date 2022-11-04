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
    public partial class NoteControlModify : NoteControl
    {
        public event EventHandler ModifyButton;

        public NoteControlModify()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked(null);
        }

        protected virtual void DeleteButtonClicked(EventArgs e)
        {
            EventHandler modified = ModifyButton;
            if (modified != null)
            {
                modified(this, e);
            }
        }
    }
}
