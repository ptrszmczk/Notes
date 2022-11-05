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
        private NoteControlDelete _deleteNote;
        private NoteControlModify _modifyNote;

        public frmNotepad()
        {
            InitializeComponent();
            WriteData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNoteForm addNote = new AddNoteForm();
            addNote.SaveButton += new EventHandler(note_AddSaveButtonClicked);
            addNote.Show();

            List<NoteData> allData = _file.ReadFromFile();
            if(cbDelete.Checked || cbModify.Checked)
            {
                cbModify.Checked = cbDelete.Checked = false;
                flpNotesFlowPanel.Controls.Clear();
                DisplayUserControls(allData, 0);
            }
        }

        private void note_AddSaveButtonClicked(object sender, EventArgs e)
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

        private void note_ModifyButtonClicked(object sender, EventArgs e)
        {
            ModifyNoteForm modifyNote = new ModifyNoteForm();
            modifyNote.SaveButton += new EventHandler(note_ModifySaveButtonClicked);

            NoteControlModify modifyNoteControl = sender as NoteControlModify;
            modifyNote.OldTitle = modifyNoteControl.Title;
            modifyNote.OldContent = modifyNoteControl.Content;
            modifyNote.OldDate = modifyNoteControl.Date;
            modifyNote.DisplaySavedNote(modifyNoteControl.Title, modifyNoteControl.Content);
            modifyNote.Show();
        }

        private void note_ModifySaveButtonClicked(object sender, EventArgs e)
        {
            WriteData();
            cbModify.Checked = false;
        }

        private void note_DeleteButtonClicked(object sender, EventArgs e)
        {
            DeleteConfirmationForm confirmation = new DeleteConfirmationForm();
            confirmation.ConfirmationButton += new EventHandler(note_ConfirmationButtnClicked);
            confirmation.Show();

            _deleteNote = sender as NoteControlDelete;
        }

        private void note_ConfirmationButtnClicked(object sender, EventArgs e)
        {
            NoteData deleteFromFile = new NoteData();
            deleteFromFile.DeleteFromFile(_deleteNote.Title, _deleteNote.Content, _deleteNote.Date);
            flpNotesFlowPanel.Controls.Remove(_deleteNote);
            _deleteNote.Dispose();
        }

        private void WriteData()
        {
            flpNotesFlowPanel.Controls.Clear();
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

        private void pButtons_Click(object sender, EventArgs e)
        {
            cbModify.Checked = cbDelete.Checked = false;
        }
    }
}
