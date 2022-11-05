namespace Notes.Forms
{
    partial class ModifyNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lblAddNote
            // 
            this.lblAddNote.Location = new System.Drawing.Point(48, 9);
            this.lblAddNote.Size = new System.Drawing.Size(145, 38);
            this.lblAddNote.Text = "Modyfikuj";
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModifyNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 565);
            this.Name = "ModifyNoteForm";
            this.Text = "Modyfikuj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}