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
    public partial class DeleteConfirmationForm : Form
    {
        public event EventHandler ConfirmationButton;

        public DeleteConfirmationForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ConfirmationButtonClicked(null);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void ConfirmationButtonClicked(EventArgs e)
        {
            EventHandler confirmed = ConfirmationButton;
            if (confirmed != null)
            {
                confirmed(this, e);
            }
        }
    }
}
