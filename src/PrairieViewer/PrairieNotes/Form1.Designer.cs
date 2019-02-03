namespace PrairieNotes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.tbBath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.cbTimeUnits = new System.Windows.Forms.ComboBox();
            this.btnTagNew = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.btnTagDelete = new System.Windows.Forms.Button();
            this.btnTagReplace = new System.Windows.Forms.Button();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.btnXmlRevert = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbPvInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setExperimentFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFolderNames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbInternal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXmlSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(62, 123);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotes.Size = new System.Drawing.Size(246, 93);
            this.tbNotes.TabIndex = 14;
            this.tbNotes.TextChanged += new System.EventHandler(this.tbNotes_TextChanged);
            // 
            // tbBath
            // 
            this.tbBath.Location = new System.Drawing.Point(62, 71);
            this.tbBath.Name = "tbBath";
            this.tbBath.Size = new System.Drawing.Size(246, 20);
            this.tbBath.TabIndex = 13;
            this.tbBath.TextChanged += new System.EventHandler(this.tbBath_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bath:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(62, 45);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(246, 20);
            this.tbAnimal.TabIndex = 9;
            this.tbAnimal.TextChanged += new System.EventHandler(this.tbAnimal_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(269, 334);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(48, 17);
            this.cbTimer.TabIndex = 31;
            this.cbTimer.Text = "timer";
            this.cbTimer.UseVisualStyleBackColor = true;
            this.cbTimer.CheckedChanged += new System.EventHandler(this.cbTimer_CheckedChanged);
            // 
            // cbTimeUnits
            // 
            this.cbTimeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeUnits.FormattingEnabled = true;
            this.cbTimeUnits.Items.AddRange(new object[] {
            "min",
            "sec",
            "frame"});
            this.cbTimeUnits.Location = new System.Drawing.Point(201, 332);
            this.cbTimeUnits.Name = "cbTimeUnits";
            this.cbTimeUnits.Size = new System.Drawing.Size(62, 21);
            this.cbTimeUnits.TabIndex = 29;
            // 
            // btnTagNew
            // 
            this.btnTagNew.Location = new System.Drawing.Point(71, 357);
            this.btnTagNew.Name = "btnTagNew";
            this.btnTagNew.Size = new System.Drawing.Size(75, 23);
            this.btnTagNew.TabIndex = 28;
            this.btnTagNew.Text = "Add";
            this.btnTagNew.UseVisualStyleBackColor = true;
            this.btnTagNew.Click += new System.EventHandler(this.btnTagNew_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(120, 307);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(188, 20);
            this.tbComment.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(59, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Comment:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTime
            // 
            this.nudTime.DecimalPlaces = 2;
            this.nudTime.Location = new System.Drawing.Point(120, 333);
            this.nudTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(75, 20);
            this.nudTime.TabIndex = 22;
            this.nudTime.Value = new decimal(new int[] {
            1234,
            0,
            0,
            131072});
            // 
            // btnTagDelete
            // 
            this.btnTagDelete.Location = new System.Drawing.Point(233, 357);
            this.btnTagDelete.Name = "btnTagDelete";
            this.btnTagDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTagDelete.TabIndex = 17;
            this.btnTagDelete.Text = "Delete";
            this.btnTagDelete.UseVisualStyleBackColor = true;
            this.btnTagDelete.Click += new System.EventHandler(this.btnTagDelete_Click);
            // 
            // btnTagReplace
            // 
            this.btnTagReplace.Location = new System.Drawing.Point(152, 357);
            this.btnTagReplace.Name = "btnTagReplace";
            this.btnTagReplace.Size = new System.Drawing.Size(75, 23);
            this.btnTagReplace.TabIndex = 16;
            this.btnTagReplace.Text = "Replace";
            this.btnTagReplace.UseVisualStyleBackColor = true;
            this.btnTagReplace.Click += new System.EventHandler(this.btnTagReplace_Click);
            // 
            // lbTags
            // 
            this.lbTags.FormattingEnabled = true;
            this.lbTags.Location = new System.Drawing.Point(62, 222);
            this.lbTags.Name = "lbTags";
            this.lbTags.ScrollAlwaysVisible = true;
            this.lbTags.Size = new System.Drawing.Size(246, 82);
            this.lbTags.TabIndex = 0;
            // 
            // btnXmlRevert
            // 
            this.btnXmlRevert.Location = new System.Drawing.Point(134, 16);
            this.btnXmlRevert.Name = "btnXmlRevert";
            this.btnXmlRevert.Size = new System.Drawing.Size(75, 23);
            this.btnXmlRevert.TabIndex = 29;
            this.btnXmlRevert.Text = "Revert";
            this.btnXmlRevert.UseVisualStyleBackColor = true;
            this.btnXmlRevert.Click += new System.EventHandler(this.btnXmlRevert_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXmlSave);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbInternal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnXmlRevert);
            this.groupBox4.Controls.Add(this.cbTimer);
            this.groupBox4.Controls.Add(this.tbNotes);
            this.groupBox4.Controls.Add(this.tbBath);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbAnimal);
            this.groupBox4.Controls.Add(this.cbTimeUnits);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnTagNew);
            this.groupBox4.Controls.Add(this.lbTags);
            this.groupBox4.Controls.Add(this.btnTagReplace);
            this.groupBox4.Controls.Add(this.tbComment);
            this.groupBox4.Controls.Add(this.btnTagDelete);
            this.groupBox4.Controls.Add(this.nudTime);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(212, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 388);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "experiment.xml";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(59, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tags:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbPvInfo);
            this.groupBox5.Location = new System.Drawing.Point(538, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 130);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prairie Experiment Details";
            // 
            // tbPvInfo
            // 
            this.tbPvInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPvInfo.Enabled = false;
            this.tbPvInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPvInfo.Location = new System.Drawing.Point(3, 16);
            this.tbPvInfo.Multiline = true;
            this.tbPvInfo.Name = "tbPvInfo";
            this.tbPvInfo.Size = new System.Drawing.Size(371, 111);
            this.tbPvInfo.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setExperimentFolderToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.launchToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.fileToolStripMenuItem.Text = "Experiment Folder";
            // 
            // setExperimentFolderToolStripMenuItem
            // 
            this.setExperimentFolderToolStripMenuItem.Name = "setExperimentFolderToolStripMenuItem";
            this.setExperimentFolderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setExperimentFolderToolStripMenuItem.Text = "Set Folder";
            this.setExperimentFolderToolStripMenuItem.Click += new System.EventHandler(this.setExperimentFolderToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.refreshToolStripMenuItem.Text = "Refresh (F5)";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.launchToolStripMenuItem.Text = "Launch (double click)";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteToolStripMenuItem.Text = "Delete (del)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lbFolderNames
            // 
            this.lbFolderNames.FormattingEnabled = true;
            this.lbFolderNames.Location = new System.Drawing.Point(12, 27);
            this.lbFolderNames.Name = "lbFolderNames";
            this.lbFolderNames.ScrollAlwaysVisible = true;
            this.lbFolderNames.Size = new System.Drawing.Size(194, 381);
            this.lbFolderNames.TabIndex = 35;
            this.lbFolderNames.SelectedIndexChanged += new System.EventHandler(this.lbFolderNames_SelectedIndexChanged);
            this.lbFolderNames.DoubleClick += new System.EventHandler(this.lbFolderNames_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(538, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 252);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prairie Experiment Images";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // tbInternal
            // 
            this.tbInternal.Location = new System.Drawing.Point(62, 97);
            this.tbInternal.Name = "tbInternal";
            this.tbInternal.Size = new System.Drawing.Size(246, 20);
            this.tbInternal.TabIndex = 34;
            this.tbInternal.TextChanged += new System.EventHandler(this.tbInternal_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Internal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXmlSave
            // 
            this.btnXmlSave.Location = new System.Drawing.Point(215, 16);
            this.btnXmlSave.Name = "btnXmlSave";
            this.btnXmlSave.Size = new System.Drawing.Size(93, 23);
            this.btnXmlSave.TabIndex = 36;
            this.btnXmlSave.Text = "Save Changes";
            this.btnXmlSave.UseVisualStyleBackColor = true;
            this.btnXmlSave.Click += new System.EventHandler(this.btnXmlSave_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 448);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFolderNames);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Prairie Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbTimer;
        private System.Windows.Forms.ComboBox cbTimeUnits;
        private System.Windows.Forms.Button btnTagNew;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Button btnTagDelete;
        private System.Windows.Forms.Button btnTagReplace;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Button btnXmlRevert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbPvInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setExperimentFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox lbFolderNames;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInternal;
        private System.Windows.Forms.Button btnXmlSave;
        private System.Windows.Forms.Timer timer1;
    }
}

