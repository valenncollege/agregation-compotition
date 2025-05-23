namespace Academic_System
{
    partial class FormAddTeacher
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
            this.groupBoxTeacherData = new System.Windows.Forms.GroupBox();
            this.buttonTeacherSave = new System.Windows.Forms.Button();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.listBoxAssignedTeacher = new System.Windows.Forms.ListBox();
            this.groupBoxTeacherData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTeacherData
            // 
            this.groupBoxTeacherData.Controls.Add(this.buttonTeacherSave);
            this.groupBoxTeacherData.Controls.Add(this.textBoxTeacherName);
            this.groupBoxTeacherData.Controls.Add(this.label3);
            this.groupBoxTeacherData.Controls.Add(this.label4);
            this.groupBoxTeacherData.Controls.Add(this.textBoxTeacherID);
            this.groupBoxTeacherData.Location = new System.Drawing.Point(68, 29);
            this.groupBoxTeacherData.Name = "groupBoxTeacherData";
            this.groupBoxTeacherData.Size = new System.Drawing.Size(198, 104);
            this.groupBoxTeacherData.TabIndex = 13;
            this.groupBoxTeacherData.TabStop = false;
            this.groupBoxTeacherData.Text = "Teacher";
            // 
            // buttonTeacherSave
            // 
            this.buttonTeacherSave.Location = new System.Drawing.Point(92, 71);
            this.buttonTeacherSave.Name = "buttonTeacherSave";
            this.buttonTeacherSave.Size = new System.Drawing.Size(100, 23);
            this.buttonTeacherSave.TabIndex = 4;
            this.buttonTeacherSave.Text = "Save";
            this.buttonTeacherSave.UseVisualStyleBackColor = true;
            this.buttonTeacherSave.Click += new System.EventHandler(this.buttonTeacherSave_Click);
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Location = new System.Drawing.Point(92, 45);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacherName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(92, 19);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacherID.TabIndex = 0;
            // 
            // listBoxAssignedTeacher
            // 
            this.listBoxAssignedTeacher.FormattingEnabled = true;
            this.listBoxAssignedTeacher.Location = new System.Drawing.Point(68, 139);
            this.listBoxAssignedTeacher.Name = "listBoxAssignedTeacher";
            this.listBoxAssignedTeacher.Size = new System.Drawing.Size(198, 225);
            this.listBoxAssignedTeacher.TabIndex = 14;
            // 
            // FormAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 410);
            this.Controls.Add(this.groupBoxTeacherData);
            this.Controls.Add(this.listBoxAssignedTeacher);
            this.Name = "FormAddTeacher";
            this.Text = "FormAddTeacher";
            this.Load += new System.EventHandler(this.FormAddTeacher_Load);
            this.groupBoxTeacherData.ResumeLayout(false);
            this.groupBoxTeacherData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTeacherData;
        private System.Windows.Forms.Button buttonTeacherSave;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.ListBox listBoxAssignedTeacher;
    }
}