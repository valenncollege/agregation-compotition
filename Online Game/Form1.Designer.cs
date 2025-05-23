namespace Online_Game
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
            this.buttonPlayerSave = new System.Windows.Forms.Button();
            this.groupBoxPlayerData = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayerID = new System.Windows.Forms.TextBox();
            this.groupBoxWeaponData = new System.Windows.Forms.GroupBox();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonWeaponSave = new System.Windows.Forms.Button();
            this.textBoxWeaponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeaponID = new System.Windows.Forms.TextBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.groupBoxPlayerData.SuspendLayout();
            this.groupBoxWeaponData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlayerSave
            // 
            this.buttonPlayerSave.Location = new System.Drawing.Point(92, 73);
            this.buttonPlayerSave.Name = "buttonPlayerSave";
            this.buttonPlayerSave.Size = new System.Drawing.Size(100, 23);
            this.buttonPlayerSave.TabIndex = 4;
            this.buttonPlayerSave.Text = "Save";
            this.buttonPlayerSave.UseVisualStyleBackColor = true;
            this.buttonPlayerSave.Click += new System.EventHandler(this.buttonPlayerSave_Click);
            // 
            // groupBoxPlayerData
            // 
            this.groupBoxPlayerData.Controls.Add(this.buttonPlayerSave);
            this.groupBoxPlayerData.Controls.Add(this.textBoxPlayerName);
            this.groupBoxPlayerData.Controls.Add(this.label2);
            this.groupBoxPlayerData.Controls.Add(this.label1);
            this.groupBoxPlayerData.Controls.Add(this.textBoxPlayerID);
            this.groupBoxPlayerData.Location = new System.Drawing.Point(36, 30);
            this.groupBoxPlayerData.Name = "groupBoxPlayerData";
            this.groupBoxPlayerData.Size = new System.Drawing.Size(198, 102);
            this.groupBoxPlayerData.TabIndex = 7;
            this.groupBoxPlayerData.TabStop = false;
            this.groupBoxPlayerData.Text = "Player";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(92, 45);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 3;
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
            // textBoxPlayerID
            // 
            this.textBoxPlayerID.Location = new System.Drawing.Point(92, 19);
            this.textBoxPlayerID.Name = "textBoxPlayerID";
            this.textBoxPlayerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerID.TabIndex = 0;
            // 
            // groupBoxWeaponData
            // 
            this.groupBoxWeaponData.Controls.Add(this.comboBoxPlayer);
            this.groupBoxWeaponData.Controls.Add(this.label5);
            this.groupBoxWeaponData.Controls.Add(this.buttonWeaponSave);
            this.groupBoxWeaponData.Controls.Add(this.textBoxWeaponName);
            this.groupBoxWeaponData.Controls.Add(this.label3);
            this.groupBoxWeaponData.Controls.Add(this.label4);
            this.groupBoxWeaponData.Controls.Add(this.textBoxWeaponID);
            this.groupBoxWeaponData.Location = new System.Drawing.Point(36, 138);
            this.groupBoxWeaponData.Name = "groupBoxWeaponData";
            this.groupBoxWeaponData.Size = new System.Drawing.Size(198, 131);
            this.groupBoxWeaponData.TabIndex = 8;
            this.groupBoxWeaponData.TabStop = false;
            this.groupBoxWeaponData.Text = "Weapon";
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(92, 19);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPlayer.TabIndex = 6;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Player";
            // 
            // buttonWeaponSave
            // 
            this.buttonWeaponSave.Location = new System.Drawing.Point(92, 98);
            this.buttonWeaponSave.Name = "buttonWeaponSave";
            this.buttonWeaponSave.Size = new System.Drawing.Size(100, 23);
            this.buttonWeaponSave.TabIndex = 4;
            this.buttonWeaponSave.Text = "Save";
            this.buttonWeaponSave.UseVisualStyleBackColor = true;
            this.buttonWeaponSave.Click += new System.EventHandler(this.buttonWeaponSave_Click);
            // 
            // textBoxWeaponName
            // 
            this.textBoxWeaponName.Location = new System.Drawing.Point(92, 72);
            this.textBoxWeaponName.Name = "textBoxWeaponName";
            this.textBoxWeaponName.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // textBoxWeaponID
            // 
            this.textBoxWeaponID.Location = new System.Drawing.Point(92, 46);
            this.textBoxWeaponID.Name = "textBoxWeaponID";
            this.textBoxWeaponID.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeaponID.TabIndex = 0;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(240, 30);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(271, 251);
            this.listBoxDisplay.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 346);
            this.Controls.Add(this.groupBoxPlayerData);
            this.Controls.Add(this.groupBoxWeaponData);
            this.Controls.Add(this.listBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPlayerData.ResumeLayout(false);
            this.groupBoxPlayerData.PerformLayout();
            this.groupBoxWeaponData.ResumeLayout(false);
            this.groupBoxWeaponData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayerSave;
        private System.Windows.Forms.GroupBox groupBoxPlayerData;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayerID;
        private System.Windows.Forms.GroupBox groupBoxWeaponData;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonWeaponSave;
        private System.Windows.Forms.TextBox textBoxWeaponName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeaponID;
        private System.Windows.Forms.ListBox listBoxDisplay;
    }
}

