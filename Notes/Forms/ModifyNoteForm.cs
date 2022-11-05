using Notes.DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.Forms
{
    public partial class ModifyNoteForm : AddNoteForm
    {
        public string OldTitle { get; set; }
        public string OldContent { get; set; }
        public string OldDate { get; set; }

        public ModifyNoteForm()
        {
            InitializeComponent();
        }

        public void DisplaySavedNote(string title, string content)
        {
            txtTitle.Text = title;
            txtContent.Text = content;
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            _note.Title = txtTitle.Text;
            _note.Content = txtContent.Text;
            _note.Date = DateTime.Now.ToString();
            _txtContentSize = txtContent.Size.Height;
            _note.ModifyFile(OldTitle, OldContent, OldDate);
            SaveButtonClicked(null);
            Close();
        }
    }
}
