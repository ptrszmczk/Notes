using Notes.DataManagement;
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
    public partial class AddNoteForm : Form
    {
        private NoteData note = new NoteData();
        private int txtContentSize;

        public NoteData Data { get { return note; } }
        public int TxtContentSize { get { return txtContentSize; } }

        public event EventHandler SaveButton;

        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            note.Title = txtTitle.Text;
            note.Content = txtContent.Text;
            note.Date = DateTime.Now.ToString();
            txtContentSize = txtContent.Size.Height;
            note.WriteToFile();
            SaveButtonClicked(null);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void SaveButtonClicked(EventArgs e)
        {
            EventHandler saved = SaveButton;
            if (saved != null)
            {
                saved(this, e);
            }
        }
    }
}
