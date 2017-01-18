namespace UpdatePomVersion
{
    partial class PomUpdate
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
            this.TargetVersion = new System.Windows.Forms.TextBox();
            this.TargetVersionLbl = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FileListsArea = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.CheckedListBox();
            this.UpdateVersionGroup = new System.Windows.Forms.GroupBox();
            this.last = new System.Windows.Forms.RadioButton();
            this.middle = new System.Windows.Forms.RadioButton();
            this.first = new System.Windows.Forms.RadioButton();
            this.UpdateVersionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TargetVersion
            // 
            this.TargetVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetVersion.Location = new System.Drawing.Point(313, 54);
            this.TargetVersion.Name = "TargetVersion";
            this.TargetVersion.Size = new System.Drawing.Size(100, 23);
            this.TargetVersion.TabIndex = 0;
            // 
            // TargetVersionLbl
            // 
            this.TargetVersionLbl.AutoSize = true;
            this.TargetVersionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetVersionLbl.Location = new System.Drawing.Point(171, 54);
            this.TargetVersionLbl.Name = "TargetVersionLbl";
            this.TargetVersionLbl.Size = new System.Drawing.Size(102, 17);
            this.TargetVersionLbl.TabIndex = 1;
            this.TargetVersionLbl.Text = "Target Version";
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(552, 187);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(106, 25);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open Files";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(552, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Apply_Click);
            // 
            // FileListsArea
            // 
            this.FileListsArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.FileListsArea.FormattingEnabled = true;
            this.FileListsArea.HorizontalScrollbar = true;
            this.FileListsArea.Location = new System.Drawing.Point(12, 219);
            this.FileListsArea.Name = "FileListsArea";
            this.FileListsArea.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.FileListsArea.Size = new System.Drawing.Size(497, 225);
            this.FileListsArea.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.button2.Location = new System.Drawing.Point(552, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // properties
            // 
            this.properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.properties.FormattingEnabled = true;
            this.properties.Items.AddRange(new object[] {
            "parent",
            "slotcoreVersion",
            "jackpotVersion"});
            this.properties.Location = new System.Drawing.Point(12, 102);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(243, 94);
            this.properties.TabIndex = 9;
            this.properties.SelectedIndexChanged += new System.EventHandler(this.properties_SelectedIndexChanged);
            // 
            // UpdateVersionGroup
            // 
            this.UpdateVersionGroup.Controls.Add(this.last);
            this.UpdateVersionGroup.Controls.Add(this.middle);
            this.UpdateVersionGroup.Controls.Add(this.first);
            this.UpdateVersionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.UpdateVersionGroup.Location = new System.Drawing.Point(309, 102);
            this.UpdateVersionGroup.Name = "UpdateVersionGroup";
            this.UpdateVersionGroup.Size = new System.Drawing.Size(200, 111);
            this.UpdateVersionGroup.TabIndex = 10;
            this.UpdateVersionGroup.TabStop = false;
            this.UpdateVersionGroup.Text = "UpdateVersionGroup";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(6, 78);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(78, 21);
            this.last.TabIndex = 2;
            this.last.TabStop = true;
            this.last.Text = "last digit";
            this.last.UseVisualStyleBackColor = true;
            this.last.CheckedChanged += new System.EventHandler(this.selfVersion_CheckedChanged);
            // 
            // middle
            // 
            this.middle.AutoSize = true;
            this.middle.Location = new System.Drawing.Point(7, 51);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(97, 21);
            this.middle.TabIndex = 1;
            this.middle.TabStop = true;
            this.middle.Text = "middle digit";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.CheckedChanged += new System.EventHandler(this.selfVersion_CheckedChanged);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(7, 23);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(79, 21);
            this.first.TabIndex = 0;
            this.first.TabStop = true;
            this.first.Text = "first digit";
            this.first.UseVisualStyleBackColor = true;
            this.first.CheckedChanged += new System.EventHandler(this.selfVersion_CheckedChanged);
            // 
            // PomUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(714, 483);
            this.Controls.Add(this.UpdateVersionGroup);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileListsArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.TargetVersionLbl);
            this.Controls.Add(this.TargetVersion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.Name = "PomUpdate";
            this.Text = "PomUpdate";
            this.UpdateVersionGroup.ResumeLayout(false);
            this.UpdateVersionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetVersion;
        private System.Windows.Forms.Label TargetVersionLbl;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox FileListsArea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox properties;
        private System.Windows.Forms.GroupBox UpdateVersionGroup;
        private System.Windows.Forms.RadioButton last;
        private System.Windows.Forms.RadioButton middle;
        private System.Windows.Forms.RadioButton first;
    }
}

