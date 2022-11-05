namespace Notes
{
    partial class frmNotepad
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
            this.pButtons = new System.Windows.Forms.Panel();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbModify = new System.Windows.Forms.CheckBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpNotesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.DimGray;
            this.pButtons.Controls.Add(this.cbDelete);
            this.pButtons.Controls.Add(this.cbModify);
            this.pButtons.Controls.Add(this.splitter);
            this.pButtons.Controls.Add(this.btnAdd);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Name = "pButtons";
            this.pButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pButtons.Size = new System.Drawing.Size(984, 55);
            this.pButtons.TabIndex = 0;
            this.pButtons.Click += new System.EventHandler(this.pButtons_Click);
            // 
            // cbDelete
            // 
            this.cbDelete.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbDelete.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbDelete.Image = global::Notes.Properties.Resources.close;
            this.cbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDelete.Location = new System.Drawing.Point(850, 5);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cbDelete.Size = new System.Drawing.Size(129, 45);
            this.cbDelete.TabIndex = 9;
            this.cbDelete.Text = "Usuń";
            this.cbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // cbModify
            // 
            this.cbModify.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbModify.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbModify.Image = global::Notes.Properties.Resources.pen;
            this.cbModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbModify.Location = new System.Drawing.Point(143, 5);
            this.cbModify.Name = "cbModify";
            this.cbModify.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cbModify.Size = new System.Drawing.Size(173, 45);
            this.cbModify.TabIndex = 8;
            this.cbModify.Text = "Modyfikuj";
            this.cbModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbModify.UseVisualStyleBackColor = true;
            this.cbModify.CheckedChanged += new System.EventHandler(this.cbModify_CheckedChanged);
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(140, 5);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 45);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Image = global::Notes.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.Size = new System.Drawing.Size(135, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpNotesFlowPanel
            // 
            this.flpNotesFlowPanel.AutoScroll = true;
            this.flpNotesFlowPanel.BackColor = System.Drawing.Color.Gray;
            this.flpNotesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotesFlowPanel.Location = new System.Drawing.Point(0, 55);
            this.flpNotesFlowPanel.Name = "flpNotesFlowPanel";
            this.flpNotesFlowPanel.Size = new System.Drawing.Size(984, 530);
            this.flpNotesFlowPanel.TabIndex = 1;
            this.flpNotesFlowPanel.Click += new System.EventHandler(this.flpNotesFlowPanel_Click);
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 585);
            this.Controls.Add(this.flpNotesFlowPanel);
            this.Controls.Add(this.pButtons);
            this.Name = "frmNotepad";
            this.Text = "Notes";
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpNotesFlowPanel;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbModify;
    }
}

