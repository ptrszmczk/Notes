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
        private NoteData _file = new NoteData();

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
                note.Date = addNote.Data.Date;
                flpNotesFlowPanel.Controls.Add(note);
                note.WriteTexts();
            }
        }

        private void note_DeleteButtonClicked(object sender, EventArgs e)
        {
            DeleteConfirmationForm confirmation = new DeleteConfirmationForm();
            confirmation.ConfirmationButton += new EventHandler(note_ConfirmationButtnClicked);
            confirmation.Show();

            NoteControlDelete deleteNote = sender as NoteControlDelete;
            NoteData deleteFromFile = new NoteData();
            deleteFromFile.DeleteFromFile(deleteNote.Title, deleteNote.Content, deleteNote.Date);
            flpNotesFlowPanel.Controls.Remove(deleteNote);
            deleteNote.Dispose();
        }

        private void note_ConfirmationButtnClicked(object sender, EventArgs e)
        {
            
        }

        private void note_ModifyButtonClicked(object sender, EventArgs e)
        {
            NoteControlDelete deleteNote = sender as NoteControlDelete;
        }

        private void WriteData()
        {
            List<NoteData> allData = _file.ReadFromFile();
            DisplayUserControls(allData, 0);
        }

        private void DisplayUserControls(List<NoteData> allData, params int[] p)
        {
            foreach (var data in allData)
            {
                if (p[0] == 0)
                {
                    NoteControl note = new NoteControl();
                    note.Title = data.Title;
                    note.Content = data.Content;
                    note.Date = data.Date;
                    flpNotesFlowPanel.Controls.Add(note);
                    note.WriteTexts();
                }
                if (p[0] == 1)
                {
                    NoteControlDelete note = new NoteControlDelete();
                    note.DeleteButton += new EventHandler(note_DeleteButtonClicked);
                    note.Title = data.Title;
                    note.Content = data.Content;
                    note.Date = data.Date;
                    flpNotesFlowPanel.Controls.Add(note);
                    note.WriteTexts();
                }
                if (p[0] == 2)
                {
                    NoteControlModify note = new NoteControlModify();
                    note.ModifyButton += new EventHandler(note_ModifyButtonClicked);
                    note.Title = data.Title;
                    note.Content = data.Content;
                    note.Date = data.Date;
                    flpNotesFlowPanel.Controls.Add(note);
                    note.WriteTexts();
                }
            }
        }

        private void cbModify_CheckedChanged(object sender, EventArgs e)
        {
            flpNotesFlowPanel.Controls.Clear();

            if (cbModify.Checked)
            {
                cbDelete.Checked = false;
                List<NoteData> allData = _file.ReadFromFile();
                DisplayUserControls(allData, 2);
            }
            else if(!cbModify.Checked && !cbDelete.Checked)
            {
                WriteData();
            }
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            flpNotesFlowPanel.Controls.Clear();

            if (cbDelete.Checked)
            {
                cbModify.Checked = false;
                List<NoteData> allData = _file.ReadFromFile();
                DisplayUserControls(allData, 1);
            }
            else if (!cbModify.Checked && !cbDelete.Checked)
            {
                WriteData();
            }
        }

        private void flpNotesFlowPanel_Click(object sender, EventArgs e)
        {
            cbModify.Checked = cbDelete.Checked = false;
        }
    }
}
