namespace _158212_Assignment3
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
            this.T1_pictureBox = new System.Windows.Forms.PictureBox();
            this.T2_pictureBox = new System.Windows.Forms.PictureBox();
            this.NZ_RB1 = new System.Windows.Forms.RadioButton();
            this.USA_RB1 = new System.Windows.Forms.RadioButton();
            this.GB_RB1 = new System.Windows.Forms.RadioButton();
            this.T1_groupBox1 = new System.Windows.Forms.GroupBox();
            this.F1toF2_button = new System.Windows.Forms.Button();
            this.sameteam_warning = new System.Windows.Forms.Label();
            this.T2_groupBox2 = new System.Windows.Forms.GroupBox();
            this.NZ_RB2 = new System.Windows.Forms.RadioButton();
            this.USA_RB2 = new System.Windows.Forms.RadioButton();
            this.GB_RB2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.T1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T2_pictureBox)).BeginInit();
            this.T1_groupBox1.SuspendLayout();
            this.T2_groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // T1_pictureBox
            // 
            this.T1_pictureBox.Location = new System.Drawing.Point(25, 37);
            this.T1_pictureBox.Name = "T1_pictureBox";
            this.T1_pictureBox.Size = new System.Drawing.Size(401, 213);
            this.T1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.T1_pictureBox.TabIndex = 0;
            this.T1_pictureBox.TabStop = false;
            this.T1_pictureBox.Click += new System.EventHandler(this.T1_pictureBox_Click);
            // 
            // T2_pictureBox
            // 
            this.T2_pictureBox.Location = new System.Drawing.Point(465, 37);
            this.T2_pictureBox.Name = "T2_pictureBox";
            this.T2_pictureBox.Size = new System.Drawing.Size(373, 213);
            this.T2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.T2_pictureBox.TabIndex = 1;
            this.T2_pictureBox.TabStop = false;
            this.T2_pictureBox.Click += new System.EventHandler(this.T2_pictureBox_Click);
            // 
            // NZ_RB1
            // 
            this.NZ_RB1.AutoSize = true;
            this.NZ_RB1.Location = new System.Drawing.Point(14, 20);
            this.NZ_RB1.Name = "NZ_RB1";
            this.NZ_RB1.Size = new System.Drawing.Size(89, 16);
            this.NZ_RB1.TabIndex = 2;
            this.NZ_RB1.Text = "New Zealand";
            this.NZ_RB1.UseVisualStyleBackColor = true;
            this.NZ_RB1.CheckedChanged += new System.EventHandler(this.NZ_RB1_CheckedChanged);
            // 
            // USA_RB1
            // 
            this.USA_RB1.AutoSize = true;
            this.USA_RB1.Location = new System.Drawing.Point(14, 42);
            this.USA_RB1.Name = "USA_RB1";
            this.USA_RB1.Size = new System.Drawing.Size(41, 16);
            this.USA_RB1.TabIndex = 3;
            this.USA_RB1.Text = "USA";
            this.USA_RB1.UseVisualStyleBackColor = true;
            this.USA_RB1.CheckedChanged += new System.EventHandler(this.USA_RB1_CheckedChanged);
            // 
            // GB_RB1
            // 
            this.GB_RB1.AutoSize = true;
            this.GB_RB1.Location = new System.Drawing.Point(14, 64);
            this.GB_RB1.Name = "GB_RB1";
            this.GB_RB1.Size = new System.Drawing.Size(35, 16);
            this.GB_RB1.TabIndex = 4;
            this.GB_RB1.Text = "GB";
            this.GB_RB1.UseVisualStyleBackColor = true;
            this.GB_RB1.CheckedChanged += new System.EventHandler(this.GB_RB1_CheckedChanged);
            // 
            // T1_groupBox1
            // 
            this.T1_groupBox1.Controls.Add(this.NZ_RB1);
            this.T1_groupBox1.Controls.Add(this.USA_RB1);
            this.T1_groupBox1.Controls.Add(this.GB_RB1);
            this.T1_groupBox1.Location = new System.Drawing.Point(36, 256);
            this.T1_groupBox1.Name = "T1_groupBox1";
            this.T1_groupBox1.Size = new System.Drawing.Size(200, 100);
            this.T1_groupBox1.TabIndex = 8;
            this.T1_groupBox1.TabStop = false;
            this.T1_groupBox1.Text = "Team one";
            // 
            // F1toF2_button
            // 
            this.F1toF2_button.Location = new System.Drawing.Point(396, 397);
            this.F1toF2_button.Name = "F1toF2_button";
            this.F1toF2_button.Size = new System.Drawing.Size(75, 23);
            this.F1toF2_button.TabIndex = 10;
            this.F1toF2_button.Text = "Start";
            this.F1toF2_button.UseVisualStyleBackColor = true;
            this.F1toF2_button.Click += new System.EventHandler(this.F1toF2_button_Click);
            // 
            // sameteam_warning
            // 
            this.sameteam_warning.AutoSize = true;
            this.sameteam_warning.Location = new System.Drawing.Point(330, 367);
            this.sameteam_warning.Name = "sameteam_warning";
            this.sameteam_warning.Size = new System.Drawing.Size(239, 12);
            this.sameteam_warning.TabIndex = 11;
            this.sameteam_warning.Text = "*Please select two different countries.";
            this.sameteam_warning.Visible = false;
            // 
            // T2_groupBox2
            // 
            this.T2_groupBox2.Controls.Add(this.NZ_RB2);
            this.T2_groupBox2.Controls.Add(this.USA_RB2);
            this.T2_groupBox2.Controls.Add(this.GB_RB2);
            this.T2_groupBox2.Location = new System.Drawing.Point(638, 256);
            this.T2_groupBox2.Name = "T2_groupBox2";
            this.T2_groupBox2.Size = new System.Drawing.Size(200, 100);
            this.T2_groupBox2.TabIndex = 12;
            this.T2_groupBox2.TabStop = false;
            this.T2_groupBox2.Text = "Team two";
            // 
            // NZ_RB2
            // 
            this.NZ_RB2.AutoSize = true;
            this.NZ_RB2.Location = new System.Drawing.Point(11, 20);
            this.NZ_RB2.Name = "NZ_RB2";
            this.NZ_RB2.Size = new System.Drawing.Size(89, 16);
            this.NZ_RB2.TabIndex = 5;
            this.NZ_RB2.Text = "New Zealand";
            this.NZ_RB2.UseVisualStyleBackColor = true;
            this.NZ_RB2.CheckedChanged += new System.EventHandler(this.NZ_RB2_CheckedChanged_1);
            // 
            // USA_RB2
            // 
            this.USA_RB2.AutoSize = true;
            this.USA_RB2.Location = new System.Drawing.Point(11, 42);
            this.USA_RB2.Name = "USA_RB2";
            this.USA_RB2.Size = new System.Drawing.Size(41, 16);
            this.USA_RB2.TabIndex = 6;
            this.USA_RB2.Text = "USA";
            this.USA_RB2.UseVisualStyleBackColor = true;
            this.USA_RB2.CheckedChanged += new System.EventHandler(this.USA_RB2_CheckedChanged_1);
            // 
            // GB_RB2
            // 
            this.GB_RB2.AutoSize = true;
            this.GB_RB2.Location = new System.Drawing.Point(11, 64);
            this.GB_RB2.Name = "GB_RB2";
            this.GB_RB2.Size = new System.Drawing.Size(35, 16);
            this.GB_RB2.TabIndex = 7;
            this.GB_RB2.Text = "GB";
            this.GB_RB2.UseVisualStyleBackColor = true;
            this.GB_RB2.CheckedChanged += new System.EventHandler(this.GB_RB2_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 442);
            this.Controls.Add(this.T2_groupBox2);
            this.Controls.Add(this.sameteam_warning);
            this.Controls.Add(this.F1toF2_button);
            this.Controls.Add(this.T1_groupBox1);
            this.Controls.Add(this.T2_pictureBox);
            this.Controls.Add(this.T1_pictureBox);
            this.Name = "Form1";
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.T1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T2_pictureBox)).EndInit();
            this.T1_groupBox1.ResumeLayout(false);
            this.T1_groupBox1.PerformLayout();
            this.T2_groupBox2.ResumeLayout(false);
            this.T2_groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox T1_pictureBox;
        private System.Windows.Forms.PictureBox T2_pictureBox;
        private System.Windows.Forms.RadioButton NZ_RB1;
        private System.Windows.Forms.RadioButton USA_RB1;
        private System.Windows.Forms.RadioButton GB_RB1;
        private System.Windows.Forms.GroupBox T1_groupBox1;
        private System.Windows.Forms.Button F1toF2_button;
        private System.Windows.Forms.Label sameteam_warning;
        private System.Windows.Forms.GroupBox T2_groupBox2;
        private System.Windows.Forms.RadioButton NZ_RB2;
        private System.Windows.Forms.RadioButton USA_RB2;
        private System.Windows.Forms.RadioButton GB_RB2;
    }
}

