namespace Academic_System
{
    partial class FormAddSubject
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
            this.groupBoxSubjectData = new System.Windows.Forms.GroupBox();
            this.groupBoxAssign = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAssignedTeacher = new System.Windows.Forms.ListBox();
            this.comboBoxAssignTeacher = new System.Windows.Forms.ComboBox();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSubjectCredit = new System.Windows.Forms.TextBox();
            this.buttonSubjectSave = new System.Windows.Forms.Button();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubjectID = new System.Windows.Forms.TextBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.groupBoxSubjectData.SuspendLayout();
            this.groupBoxAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSubjectData
            // 
            this.groupBoxSubjectData.Controls.Add(this.groupBoxAssign);
            this.groupBoxSubjectData.Controls.Add(this.label9);
            this.groupBoxSubjectData.Controls.Add(this.textBoxSubjectCredit);
            this.groupBoxSubjectData.Controls.Add(this.buttonSubjectSave);
            this.groupBoxSubjectData.Controls.Add(this.textBoxSubjectName);
            this.groupBoxSubjectData.Controls.Add(this.label2);
            this.groupBoxSubjectData.Controls.Add(this.label1);
            this.groupBoxSubjectData.Controls.Add(this.textBoxSubjectID);
            this.groupBoxSubjectData.Location = new System.Drawing.Point(42, 12);
            this.groupBoxSubjectData.Name = "groupBoxSubjectData";
            this.groupBoxSubjectData.Size = new System.Drawing.Size(215, 398);
            this.groupBoxSubjectData.TabIndex = 10;
            this.groupBoxSubjectData.TabStop = false;
            this.groupBoxSubjectData.Text = "Subject";
            // 
            // groupBoxAssign
            // 
            this.groupBoxAssign.Controls.Add(this.label3);
            this.groupBoxAssign.Controls.Add(this.listBoxAssignedTeacher);
            this.groupBoxAssign.Controls.Add(this.comboBoxAssignTeacher);
            this.groupBoxAssign.Controls.Add(this.buttonAssign);
            this.groupBoxAssign.Controls.Add(this.label8);
            this.groupBoxAssign.Location = new System.Drawing.Point(10, 97);
            this.groupBoxAssign.Name = "groupBoxAssign";
            this.groupBoxAssign.Size = new System.Drawing.Size(198, 260);
            this.groupBoxAssign.TabIndex = 9;
            this.groupBoxAssign.TabStop = false;
            this.groupBoxAssign.Text = "Assign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assigned Teachers:";
            // 
            // listBoxAssignedTeacher
            // 
            this.listBoxAssignedTeacher.FormattingEnabled = true;
            this.listBoxAssignedTeacher.Location = new System.Drawing.Point(9, 101);
            this.listBoxAssignedTeacher.Name = "listBoxAssignedTeacher";
            this.listBoxAssignedTeacher.Size = new System.Drawing.Size(183, 147);
            this.listBoxAssignedTeacher.TabIndex = 11;
            // 
            // comboBoxAssignTeacher
            // 
            this.comboBoxAssignTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignTeacher.FormattingEnabled = true;
            this.comboBoxAssignTeacher.Location = new System.Drawing.Point(82, 19);
            this.comboBoxAssignTeacher.Name = "comboBoxAssignTeacher";
            this.comboBoxAssignTeacher.Size = new System.Drawing.Size(110, 21);
            this.comboBoxAssignTeacher.TabIndex = 7;
            this.comboBoxAssignTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssignTeacher_SelectedIndexChanged);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(82, 46);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(110, 23);
            this.buttonAssign.TabIndex = 4;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Teacher";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Credit";
            // 
            // textBoxSubjectCredit
            // 
            this.textBoxSubjectCredit.Location = new System.Drawing.Point(92, 71);
            this.textBoxSubjectCredit.Name = "textBoxSubjectCredit";
            this.textBoxSubjectCredit.Size = new System.Drawing.Size(110, 20);
            this.textBoxSubjectCredit.TabIndex = 5;
            // 
            // buttonSubjectSave
            // 
            this.buttonSubjectSave.Location = new System.Drawing.Point(6, 363);
            this.buttonSubjectSave.Name = "buttonSubjectSave";
            this.buttonSubjectSave.Size = new System.Drawing.Size(202, 23);
            this.buttonSubjectSave.TabIndex = 4;
            this.buttonSubjectSave.Text = "Save Subject";
            this.buttonSubjectSave.UseVisualStyleBackColor = true;
            this.buttonSubjectSave.Click += new System.EventHandler(this.buttonSubjectSave_Click);
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(92, 45);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(110, 20);
            this.textBoxSubjectName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxSubjectID
            // 
            this.textBoxSubjectID.Location = new System.Drawing.Point(92, 19);
            this.textBoxSubjectID.Name = "textBoxSubjectID";
            this.textBoxSubjectID.Size = new System.Drawing.Size(110, 20);
            this.textBoxSubjectID.TabIndex = 0;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(263, 12);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(198, 407);
            this.listBoxDisplay.TabIndex = 11;
            // 
            // FormAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.groupBoxSubjectData);
            this.Controls.Add(this.listBoxDisplay);
            this.Name = "FormAddSubject";
            this.Text = "FormAddSubject";
            this.Load += new System.EventHandler(this.FormAddSubject_Load);
            this.groupBoxSubjectData.ResumeLayout(false);
            this.groupBoxSubjectData.PerformLayout();
            this.groupBoxAssign.ResumeLayout(false);
            this.groupBoxAssign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSubjectData;
        private System.Windows.Forms.GroupBox groupBoxAssign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAssignedTeacher;
        private System.Windows.Forms.ComboBox comboBoxAssignTeacher;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSubjectCredit;
        private System.Windows.Forms.Button buttonSubjectSave;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubjectID;
        private System.Windows.Forms.ListBox listBoxDisplay;
    }
}