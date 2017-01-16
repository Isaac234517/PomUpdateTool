namespace UpdatePomVersion
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
            this.TargetVersion = new System.Windows.Forms.TextBox();
            this.TargetVersionLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetVersion
            // 
            this.TargetVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetVersion.Location = new System.Drawing.Point(147, 85);
            this.TargetVersion.Name = "TargetVersion";
            this.TargetVersion.Size = new System.Drawing.Size(100, 23);
            this.TargetVersion.TabIndex = 0;
            // 
            // TargetVersionLbl
            // 
            this.TargetVersionLbl.AutoSize = true;
            this.TargetVersionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TargetVersionLbl.Location = new System.Drawing.Point(23, 88);
            this.TargetVersionLbl.Name = "TargetVersionLbl";
            this.TargetVersionLbl.Size = new System.Drawing.Size(102, 17);
            this.TargetVersionLbl.TabIndex = 1;
            this.TargetVersionLbl.Text = "Target Version";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(166, 152);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(106, 29);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open Files";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.TargetVersionLbl);
            this.Controls.Add(this.TargetVersion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TargetVersion;
        private System.Windows.Forms.Label TargetVersionLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
    }
}

