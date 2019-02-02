namespace ExperimentNotes
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
            this.tbPathXML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.tbBath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInternal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTimeUnits = new System.Windows.Forms.ComboBox();
            this.btnTagNew = new System.Windows.Forms.Button();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.btnTagDelete = new System.Windows.Forms.Button();
            this.btnTagReplace = new System.Windows.Forms.Button();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbXML = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPathXML
            // 
            this.tbPathXML.Location = new System.Drawing.Point(52, 16);
            this.tbPathXML.Name = "tbPathXML";
            this.tbPathXML.Size = new System.Drawing.Size(563, 20);
            this.tbPathXML.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNotes);
            this.groupBox1.Controls.Add(this.tbBath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbInternal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAnimal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 239);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(78, 94);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(231, 136);
            this.tbNotes.TabIndex = 14;
            // 
            // tbBath
            // 
            this.tbBath.Location = new System.Drawing.Point(78, 68);
            this.tbBath.Name = "tbBath";
            this.tbBath.Size = new System.Drawing.Size(231, 20);
            this.tbBath.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bath:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbInternal
            // 
            this.tbInternal.Location = new System.Drawing.Point(78, 42);
            this.tbInternal.Name = "tbInternal";
            this.tbInternal.Size = new System.Drawing.Size(231, 20);
            this.tbInternal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Internal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(78, 16);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(231, 20);
            this.tbAnimal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Animal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbTimeUnits);
            this.groupBox2.Controls.Add(this.btnTagNew);
            this.groupBox2.Controls.Add(this.tbComment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudTime);
            this.groupBox2.Controls.Add(this.btnTagDelete);
            this.groupBox2.Controls.Add(this.btnTagReplace);
            this.groupBox2.Controls.Add(this.lbTags);
            this.groupBox2.Location = new System.Drawing.Point(340, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 211);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTimeUnits
            // 
            this.cbTimeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeUnits.FormattingEnabled = true;
            this.cbTimeUnits.Items.AddRange(new object[] {
            "min",
            "sec",
            "frame"});
            this.cbTimeUnits.Location = new System.Drawing.Point(142, 129);
            this.cbTimeUnits.Name = "cbTimeUnits";
            this.cbTimeUnits.Size = new System.Drawing.Size(62, 21);
            this.cbTimeUnits.TabIndex = 29;
            // 
            // btnTagNew
            // 
            this.btnTagNew.Location = new System.Drawing.Point(48, 182);
            this.btnTagNew.Name = "btnTagNew";
            this.btnTagNew.Size = new System.Drawing.Size(75, 23);
            this.btnTagNew.TabIndex = 28;
            this.btnTagNew.Text = "New";
            this.btnTagNew.UseVisualStyleBackColor = true;
            this.btnTagNew.Click += new System.EventHandler(this.btnTagNew_Click);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(61, 156);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(223, 20);
            this.tbComment.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Comment:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTime
            // 
            this.nudTime.DecimalPlaces = 2;
            this.nudTime.Location = new System.Drawing.Point(61, 130);
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
            this.btnTagDelete.Location = new System.Drawing.Point(210, 182);
            this.btnTagDelete.Name = "btnTagDelete";
            this.btnTagDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTagDelete.TabIndex = 17;
            this.btnTagDelete.Text = "Delete";
            this.btnTagDelete.UseVisualStyleBackColor = true;
            this.btnTagDelete.Click += new System.EventHandler(this.btnTagDelete_Click);
            // 
            // btnTagReplace
            // 
            this.btnTagReplace.Location = new System.Drawing.Point(129, 182);
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
            this.lbTags.Items.AddRange(new object[] {
            "TGOT 20nM 3min @ 12.34 min",
            "OXT 200nM 3min @ frame 432"});
            this.lbTags.Location = new System.Drawing.Point(6, 16);
            this.lbTags.Name = "lbTags";
            this.lbTags.ScrollAlwaysVisible = true;
            this.lbTags.Size = new System.Drawing.Size(279, 108);
            this.lbTags.TabIndex = 0;
            this.lbTags.SelectedValueChanged += new System.EventHandler(this.lbTags_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPreview);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.tbXML);
            this.groupBox3.Controls.Add(this.tbPathXML);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 240);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(214, 42);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 32;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "XML:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(52, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbXML
            // 
            this.tbXML.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXML.Location = new System.Drawing.Point(52, 87);
            this.tbXML.Multiline = true;
            this.tbXML.Name = "tbXML";
            this.tbXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbXML.Size = new System.Drawing.Size(563, 147);
            this.tbXML.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Experiment Note Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbPathXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInternal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Button btnTagDelete;
        private System.Windows.Forms.Button btnTagReplace;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Button btnTagNew;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimeUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbXML;
    }
}

