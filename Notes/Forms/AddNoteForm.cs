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
        protected NoteData _note = new NoteData();
        protected int _txtContentSize;

        public NoteData Data { get { return _note; } }
        public int TxtContentSize { get { return _txtContentSize; } }

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

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            _note.Title = txtTitle.Text;
            _note.Content = txtContent.Text;
            _note.Date = DateTime.Now.ToString();
            _txtContentSize = txtContent.Size.Height;
            _note.WriteToFile();
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
