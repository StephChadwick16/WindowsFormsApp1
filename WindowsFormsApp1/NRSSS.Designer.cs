namespace NRSSSNamespace
{
    partial class StartPage
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
                //if (e.KeyChar == (char)Keys.Enter)
                //{
                   // MessageBox.Show("Enter key pressed");
                //}
                //if (e.KeyChar == 13)
                //{
                   // MessageBox.Show("Enter key pressed");
                //}

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputOption2 = new System.Windows.Forms.RadioButton();
            this.InputOption3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ChildNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartModellingButton = new System.Windows.Forms.Button();
            this.InputOption1 = new System.Windows.Forms.RadioButton();
            this.Interval10Sec = new System.Windows.Forms.RadioButton();
            this.Interval20Sec = new System.Windows.Forms.RadioButton();
            this.Interval30Sec = new System.Windows.Forms.RadioButton();
            this.Interval1Min = new System.Windows.Forms.RadioButton();
            this.Interval1HalfMin = new System.Windows.Forms.RadioButton();
            this.Interval2Min = new System.Windows.Forms.RadioButton();
            this.Interval5Min = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scanning Intervals";
            // 
            // InputOption2
            // 
            this.InputOption2.AutoSize = true;
            this.InputOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption2.Location = new System.Drawing.Point(47, 534);
            this.InputOption2.Name = "InputOption2";
            this.InputOption2.Size = new System.Drawing.Size(663, 67);
            this.InputOption2.TabIndex = 3;
            this.InputOption2.Text = "Scanning - Two Switches";
            this.InputOption2.UseVisualStyleBackColor = true;
            this.InputOption2.CheckedChanged += new System.EventHandler(this.InputOption2_CheckedChanged);
            // 
            // InputOption3
            // 
            this.InputOption3.AutoSize = true;
            this.InputOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption3.Location = new System.Drawing.Point(47, 643);
            this.InputOption3.Name = "InputOption3";
            this.InputOption3.Size = new System.Drawing.Size(622, 67);
            this.InputOption3.TabIndex = 4;
            this.InputOption3.Text = "Manual Option (Mouse)";
            this.InputOption3.UseVisualStyleBackColor = true;
            this.InputOption3.CheckedChanged += new System.EventHandler(this.InputOption3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 76);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Options";
            // 
            // ChildNameTextbox
            // 
            this.ChildNameTextbox.BackColor = System.Drawing.Color.Black;
            this.ChildNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildNameTextbox.ForeColor = System.Drawing.Color.White;
            this.ChildNameTextbox.Location = new System.Drawing.Point(58, 968);
            this.ChildNameTextbox.Name = "ChildNameTextbox";
            this.ChildNameTextbox.Size = new System.Drawing.Size(611, 53);
            this.ChildNameTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 845);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(630, 63);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter child\'s name here:";
            // 
            // StartModellingButton
            // 
            this.StartModellingButton.BackColor = System.Drawing.Color.Yellow;
            this.StartModellingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartModellingButton.ForeColor = System.Drawing.Color.Black;
            this.StartModellingButton.Location = new System.Drawing.Point(1363, 950);
            this.StartModellingButton.Name = "StartModellingButton";
            this.StartModellingButton.Size = new System.Drawing.Size(332, 130);
            this.StartModellingButton.TabIndex = 8;
            this.StartModellingButton.Text = "LET\'S START MODELLING!";
            this.StartModellingButton.UseVisualStyleBackColor = false;
            this.StartModellingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputOption1
            // 
            this.InputOption1.AutoSize = true;
            this.InputOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption1.Location = new System.Drawing.Point(47, 423);
            this.InputOption1.Name = "InputOption1";
            this.InputOption1.Size = new System.Drawing.Size(606, 67);
            this.InputOption1.TabIndex = 9;
            this.InputOption1.Text = "Scanning - One Switch";
            this.InputOption1.UseVisualStyleBackColor = true;
            this.InputOption1.CheckedChanged += new System.EventHandler(this.InputOption1_CheckedChanged_1);
            // 
            // Interval10Sec
            // 
            this.Interval10Sec.AutoSize = true;
            this.Interval10Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval10Sec.Location = new System.Drawing.Point(966, 417);
            this.Interval10Sec.Name = "Interval10Sec";
            this.Interval10Sec.Size = new System.Drawing.Size(256, 50);
            this.Interval10Sec.TabIndex = 10;
            this.Interval10Sec.TabStop = true;
            this.Interval10Sec.Text = "10 seconds";
            this.Interval10Sec.UseVisualStyleBackColor = true;
            this.Interval10Sec.CheckedChanged += new System.EventHandler(this.Interval10Sec_CheckedChanged);
            // 
            // Interval20Sec
            // 
            this.Interval20Sec.AutoSize = true;
            this.Interval20Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval20Sec.Location = new System.Drawing.Point(966, 502);
            this.Interval20Sec.Name = "Interval20Sec";
            this.Interval20Sec.Size = new System.Drawing.Size(256, 50);
            this.Interval20Sec.TabIndex = 11;
            this.Interval20Sec.TabStop = true;
            this.Interval20Sec.Text = "20 seconds";
            this.Interval20Sec.UseVisualStyleBackColor = true;
            this.Interval20Sec.CheckedChanged += new System.EventHandler(this.Interval20Sec_CheckedChanged);
            // 
            // Interval30Sec
            // 
            this.Interval30Sec.AutoSize = true;
            this.Interval30Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval30Sec.Location = new System.Drawing.Point(966, 589);
            this.Interval30Sec.Name = "Interval30Sec";
            this.Interval30Sec.Size = new System.Drawing.Size(256, 50);
            this.Interval30Sec.TabIndex = 12;
            this.Interval30Sec.TabStop = true;
            this.Interval30Sec.Text = "30 seconds";
            this.Interval30Sec.UseVisualStyleBackColor = true;
            this.Interval30Sec.CheckedChanged += new System.EventHandler(this.Interval30Sec_CheckedChanged);
            // 
            // Interval1Min
            // 
            this.Interval1Min.AutoSize = true;
            this.Interval1Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval1Min.Location = new System.Drawing.Point(966, 670);
            this.Interval1Min.Name = "Interval1Min";
            this.Interval1Min.Size = new System.Drawing.Size(203, 50);
            this.Interval1Min.TabIndex = 13;
            this.Interval1Min.TabStop = true;
            this.Interval1Min.Text = "1 minute";
            this.Interval1Min.UseVisualStyleBackColor = true;
            this.Interval1Min.CheckedChanged += new System.EventHandler(this.Interval1Min_CheckedChanged);
            // 
            // Interval1HalfMin
            // 
            this.Interval1HalfMin.AutoSize = true;
            this.Interval1HalfMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval1HalfMin.Location = new System.Drawing.Point(966, 750);
            this.Interval1HalfMin.Name = "Interval1HalfMin";
            this.Interval1HalfMin.Size = new System.Drawing.Size(256, 50);
            this.Interval1HalfMin.TabIndex = 14;
            this.Interval1HalfMin.TabStop = true;
            this.Interval1HalfMin.Text = "1.5 minutes";
            this.Interval1HalfMin.UseVisualStyleBackColor = true;
            this.Interval1HalfMin.CheckedChanged += new System.EventHandler(this.Interval1HalfMin_CheckedChanged);
            // 
            // Interval2Min
            // 
            this.Interval2Min.AutoSize = true;
            this.Interval2Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval2Min.Location = new System.Drawing.Point(966, 833);
            this.Interval2Min.Name = "Interval2Min";
            this.Interval2Min.Size = new System.Drawing.Size(223, 50);
            this.Interval2Min.TabIndex = 15;
            this.Interval2Min.TabStop = true;
            this.Interval2Min.Text = "2 minutes";
            this.Interval2Min.UseVisualStyleBackColor = true;
            this.Interval2Min.CheckedChanged += new System.EventHandler(this.Interval2Min_CheckedChanged);
            // 
            // Interval5Min
            // 
            this.Interval5Min.AutoSize = true;
            this.Interval5Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval5Min.Location = new System.Drawing.Point(966, 911);
            this.Interval5Min.Name = "Interval5Min";
            this.Interval5Min.Size = new System.Drawing.Size(223, 50);
            this.Interval5Min.TabIndex = 16;
            this.Interval5Min.TabStop = true;
            this.Interval5Min.Text = "5 minutes";
            this.Interval5Min.UseVisualStyleBackColor = true;
            this.Interval5Min.CheckedChanged += new System.EventHandler(this.Interval5Min_CheckedChanged);
            // 
            // StartPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1788, 1141);
            this.Controls.Add(this.Interval5Min);
            this.Controls.Add(this.Interval2Min);
            this.Controls.Add(this.Interval1HalfMin);
            this.Controls.Add(this.Interval1Min);
            this.Controls.Add(this.Interval30Sec);
            this.Controls.Add(this.Interval20Sec);
            this.Controls.Add(this.Interval10Sec);
            this.Controls.Add(this.InputOption1);
            this.Controls.Add(this.StartModellingButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChildNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputOption3);
            this.Controls.Add(this.InputOption2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.HelpButton = true;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::WindowsFormsApp1.Properties.Settings.Default.Title;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton InputOption3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChildNameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartModellingButton;
        private System.Windows.Forms.RadioButton InputOption2;
        private System.Windows.Forms.RadioButton InputOption1;
        private System.Windows.Forms.RadioButton Interval10Sec;
        private System.Windows.Forms.RadioButton Interval20Sec;
        private System.Windows.Forms.RadioButton Interval30Sec;
        private System.Windows.Forms.RadioButton Interval1Min;
        private System.Windows.Forms.RadioButton Interval1HalfMin;
        private System.Windows.Forms.RadioButton Interval2Min;
        private System.Windows.Forms.RadioButton Interval5Min;
    }
}

