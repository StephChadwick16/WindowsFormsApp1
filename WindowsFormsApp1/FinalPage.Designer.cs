namespace NRSSSNamespace
{
    partial class FinalPage
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
            this.OutputOptionsLabel = new System.Windows.Forms.Label();
            this.IntervalSelection = new System.Windows.Forms.Label();
            this.OptionSelected = new System.Windows.Forms.Label();
            this.SettingsAndTimesPanel = new System.Windows.Forms.Panel();
            this.InputMethodLabel = new System.Windows.Forms.Label();
            this.TimeIntLabel = new System.Windows.Forms.Label();
            this.SettingsAndTimesLabel = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.StudentOption = new System.Windows.Forms.Label();
            this.TeacherNotesBox = new System.Windows.Forms.TextBox();
            this.TeacherNotesPanel = new System.Windows.Forms.Panel();
            this.NotesObsLabel = new System.Windows.Forms.Label();
            this.OptionsSelectedPanel = new System.Windows.Forms.Panel();
            this.TimeTakenLabel = new System.Windows.Forms.Label();
            this.AveragePgTimeLabel = new System.Windows.Forms.Label();
            this.ShowsProgramTime = new System.Windows.Forms.Label();
            this.ShowsAverageTime = new System.Windows.Forms.Label();
            this.OptionsSelectedLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CategoryChosenLabel = new System.Windows.Forms.Label();
            this.ModelChosenLabel = new System.Windows.Forms.Label();
            this.SizeChosenLabel = new System.Windows.Forms.Label();
            this.ColourChosenLabel = new System.Windows.Forms.Label();
            this.ShowsModelChosen = new System.Windows.Forms.Label();
            this.ShowsCategoryChosen = new System.Windows.Forms.Label();
            this.ShowsSizeChosen = new System.Windows.Forms.Label();
            this.ShowsColourChosen = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SettingsAndTimesPanel.SuspendLayout();
            this.TeacherNotesPanel.SuspendLayout();
            this.OptionsSelectedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputOptionsLabel
            // 
            this.OutputOptionsLabel.AutoSize = true;
            this.OutputOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputOptionsLabel.Location = new System.Drawing.Point(36, 48);
            this.OutputOptionsLabel.Name = "OutputOptionsLabel";
            this.OutputOptionsLabel.Size = new System.Drawing.Size(1427, 63);
            this.OutputOptionsLabel.TabIndex = 0;
            this.OutputOptionsLabel.Text = "These are the options selected for the model created by:";
            this.OutputOptionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IntervalSelection
            // 
            this.IntervalSelection.AutoSize = true;
            this.IntervalSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalSelection.Location = new System.Drawing.Point(257, 107);
            this.IntervalSelection.Name = "IntervalSelection";
            this.IntervalSelection.Size = new System.Drawing.Size(332, 37);
            this.IntervalSelection.TabIndex = 4;
            this.IntervalSelection.Text = "SHOWS INT SELECT";
            // 
            // OptionSelected
            // 
            this.OptionSelected.AutoSize = true;
            this.OptionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionSelected.Location = new System.Drawing.Point(257, 172);
            this.OptionSelected.Name = "OptionSelected";
            this.OptionSelected.Size = new System.Drawing.Size(298, 37);
            this.OptionSelected.TabIndex = 3;
            this.OptionSelected.Text = "SHOWS INPUT OP";
            // 
            // SettingsAndTimesPanel
            // 
            this.SettingsAndTimesPanel.Controls.Add(this.ShowsAverageTime);
            this.SettingsAndTimesPanel.Controls.Add(this.ShowsProgramTime);
            this.SettingsAndTimesPanel.Controls.Add(this.AveragePgTimeLabel);
            this.SettingsAndTimesPanel.Controls.Add(this.TimeTakenLabel);
            this.SettingsAndTimesPanel.Controls.Add(this.InputMethodLabel);
            this.SettingsAndTimesPanel.Controls.Add(this.TimeIntLabel);
            this.SettingsAndTimesPanel.Controls.Add(this.SettingsAndTimesLabel);
            this.SettingsAndTimesPanel.Controls.Add(this.OptionSelected);
            this.SettingsAndTimesPanel.Controls.Add(this.IntervalSelection);
            this.SettingsAndTimesPanel.Location = new System.Drawing.Point(68, 154);
            this.SettingsAndTimesPanel.Name = "SettingsAndTimesPanel";
            this.SettingsAndTimesPanel.Size = new System.Drawing.Size(810, 400);
            this.SettingsAndTimesPanel.TabIndex = 6;
            this.SettingsAndTimesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsAndTimesPanel_Paint);
            // 
            // InputMethodLabel
            // 
            this.InputMethodLabel.AutoSize = true;
            this.InputMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMethodLabel.Location = new System.Drawing.Point(24, 172);
            this.InputMethodLabel.Name = "InputMethodLabel";
            this.InputMethodLabel.Size = new System.Drawing.Size(212, 37);
            this.InputMethodLabel.TabIndex = 9;
            this.InputMethodLabel.Text = "Input Method:";
            // 
            // TimeIntLabel
            // 
            this.TimeIntLabel.AutoSize = true;
            this.TimeIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIntLabel.Location = new System.Drawing.Point(29, 107);
            this.TimeIntLabel.Name = "TimeIntLabel";
            this.TimeIntLabel.Size = new System.Drawing.Size(209, 37);
            this.TimeIntLabel.TabIndex = 8;
            this.TimeIntLabel.Text = "Time Interval:";
            // 
            // SettingsAndTimesLabel
            // 
            this.SettingsAndTimesLabel.AutoSize = true;
            this.SettingsAndTimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAndTimesLabel.Location = new System.Drawing.Point(39, 17);
            this.SettingsAndTimesLabel.Name = "SettingsAndTimesLabel";
            this.SettingsAndTimesLabel.Size = new System.Drawing.Size(727, 46);
            this.SettingsAndTimesLabel.TabIndex = 6;
            this.SettingsAndTimesLabel.Text = "SETTINGS AND TIMES RECORDED:";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Cyan;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(68, 1110);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(206, 93);
            this.HomeBtn.TabIndex = 16;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(320, 1110);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(206, 93);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // StudentOption
            // 
            this.StudentOption.AutoSize = true;
            this.StudentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOption.ForeColor = System.Drawing.Color.Lime;
            this.StudentOption.Location = new System.Drawing.Point(1551, 48);
            this.StudentOption.Name = "StudentOption";
            this.StudentOption.Size = new System.Drawing.Size(411, 63);
            this.StudentOption.TabIndex = 10;
            this.StudentOption.Text = "SHOWS NAME";
            // 
            // TeacherNotesBox
            // 
            this.TeacherNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherNotesBox.Location = new System.Drawing.Point(14, 90);
            this.TeacherNotesBox.Multiline = true;
            this.TeacherNotesBox.Name = "TeacherNotesBox";
            this.TeacherNotesBox.Size = new System.Drawing.Size(773, 371);
            this.TeacherNotesBox.TabIndex = 18;
            // 
            // TeacherNotesPanel
            // 
            this.TeacherNotesPanel.Controls.Add(this.NotesObsLabel);
            this.TeacherNotesPanel.Controls.Add(this.TeacherNotesBox);
            this.TeacherNotesPanel.Location = new System.Drawing.Point(68, 596);
            this.TeacherNotesPanel.Name = "TeacherNotesPanel";
            this.TeacherNotesPanel.Size = new System.Drawing.Size(810, 486);
            this.TeacherNotesPanel.TabIndex = 19;
            // 
            // NotesObsLabel
            // 
            this.NotesObsLabel.AutoSize = true;
            this.NotesObsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesObsLabel.Location = new System.Drawing.Point(28, 15);
            this.NotesObsLabel.Name = "NotesObsLabel";
            this.NotesObsLabel.Size = new System.Drawing.Size(750, 46);
            this.NotesObsLabel.TabIndex = 19;
            this.NotesObsLabel.Text = "TEACHER NOTES / OBSERVATIONS:";
            // 
            // OptionsSelectedPanel
            // 
            this.OptionsSelectedPanel.Controls.Add(this.ShowsColourChosen);
            this.OptionsSelectedPanel.Controls.Add(this.ShowsSizeChosen);
            this.OptionsSelectedPanel.Controls.Add(this.ShowsCategoryChosen);
            this.OptionsSelectedPanel.Controls.Add(this.ShowsModelChosen);
            this.OptionsSelectedPanel.Controls.Add(this.ColourChosenLabel);
            this.OptionsSelectedPanel.Controls.Add(this.SizeChosenLabel);
            this.OptionsSelectedPanel.Controls.Add(this.ModelChosenLabel);
            this.OptionsSelectedPanel.Controls.Add(this.CategoryChosenLabel);
            this.OptionsSelectedPanel.Controls.Add(this.pictureBox4);
            this.OptionsSelectedPanel.Controls.Add(this.pictureBox3);
            this.OptionsSelectedPanel.Controls.Add(this.pictureBox2);
            this.OptionsSelectedPanel.Controls.Add(this.pictureBox1);
            this.OptionsSelectedPanel.Controls.Add(this.OptionsSelectedLabel);
            this.OptionsSelectedPanel.Location = new System.Drawing.Point(943, 154);
            this.OptionsSelectedPanel.Name = "OptionsSelectedPanel";
            this.OptionsSelectedPanel.Size = new System.Drawing.Size(1033, 928);
            this.OptionsSelectedPanel.TabIndex = 20;
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenLabel.Location = new System.Drawing.Point(29, 265);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(509, 37);
            this.TimeTakenLabel.TabIndex = 10;
            this.TimeTakenLabel.Text = "Time Taken to Complete Program:";
            // 
            // AveragePgTimeLabel
            // 
            this.AveragePgTimeLabel.AutoSize = true;
            this.AveragePgTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePgTimeLabel.Location = new System.Drawing.Point(29, 335);
            this.AveragePgTimeLabel.Name = "AveragePgTimeLabel";
            this.AveragePgTimeLabel.Size = new System.Drawing.Size(534, 37);
            this.AveragePgTimeLabel.TabIndex = 11;
            this.AveragePgTimeLabel.Text = "Average Time Taken for Each Page:";
            // 
            // ShowsProgramTime
            // 
            this.ShowsProgramTime.AutoSize = true;
            this.ShowsProgramTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsProgramTime.Location = new System.Drawing.Point(572, 265);
            this.ShowsProgramTime.Name = "ShowsProgramTime";
            this.ShowsProgramTime.Size = new System.Drawing.Size(194, 37);
            this.ShowsProgramTime.TabIndex = 12;
            this.ShowsProgramTime.Text = "PROG TIME";
            // 
            // ShowsAverageTime
            // 
            this.ShowsAverageTime.AutoSize = true;
            this.ShowsAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsAverageTime.Location = new System.Drawing.Point(572, 335);
            this.ShowsAverageTime.Name = "ShowsAverageTime";
            this.ShowsAverageTime.Size = new System.Drawing.Size(225, 37);
            this.ShowsAverageTime.TabIndex = 13;
            this.ShowsAverageTime.Text = "AVG PG TIME";
            // 
            // OptionsSelectedLabel
            // 
            this.OptionsSelectedLabel.AutoSize = true;
            this.OptionsSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsSelectedLabel.Location = new System.Drawing.Point(51, 17);
            this.OptionsSelectedLabel.Name = "OptionsSelectedLabel";
            this.OptionsSelectedLabel.Size = new System.Drawing.Size(922, 46);
            this.OptionsSelectedLabel.TabIndex = 0;
            this.OptionsSelectedLabel.Text = "OPTIONS SELECTED FOR MODEL CREATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(591, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 302);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(39, 610);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(396, 302);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(591, 610);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(396, 302);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // CategoryChosenLabel
            // 
            this.CategoryChosenLabel.AutoSize = true;
            this.CategoryChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryChosenLabel.Location = new System.Drawing.Point(41, 121);
            this.CategoryChosenLabel.Name = "CategoryChosenLabel";
            this.CategoryChosenLabel.Size = new System.Drawing.Size(155, 37);
            this.CategoryChosenLabel.TabIndex = 5;
            this.CategoryChosenLabel.Text = "Category:";
            // 
            // ModelChosenLabel
            // 
            this.ModelChosenLabel.AutoSize = true;
            this.ModelChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelChosenLabel.Location = new System.Drawing.Point(594, 121);
            this.ModelChosenLabel.Name = "ModelChosenLabel";
            this.ModelChosenLabel.Size = new System.Drawing.Size(112, 37);
            this.ModelChosenLabel.TabIndex = 6;
            this.ModelChosenLabel.Text = "Model:";
            // 
            // SizeChosenLabel
            // 
            this.SizeChosenLabel.AutoSize = true;
            this.SizeChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeChosenLabel.Location = new System.Drawing.Point(41, 555);
            this.SizeChosenLabel.Name = "SizeChosenLabel";
            this.SizeChosenLabel.Size = new System.Drawing.Size(87, 37);
            this.SizeChosenLabel.TabIndex = 7;
            this.SizeChosenLabel.Text = "Size:";
            // 
            // ColourChosenLabel
            // 
            this.ColourChosenLabel.AutoSize = true;
            this.ColourChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourChosenLabel.Location = new System.Drawing.Point(594, 555);
            this.ColourChosenLabel.Name = "ColourChosenLabel";
            this.ColourChosenLabel.Size = new System.Drawing.Size(121, 37);
            this.ColourChosenLabel.TabIndex = 8;
            this.ColourChosenLabel.Text = "Colour:";
            // 
            // ShowsModelChosen
            // 
            this.ShowsModelChosen.AutoSize = true;
            this.ShowsModelChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsModelChosen.Location = new System.Drawing.Point(720, 121);
            this.ShowsModelChosen.Name = "ShowsModelChosen";
            this.ShowsModelChosen.Size = new System.Drawing.Size(276, 37);
            this.ShowsModelChosen.TabIndex = 9;
            this.ShowsModelChosen.Text = "MODEL CHOSEN";
            // 
            // ShowsCategoryChosen
            // 
            this.ShowsCategoryChosen.AutoSize = true;
            this.ShowsCategoryChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsCategoryChosen.Location = new System.Drawing.Point(202, 121);
            this.ShowsCategoryChosen.Name = "ShowsCategoryChosen";
            this.ShowsCategoryChosen.Size = new System.Drawing.Size(237, 37);
            this.ShowsCategoryChosen.TabIndex = 10;
            this.ShowsCategoryChosen.Text = "CAT. CHOSEN";
            // 
            // ShowsSizeChosen
            // 
            this.ShowsSizeChosen.AutoSize = true;
            this.ShowsSizeChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsSizeChosen.Location = new System.Drawing.Point(144, 555);
            this.ShowsSizeChosen.Name = "ShowsSizeChosen";
            this.ShowsSizeChosen.Size = new System.Drawing.Size(233, 37);
            this.ShowsSizeChosen.TabIndex = 11;
            this.ShowsSizeChosen.Text = "SIZE CHOSEN";
            // 
            // ShowsColourChosen
            // 
            this.ShowsColourChosen.AutoSize = true;
            this.ShowsColourChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsColourChosen.Location = new System.Drawing.Point(720, 555);
            this.ShowsColourChosen.Name = "ShowsColourChosen";
            this.ShowsColourChosen.Size = new System.Drawing.Size(299, 37);
            this.ShowsColourChosen.TabIndex = 12;
            this.ShowsColourChosen.Text = "COLOUR CHOSEN";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Yellow;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(1656, 1116);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(283, 93);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save As";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FinalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2024, 1240);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OptionsSelectedPanel);
            this.Controls.Add(this.TeacherNotesPanel);
            this.Controls.Add(this.StudentOption);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.SettingsAndTimesPanel);
            this.Controls.Add(this.OutputOptionsLabel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "FinalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Page";
            this.Load += new System.EventHandler(this.FinalPage_Load);
            this.SettingsAndTimesPanel.ResumeLayout(false);
            this.SettingsAndTimesPanel.PerformLayout();
            this.TeacherNotesPanel.ResumeLayout(false);
            this.TeacherNotesPanel.PerformLayout();
            this.OptionsSelectedPanel.ResumeLayout(false);
            this.OptionsSelectedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OutputOptionsLabel;
        private System.Windows.Forms.Label IntervalSelection;
        private System.Windows.Forms.Label OptionSelected;
        private System.Windows.Forms.Panel SettingsAndTimesPanel;
        private System.Windows.Forms.Label SettingsAndTimesLabel;
        private System.Windows.Forms.Label InputMethodLabel;
        private System.Windows.Forms.Label TimeIntLabel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label ShowsAverageTime;
        private System.Windows.Forms.Label ShowsProgramTime;
        private System.Windows.Forms.Label AveragePgTimeLabel;
        private System.Windows.Forms.Label TimeTakenLabel;
        private System.Windows.Forms.Label StudentOption;
        private System.Windows.Forms.TextBox TeacherNotesBox;
        private System.Windows.Forms.Panel TeacherNotesPanel;
        private System.Windows.Forms.Label NotesObsLabel;
        private System.Windows.Forms.Panel OptionsSelectedPanel;
        private System.Windows.Forms.Label ShowsColourChosen;
        private System.Windows.Forms.Label ShowsSizeChosen;
        private System.Windows.Forms.Label ShowsCategoryChosen;
        private System.Windows.Forms.Label ShowsModelChosen;
        private System.Windows.Forms.Label ColourChosenLabel;
        private System.Windows.Forms.Label SizeChosenLabel;
        private System.Windows.Forms.Label ModelChosenLabel;
        private System.Windows.Forms.Label CategoryChosenLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label OptionsSelectedLabel;
        private System.Windows.Forms.Button SaveBtn;
    }
}