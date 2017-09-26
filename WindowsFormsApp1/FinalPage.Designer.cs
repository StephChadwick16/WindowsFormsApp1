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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsAndTimesPanel.SuspendLayout();
            this.TeacherNotesPanel.SuspendLayout();
            this.OptionsSelectedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputOptionsLabel
            // 
            this.OutputOptionsLabel.AutoSize = true;
            this.OutputOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputOptionsLabel.Location = new System.Drawing.Point(3, 0);
            this.OutputOptionsLabel.Name = "OutputOptionsLabel";
            this.OutputOptionsLabel.Size = new System.Drawing.Size(2070, 91);
            this.OutputOptionsLabel.TabIndex = 0;
            this.OutputOptionsLabel.Text = "These are the options selected for the model created by:";
            this.OutputOptionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IntervalSelection
            // 
            this.IntervalSelection.AutoSize = true;
            this.IntervalSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalSelection.Location = new System.Drawing.Point(416, 145);
            this.IntervalSelection.Name = "IntervalSelection";
            this.IntervalSelection.Size = new System.Drawing.Size(444, 51);
            this.IntervalSelection.TabIndex = 4;
            this.IntervalSelection.Text = "SHOWS INT SELECT";
            // 
            // OptionSelected
            // 
            this.OptionSelected.AutoSize = true;
            this.OptionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionSelected.Location = new System.Drawing.Point(416, 253);
            this.OptionSelected.Name = "OptionSelected";
            this.OptionSelected.Size = new System.Drawing.Size(398, 51);
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
            this.SettingsAndTimesPanel.Location = new System.Drawing.Point(34, 129);
            this.SettingsAndTimesPanel.Name = "SettingsAndTimesPanel";
            this.SettingsAndTimesPanel.Size = new System.Drawing.Size(1260, 586);
            this.SettingsAndTimesPanel.TabIndex = 6;
            this.SettingsAndTimesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsAndTimesPanel_Paint);
            // 
            // InputMethodLabel
            // 
            this.InputMethodLabel.AutoSize = true;
            this.InputMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMethodLabel.Location = new System.Drawing.Point(49, 253);
            this.InputMethodLabel.Name = "InputMethodLabel";
            this.InputMethodLabel.Size = new System.Drawing.Size(285, 51);
            this.InputMethodLabel.TabIndex = 9;
            this.InputMethodLabel.Text = "Input Method:";
            // 
            // TimeIntLabel
            // 
            this.TimeIntLabel.AutoSize = true;
            this.TimeIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIntLabel.Location = new System.Drawing.Point(49, 145);
            this.TimeIntLabel.Name = "TimeIntLabel";
            this.TimeIntLabel.Size = new System.Drawing.Size(283, 51);
            this.TimeIntLabel.TabIndex = 8;
            this.TimeIntLabel.Text = "Time Interval:";
            // 
            // SettingsAndTimesLabel
            // 
            this.SettingsAndTimesLabel.AutoSize = true;
            this.SettingsAndTimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsAndTimesLabel.Location = new System.Drawing.Point(132, 27);
            this.SettingsAndTimesLabel.Name = "SettingsAndTimesLabel";
            this.SettingsAndTimesLabel.Size = new System.Drawing.Size(970, 63);
            this.SettingsAndTimesLabel.TabIndex = 6;
            this.SettingsAndTimesLabel.Text = "SETTINGS AND TIMES RECORDED:";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Cyan;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(34, 1455);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(300, 180);
            this.HomeBtn.TabIndex = 16;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(433, 1455);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(300, 180);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // StudentOption
            // 
            this.StudentOption.AutoSize = true;
            this.StudentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOption.ForeColor = System.Drawing.Color.Lime;
            this.StudentOption.Location = new System.Drawing.Point(2176, 12);
            this.StudentOption.Name = "StudentOption";
            this.StudentOption.Size = new System.Drawing.Size(508, 76);
            this.StudentOption.TabIndex = 10;
            this.StudentOption.Text = "SHOWS NAME";
            // 
            // TeacherNotesBox
            // 
            this.TeacherNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherNotesBox.Location = new System.Drawing.Point(24, 144);
            this.TeacherNotesBox.Multiline = true;
            this.TeacherNotesBox.Name = "TeacherNotesBox";
            this.TeacherNotesBox.Size = new System.Drawing.Size(1206, 470);
            this.TeacherNotesBox.TabIndex = 18;
            // 
            // TeacherNotesPanel
            // 
            this.TeacherNotesPanel.Controls.Add(this.NotesObsLabel);
            this.TeacherNotesPanel.Controls.Add(this.TeacherNotesBox);
            this.TeacherNotesPanel.Location = new System.Drawing.Point(34, 752);
            this.TeacherNotesPanel.Name = "TeacherNotesPanel";
            this.TeacherNotesPanel.Size = new System.Drawing.Size(1260, 640);
            this.TeacherNotesPanel.TabIndex = 19;
            // 
            // NotesObsLabel
            // 
            this.NotesObsLabel.AutoSize = true;
            this.NotesObsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesObsLabel.Location = new System.Drawing.Point(115, 40);
            this.NotesObsLabel.Name = "NotesObsLabel";
            this.NotesObsLabel.Size = new System.Drawing.Size(998, 63);
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
            this.OptionsSelectedPanel.Location = new System.Drawing.Point(1338, 129);
            this.OptionsSelectedPanel.Name = "OptionsSelectedPanel";
            this.OptionsSelectedPanel.Size = new System.Drawing.Size(1336, 1305);
            this.OptionsSelectedPanel.TabIndex = 20;
            // 
            // TimeTakenLabel
            // 
            this.TimeTakenLabel.AutoSize = true;
            this.TimeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTakenLabel.Location = new System.Drawing.Point(50, 377);
            this.TimeTakenLabel.Name = "TimeTakenLabel";
            this.TimeTakenLabel.Size = new System.Drawing.Size(680, 51);
            this.TimeTakenLabel.TabIndex = 10;
            this.TimeTakenLabel.Text = "Time Taken to Complete Program:";
            // 
            // AveragePgTimeLabel
            // 
            this.AveragePgTimeLabel.AutoSize = true;
            this.AveragePgTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveragePgTimeLabel.Location = new System.Drawing.Point(59, 480);
            this.AveragePgTimeLabel.Name = "AveragePgTimeLabel";
            this.AveragePgTimeLabel.Size = new System.Drawing.Size(716, 51);
            this.AveragePgTimeLabel.TabIndex = 11;
            this.AveragePgTimeLabel.Text = "Average Time Taken for Each Page:";
            // 
            // ShowsProgramTime
            // 
            this.ShowsProgramTime.AutoSize = true;
            this.ShowsProgramTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsProgramTime.Location = new System.Drawing.Point(887, 377);
            this.ShowsProgramTime.Name = "ShowsProgramTime";
            this.ShowsProgramTime.Size = new System.Drawing.Size(262, 51);
            this.ShowsProgramTime.TabIndex = 12;
            this.ShowsProgramTime.Text = "PROG TIME";
            // 
            // ShowsAverageTime
            // 
            this.ShowsAverageTime.AutoSize = true;
            this.ShowsAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsAverageTime.Location = new System.Drawing.Point(896, 480);
            this.ShowsAverageTime.Name = "ShowsAverageTime";
            this.ShowsAverageTime.Size = new System.Drawing.Size(300, 51);
            this.ShowsAverageTime.TabIndex = 13;
            this.ShowsAverageTime.Text = "AVG PG TIME";
            // 
            // OptionsSelectedLabel
            // 
            this.OptionsSelectedLabel.AutoSize = true;
            this.OptionsSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsSelectedLabel.Location = new System.Drawing.Point(67, 27);
            this.OptionsSelectedLabel.Name = "OptionsSelectedLabel";
            this.OptionsSelectedLabel.Size = new System.Drawing.Size(1231, 63);
            this.OptionsSelectedLabel.TabIndex = 0;
            this.OptionsSelectedLabel.Text = "OPTIONS SELECTED FOR MODEL CREATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(766, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 450);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(88, 831);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(500, 450);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(766, 831);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(500, 450);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // CategoryChosenLabel
            // 
            this.CategoryChosenLabel.AutoSize = true;
            this.CategoryChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryChosenLabel.Location = new System.Drawing.Point(78, 145);
            this.CategoryChosenLabel.Name = "CategoryChosenLabel";
            this.CategoryChosenLabel.Size = new System.Drawing.Size(233, 55);
            this.CategoryChosenLabel.TabIndex = 5;
            this.CategoryChosenLabel.Text = "Category:";
            // 
            // ModelChosenLabel
            // 
            this.ModelChosenLabel.AutoSize = true;
            this.ModelChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelChosenLabel.Location = new System.Drawing.Point(757, 145);
            this.ModelChosenLabel.Name = "ModelChosenLabel";
            this.ModelChosenLabel.Size = new System.Drawing.Size(152, 51);
            this.ModelChosenLabel.TabIndex = 6;
            this.ModelChosenLabel.Text = "Model:";
            // 
            // SizeChosenLabel
            // 
            this.SizeChosenLabel.AutoSize = true;
            this.SizeChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeChosenLabel.Location = new System.Drawing.Point(80, 756);
            this.SizeChosenLabel.Name = "SizeChosenLabel";
            this.SizeChosenLabel.Size = new System.Drawing.Size(119, 51);
            this.SizeChosenLabel.TabIndex = 7;
            this.SizeChosenLabel.Text = "Size:";
            // 
            // ColourChosenLabel
            // 
            this.ColourChosenLabel.AutoSize = true;
            this.ColourChosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColourChosenLabel.Location = new System.Drawing.Point(757, 756);
            this.ColourChosenLabel.Name = "ColourChosenLabel";
            this.ColourChosenLabel.Size = new System.Drawing.Size(161, 51);
            this.ColourChosenLabel.TabIndex = 8;
            this.ColourChosenLabel.Text = "Colour:";
            // 
            // ShowsModelChosen
            // 
            this.ShowsModelChosen.AutoSize = true;
            this.ShowsModelChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsModelChosen.Location = new System.Drawing.Point(928, 145);
            this.ShowsModelChosen.Name = "ShowsModelChosen";
            this.ShowsModelChosen.Size = new System.Drawing.Size(317, 51);
            this.ShowsModelChosen.TabIndex = 9;
            this.ShowsModelChosen.Text = "MOD CHOSEN";
            // 
            // ShowsCategoryChosen
            // 
            this.ShowsCategoryChosen.AutoSize = true;
            this.ShowsCategoryChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsCategoryChosen.Location = new System.Drawing.Point(317, 145);
            this.ShowsCategoryChosen.Name = "ShowsCategoryChosen";
            this.ShowsCategoryChosen.Size = new System.Drawing.Size(315, 51);
            this.ShowsCategoryChosen.TabIndex = 10;
            this.ShowsCategoryChosen.Text = "CAT. CHOSEN";
            // 
            // ShowsSizeChosen
            // 
            this.ShowsSizeChosen.AutoSize = true;
            this.ShowsSizeChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsSizeChosen.Location = new System.Drawing.Point(205, 756);
            this.ShowsSizeChosen.Name = "ShowsSizeChosen";
            this.ShowsSizeChosen.Size = new System.Drawing.Size(313, 51);
            this.ShowsSizeChosen.TabIndex = 11;
            this.ShowsSizeChosen.Text = "SIZE CHOSEN";
            // 
            // ShowsColourChosen
            // 
            this.ShowsColourChosen.AutoSize = true;
            this.ShowsColourChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsColourChosen.Location = new System.Drawing.Point(928, 756);
            this.ShowsColourChosen.Name = "ShowsColourChosen";
            this.ShowsColourChosen.Size = new System.Drawing.Size(305, 51);
            this.ShowsColourChosen.TabIndex = 12;
            this.ShowsColourChosen.Text = "COL CHOSEN";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Yellow;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(2314, 1455);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(322, 180);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save As";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.OutputOptionsLabel);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.SettingsAndTimesPanel);
            this.panel1.Controls.Add(this.OptionsSelectedPanel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.TeacherNotesPanel);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.StudentOption);
            this.panel1.Location = new System.Drawing.Point(40, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2696, 1654);
            this.panel1.TabIndex = 13;
            // 
            // FinalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2774, 1729);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "FinalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}