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
            NoteData note = new NoteData();
            note.Title = txtTitle.Text;
            note.Content = txtContent.Text;

            note.WriteToFile();
            Close();
        }
    }
}
