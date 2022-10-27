using Notes.DataManagement;
using Notes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
            WriteData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNoteForm addNote = new AddNoteForm();
            addNote.SaveButton += new EventHandler(note_SaveButtonClicked);
            addNote.Show();
        }

        private void note_SaveButtonClicked(object sender, EventArgs e)
        {
            AddNoteForm addNote = sender as AddNoteForm;
            if(addNote != null)
            {
                NoteControl note = new NoteControl();
                note.Title = addNote.Data.Title;
                note.Content = addNote.Data.Content;
                flpNotesFlowPanel.Controls.Add(note);
                note.WriteTexts();
            }
        }

        private void WriteData()
        {
            NoteData file = new NoteData();
            List<NoteData> allData = file.ReadFromFile();

            foreach (var data in allData)
            {
                NoteControl note = new NoteControl();
                note.Title = data.Title;
                note.Content = data.Content;
                flpNotesFlowPanel.Controls.Add(note);
                note.WriteTexts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
