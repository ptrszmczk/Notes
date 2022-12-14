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
    public partial class NoteControlDelete : NoteControl
    {
        public event EventHandler DeleteButton;

        public NoteControlDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked(null);
        }

        protected virtual void DeleteButtonClicked(EventArgs e)
        {
            EventHandler deleted = DeleteButton;
            if (deleted != null)
            {
                deleted(this, e);
            }
        }
    }
}
