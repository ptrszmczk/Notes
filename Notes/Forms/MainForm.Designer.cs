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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.splitter = new System.Windows.Forms.Splitter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpNotesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.Color.DimGray;
            this.pButtons.Controls.Add(this.checkBox1);
            this.pButtons.Controls.Add(this.btnDelete);
            this.pButtons.Controls.Add(this.btnModify);
            this.pButtons.Controls.Add(this.splitter);
            this.pButtons.Controls.Add(this.btnAdd);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Name = "pButtons";
            this.pButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pButtons.Size = new System.Drawing.Size(984, 55);
            this.pButtons.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Image = global::Notes.Properties.Resources.close;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(850, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(129, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Image = global::Notes.Properties.Resources.pen;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(143, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnModify.Size = new System.Drawing.Size(173, 45);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
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
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox1.Location = new System.Drawing.Point(556, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
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
            this.pButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpNotesFlowPanel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

