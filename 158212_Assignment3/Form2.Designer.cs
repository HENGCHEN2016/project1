namespace _158212_Assignment3
{
    partial class Form2
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
            this.F2T1_pictureBox = new System.Windows.Forms.PictureBox();
            this.F2T2_pictureBox = new System.Windows.Forms.PictureBox();
            this.score_label = new System.Windows.Forms.Label();
            this.T1score_label = new System.Windows.Forms.Label();
            this.T2score_label = new System.Windows.Forms.Label();
            this.T1try_button = new System.Windows.Forms.Button();
            this.T1c_button = new System.Windows.Forms.Button();
            this.T1p_button = new System.Windows.Forms.Button();
            this.T1DK_button = new System.Windows.Forms.Button();
            this.T2t_button = new System.Windows.Forms.Button();
            this.T2c_button = new System.Windows.Forms.Button();
            this.T2p_button = new System.Windows.Forms.Button();
            this.T2dk_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.End_button = new System.Windows.Forms.Button();
            this.T2_comboBox = new System.Windows.Forms.ComboBox();
            this.F2_richTextBox = new System.Windows.Forms.RichTextBox();
            this.match_timer = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.T1_no_player_label = new System.Windows.Forms.Label();
            this.T2_no_player_label = new System.Windows.Forms.Label();
            this.T1_score_groupBox = new System.Windows.Forms.GroupBox();
            this.T2_score_groupBox = new System.Windows.Forms.GroupBox();
            this.T1_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.F2T1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2T2_pictureBox)).BeginInit();
            this.T1_score_groupBox.SuspendLayout();
            this.T2_score_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // F2T1_pictureBox
            // 
            this.F2T1_pictureBox.Location = new System.Drawing.Point(22, 46);
            this.F2T1_pictureBox.Name = "F2T1_pictureBox";
            this.F2T1_pictureBox.Size = new System.Drawing.Size(100, 50);
            this.F2T1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F2T1_pictureBox.TabIndex = 0;
            this.F2T1_pictureBox.TabStop = false;
            // 
            // F2T2_pictureBox
            // 
            this.F2T2_pictureBox.Location = new System.Drawing.Point(303, 46);
            this.F2T2_pictureBox.Name = "F2T2_pictureBox";
            this.F2T2_pictureBox.Size = new System.Drawing.Size(100, 50);
            this.F2T2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F2T2_pictureBox.TabIndex = 1;
            this.F2T2_pictureBox.TabStop = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.SystemColors.Highlight;
            this.score_label.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.score_label.Location = new System.Drawing.Point(161, 85);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(88, 29);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "Score";
            // 
            // T1score_label
            // 
            this.T1score_label.AutoSize = true;
            this.T1score_label.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T1score_label.Location = new System.Drawing.Point(148, 132);
            this.T1score_label.Name = "T1score_label";
            this.T1score_label.Size = new System.Drawing.Size(21, 21);
            this.T1score_label.TabIndex = 3;
            this.T1score_label.Text = "0";
            // 
            // T2score_label
            // 
            this.T2score_label.AutoSize = true;
            this.T2score_label.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T2score_label.Location = new System.Drawing.Point(246, 136);
            this.T2score_label.Name = "T2score_label";
            this.T2score_label.Size = new System.Drawing.Size(21, 21);
            this.T2score_label.TabIndex = 4;
            this.T2score_label.Text = "0";
            // 
            // T1try_button
            // 
            this.T1try_button.Enabled = false;
            this.T1try_button.Location = new System.Drawing.Point(6, 20);
            this.T1try_button.Name = "T1try_button";
            this.T1try_button.Size = new System.Drawing.Size(75, 23);
            this.T1try_button.TabIndex = 6;
            this.T1try_button.Text = "Try";
            this.T1try_button.UseVisualStyleBackColor = true;
            this.T1try_button.Click += new System.EventHandler(this.T1try_button_Click);
            // 
            // T1c_button
            // 
            this.T1c_button.Enabled = false;
            this.T1c_button.Location = new System.Drawing.Point(6, 45);
            this.T1c_button.Name = "T1c_button";
            this.T1c_button.Size = new System.Drawing.Size(75, 23);
            this.T1c_button.TabIndex = 7;
            this.T1c_button.Text = "Conversion";
            this.T1c_button.UseVisualStyleBackColor = true;
            this.T1c_button.Click += new System.EventHandler(this.T1c_button_Click);
            // 
            // T1p_button
            // 
            this.T1p_button.Enabled = false;
            this.T1p_button.Location = new System.Drawing.Point(6, 74);
            this.T1p_button.Name = "T1p_button";
            this.T1p_button.Size = new System.Drawing.Size(75, 23);
            this.T1p_button.TabIndex = 8;
            this.T1p_button.Text = "Penalty";
            this.T1p_button.UseVisualStyleBackColor = true;
            this.T1p_button.Click += new System.EventHandler(this.T1p_button_Click);
            // 
            // T1DK_button
            // 
            this.T1DK_button.Enabled = false;
            this.T1DK_button.Location = new System.Drawing.Point(6, 102);
            this.T1DK_button.Name = "T1DK_button";
            this.T1DK_button.Size = new System.Drawing.Size(75, 23);
            this.T1DK_button.TabIndex = 9;
            this.T1DK_button.Text = "Drop Kick";
            this.T1DK_button.UseVisualStyleBackColor = true;
            this.T1DK_button.Click += new System.EventHandler(this.T1DK_button_Click);
            // 
            // T2t_button
            // 
            this.T2t_button.Enabled = false;
            this.T2t_button.Location = new System.Drawing.Point(6, 20);
            this.T2t_button.Name = "T2t_button";
            this.T2t_button.Size = new System.Drawing.Size(75, 23);
            this.T2t_button.TabIndex = 10;
            this.T2t_button.Text = "Try";
            this.T2t_button.UseVisualStyleBackColor = true;
            this.T2t_button.Click += new System.EventHandler(this.T2t_button_Click);
            // 
            // T2c_button
            // 
            this.T2c_button.Enabled = false;
            this.T2c_button.Location = new System.Drawing.Point(6, 49);
            this.T2c_button.Name = "T2c_button";
            this.T2c_button.Size = new System.Drawing.Size(75, 23);
            this.T2c_button.TabIndex = 11;
            this.T2c_button.Text = "Conversion";
            this.T2c_button.UseVisualStyleBackColor = true;
            this.T2c_button.Click += new System.EventHandler(this.T2c_button_Click);
            // 
            // T2p_button
            // 
            this.T2p_button.Enabled = false;
            this.T2p_button.Location = new System.Drawing.Point(6, 78);
            this.T2p_button.Name = "T2p_button";
            this.T2p_button.Size = new System.Drawing.Size(75, 23);
            this.T2p_button.TabIndex = 12;
            this.T2p_button.Text = "Penalty";
            this.T2p_button.UseVisualStyleBackColor = true;
            this.T2p_button.Click += new System.EventHandler(this.T2p_button_Click);
            // 
            // T2dk_button
            // 
            this.T2dk_button.Enabled = false;
            this.T2dk_button.Location = new System.Drawing.Point(6, 107);
            this.T2dk_button.Name = "T2dk_button";
            this.T2dk_button.Size = new System.Drawing.Size(75, 23);
            this.T2dk_button.TabIndex = 13;
            this.T2dk_button.Text = "Drop Kick";
            this.T2dk_button.UseVisualStyleBackColor = true;
            this.T2dk_button.Click += new System.EventHandler(this.T2dk_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(84, 253);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(75, 23);
            this.Pause_button.TabIndex = 15;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // End_button
            // 
            this.End_button.Location = new System.Drawing.Point(168, 253);
            this.End_button.Name = "End_button";
            this.End_button.Size = new System.Drawing.Size(75, 23);
            this.End_button.TabIndex = 16;
            this.End_button.Text = "End";
            this.End_button.UseVisualStyleBackColor = true;
            this.End_button.Click += new System.EventHandler(this.End_button_Click);
            // 
            // T2_comboBox
            // 
            this.T2_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T2_comboBox.FormattingEnabled = true;
            this.T2_comboBox.Location = new System.Drawing.Point(321, 311);
            this.T2_comboBox.Name = "T2_comboBox";
            this.T2_comboBox.Size = new System.Drawing.Size(121, 20);
            this.T2_comboBox.TabIndex = 18;
            this.T2_comboBox.SelectedIndexChanged += new System.EventHandler(this.T2_comboBox_SelectedIndexChanged);
            // 
            // F2_richTextBox
            // 
            this.F2_richTextBox.Location = new System.Drawing.Point(22, 337);
            this.F2_richTextBox.Name = "F2_richTextBox";
            this.F2_richTextBox.Size = new System.Drawing.Size(381, 96);
            this.F2_richTextBox.TabIndex = 19;
            this.F2_richTextBox.Text = "";
            // 
            // match_timer
            // 
            this.match_timer.Interval = 1000;
            this.match_timer.Tick += new System.EventHandler(this.match_timer_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(194, 195);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 12);
            this.time_label.TabIndex = 20;
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(260, 253);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 21;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // T1_no_player_label
            // 
            this.T1_no_player_label.AutoSize = true;
            this.T1_no_player_label.Location = new System.Drawing.Point(17, 294);
            this.T1_no_player_label.Name = "T1_no_player_label";
            this.T1_no_player_label.Size = new System.Drawing.Size(107, 12);
            this.T1_no_player_label.TabIndex = 22;
            this.T1_no_player_label.Text = "* Select a player";
            // 
            // T2_no_player_label
            // 
            this.T2_no_player_label.AutoSize = true;
            this.T2_no_player_label.Location = new System.Drawing.Point(319, 294);
            this.T2_no_player_label.Name = "T2_no_player_label";
            this.T2_no_player_label.Size = new System.Drawing.Size(107, 12);
            this.T2_no_player_label.TabIndex = 23;
            this.T2_no_player_label.Text = "* Select a player";
            // 
            // T1_score_groupBox
            // 
            this.T1_score_groupBox.Controls.Add(this.T1try_button);
            this.T1_score_groupBox.Controls.Add(this.T1c_button);
            this.T1_score_groupBox.Controls.Add(this.T1p_button);
            this.T1_score_groupBox.Controls.Add(this.T1DK_button);
            this.T1_score_groupBox.Location = new System.Drawing.Point(22, 116);
            this.T1_score_groupBox.Name = "T1_score_groupBox";
            this.T1_score_groupBox.Size = new System.Drawing.Size(90, 131);
            this.T1_score_groupBox.TabIndex = 24;
            this.T1_score_groupBox.TabStop = false;
            this.T1_score_groupBox.Text = "team one";
            // 
            // T2_score_groupBox
            // 
            this.T2_score_groupBox.Controls.Add(this.T2t_button);
            this.T2_score_groupBox.Controls.Add(this.T2c_button);
            this.T2_score_groupBox.Controls.Add(this.T2p_button);
            this.T2_score_groupBox.Controls.Add(this.T2dk_button);
            this.T2_score_groupBox.Location = new System.Drawing.Point(309, 116);
            this.T2_score_groupBox.Name = "T2_score_groupBox";
            this.T2_score_groupBox.Size = new System.Drawing.Size(94, 131);
            this.T2_score_groupBox.TabIndex = 25;
            this.T2_score_groupBox.TabStop = false;
            this.T2_score_groupBox.Text = "team two";
            // 
            // T1_comboBox
            // 
            this.T1_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T1_comboBox.FormattingEnabled = true;
            this.T1_comboBox.Location = new System.Drawing.Point(12, 311);
            this.T1_comboBox.Name = "T1_comboBox";
            this.T1_comboBox.Size = new System.Drawing.Size(121, 20);
            this.T1_comboBox.TabIndex = 17;
            this.T1_comboBox.SelectedIndexChanged += new System.EventHandler(this.T1_comboBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 441);
            this.Controls.Add(this.T2_score_groupBox);
            this.Controls.Add(this.T1_score_groupBox);
            this.Controls.Add(this.T2_no_player_label);
            this.Controls.Add(this.T1_no_player_label);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.F2_richTextBox);
            this.Controls.Add(this.T2_comboBox);
            this.Controls.Add(this.T1_comboBox);
            this.Controls.Add(this.End_button);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.T2score_label);
            this.Controls.Add(this.T1score_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.F2T2_pictureBox);
            this.Controls.Add(this.F2T1_pictureBox);
            this.Name = "Form2";
            this.Text = "Rugby Match";
            ((System.ComponentModel.ISupportInitialize)(this.F2T1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2T2_pictureBox)).EndInit();
            this.T1_score_groupBox.ResumeLayout(false);
            this.T2_score_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox F2T1_pictureBox;
        private System.Windows.Forms.PictureBox F2T2_pictureBox;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label T1score_label;
        private System.Windows.Forms.Label T2score_label;
        private System.Windows.Forms.Button T1try_button;
        private System.Windows.Forms.Button T1c_button;
        private System.Windows.Forms.Button T1p_button;
        private System.Windows.Forms.Button T1DK_button;
        private System.Windows.Forms.Button T2t_button;
        private System.Windows.Forms.Button T2c_button;
        private System.Windows.Forms.Button T2p_button;
        private System.Windows.Forms.Button T2dk_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button End_button;
        private System.Windows.Forms.ComboBox T2_comboBox;
        private System.Windows.Forms.RichTextBox F2_richTextBox;
        private System.Windows.Forms.Timer match_timer;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Label T1_no_player_label;
        private System.Windows.Forms.Label T2_no_player_label;
        private System.Windows.Forms.GroupBox T1_score_groupBox;
        private System.Windows.Forms.GroupBox T2_score_groupBox;
        private System.Windows.Forms.ComboBox T1_comboBox;
    }
}