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
            this.Interval2Sec = new System.Windows.Forms.RadioButton();
            this.Interval5Sec = new System.Windows.Forms.RadioButton();
            this.Interval10Sec = new System.Windows.Forms.RadioButton();
            this.Interval15Sec = new System.Windows.Forms.RadioButton();
            this.Interval30Sec = new System.Windows.Forms.RadioButton();
            this.Interval20Sec = new System.Windows.Forms.RadioButton();
            this.Interval25Sec = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1124, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scanning Intervals";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InputOption2
            // 
            this.InputOption2.AutoSize = true;
            this.InputOption2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption2.Location = new System.Drawing.Point(93, 589);
            this.InputOption2.Name = "InputOption2";
            this.InputOption2.Size = new System.Drawing.Size(698, 69);
            this.InputOption2.TabIndex = 3;
            this.InputOption2.Text = "Scanning - Two Switches";
            this.InputOption2.UseVisualStyleBackColor = true;
            this.InputOption2.CheckedChanged += new System.EventHandler(this.InputOption2_CheckedChanged);
            // 
            // InputOption3
            // 
            this.InputOption3.AutoSize = true;
            this.InputOption3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption3.Location = new System.Drawing.Point(93, 739);
            this.InputOption3.Name = "InputOption3";
            this.InputOption3.Size = new System.Drawing.Size(682, 69);
            this.InputOption3.TabIndex = 4;
            this.InputOption3.Text = "Manual Option (Mouse)";
            this.InputOption3.UseVisualStyleBackColor = true;
            this.InputOption3.CheckedChanged += new System.EventHandler(this.InputOption3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Options";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ChildNameTextbox
            // 
            this.ChildNameTextbox.BackColor = System.Drawing.Color.Black;
            this.ChildNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildNameTextbox.ForeColor = System.Drawing.Color.White;
            this.ChildNameTextbox.Location = new System.Drawing.Point(89, 1204);
            this.ChildNameTextbox.Name = "ChildNameTextbox";
            this.ChildNameTextbox.Size = new System.Drawing.Size(889, 98);
            this.ChildNameTextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 1054);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(809, 80);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter child\'s name here:";
            // 
            // StartModellingButton
            // 
            this.StartModellingButton.BackColor = System.Drawing.Color.Yellow;
            this.StartModellingButton.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartModellingButton.ForeColor = System.Drawing.Color.Black;
            this.StartModellingButton.Location = new System.Drawing.Point(1397, 1175);
            this.StartModellingButton.Name = "StartModellingButton";
            this.StartModellingButton.Size = new System.Drawing.Size(413, 209);
            this.StartModellingButton.TabIndex = 8;
            this.StartModellingButton.Text = "LET\'S START MODELLING!";
            this.StartModellingButton.UseVisualStyleBackColor = false;
            this.StartModellingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputOption1
            // 
            this.InputOption1.AutoSize = true;
            this.InputOption1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOption1.Location = new System.Drawing.Point(93, 448);
            this.InputOption1.Name = "InputOption1";
            this.InputOption1.Size = new System.Drawing.Size(652, 69);
            this.InputOption1.TabIndex = 9;
            this.InputOption1.Text = "Scanning - One Switch";
            this.InputOption1.UseVisualStyleBackColor = true;
            this.InputOption1.CheckedChanged += new System.EventHandler(this.InputOption1_CheckedChanged_1);
            // 
            // Interval2Sec
            // 
            this.Interval2Sec.AutoSize = true;
            this.Interval2Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval2Sec.Location = new System.Drawing.Point(1076, 448);
            this.Interval2Sec.Name = "Interval2Sec";
            this.Interval2Sec.Size = new System.Drawing.Size(321, 69);
            this.Interval2Sec.TabIndex = 10;
            this.Interval2Sec.TabStop = true;
            this.Interval2Sec.Text = "2 seconds";
            this.Interval2Sec.UseVisualStyleBackColor = true;
            this.Interval2Sec.CheckedChanged += new System.EventHandler(this.Interval2Sec_CheckedChanged);
            // 
            // Interval5Sec
            // 
            this.Interval5Sec.AutoSize = true;
            this.Interval5Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval5Sec.Location = new System.Drawing.Point(1076, 589);
            this.Interval5Sec.Name = "Interval5Sec";
            this.Interval5Sec.Size = new System.Drawing.Size(321, 69);
            this.Interval5Sec.TabIndex = 11;
            this.Interval5Sec.TabStop = true;
            this.Interval5Sec.Text = "5 seconds";
            this.Interval5Sec.UseVisualStyleBackColor = true;
            this.Interval5Sec.CheckedChanged += new System.EventHandler(this.Interval5Sec_CheckedChanged);
            // 
            // Interval10Sec
            // 
            this.Interval10Sec.AutoSize = true;
            this.Interval10Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval10Sec.Location = new System.Drawing.Point(1076, 722);
            this.Interval10Sec.Name = "Interval10Sec";
            this.Interval10Sec.Size = new System.Drawing.Size(351, 69);
            this.Interval10Sec.TabIndex = 12;
            this.Interval10Sec.TabStop = true;
            this.Interval10Sec.Text = "10 seconds";
            this.Interval10Sec.UseVisualStyleBackColor = true;
            this.Interval10Sec.CheckedChanged += new System.EventHandler(this.Interval10Sec_CheckedChanged);
            // 
            // Interval15Sec
            // 
            this.Interval15Sec.AutoSize = true;
            this.Interval15Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval15Sec.Location = new System.Drawing.Point(1076, 856);
            this.Interval15Sec.Name = "Interval15Sec";
            this.Interval15Sec.Size = new System.Drawing.Size(351, 69);
            this.Interval15Sec.TabIndex = 13;
            this.Interval15Sec.TabStop = true;
            this.Interval15Sec.Text = "15 seconds";
            this.Interval15Sec.UseVisualStyleBackColor = true;
            this.Interval15Sec.CheckedChanged += new System.EventHandler(this.Interval15Sec_CheckedChanged);
            // 
            // Interval30Sec
            // 
            this.Interval30Sec.AutoSize = true;
            this.Interval30Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval30Sec.Location = new System.Drawing.Point(1459, 798);
            this.Interval30Sec.Name = "Interval30Sec";
            this.Interval30Sec.Size = new System.Drawing.Size(351, 69);
            this.Interval30Sec.TabIndex = 14;
            this.Interval30Sec.TabStop = true;
            this.Interval30Sec.Text = "30 seconds";
            this.Interval30Sec.UseVisualStyleBackColor = true;
            this.Interval30Sec.CheckedChanged += new System.EventHandler(this.Interval30Sec_CheckedChanged);
            // 
            // Interval20Sec
            // 
            this.Interval20Sec.AutoSize = true;
            this.Interval20Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval20Sec.Location = new System.Drawing.Point(1459, 533);
            this.Interval20Sec.Name = "Interval20Sec";
            this.Interval20Sec.Size = new System.Drawing.Size(351, 69);
            this.Interval20Sec.TabIndex = 15;
            this.Interval20Sec.TabStop = true;
            this.Interval20Sec.Text = "20 seconds";
            this.Interval20Sec.UseVisualStyleBackColor = true;
            this.Interval20Sec.CheckedChanged += new System.EventHandler(this.Interval20Sec_CheckedChanged);
            // 
            // Interval25Sec
            // 
            this.Interval25Sec.AutoSize = true;
            this.Interval25Sec.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval25Sec.Location = new System.Drawing.Point(1459, 661);
            this.Interval25Sec.Name = "Interval25Sec";
            this.Interval25Sec.Size = new System.Drawing.Size(351, 69);
            this.Interval25Sec.TabIndex = 16;
            this.Interval25Sec.TabStop = true;
            this.Interval25Sec.Text = "25 seconds";
            this.Interval25Sec.UseVisualStyleBackColor = true;
            this.Interval25Sec.CheckedChanged += new System.EventHandler(this.Interval25Sec_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Interval25Sec);
            this.panel1.Controls.Add(this.InputOption2);
            this.panel1.Controls.Add(this.Interval20Sec);
            this.panel1.Controls.Add(this.InputOption3);
            this.panel1.Controls.Add(this.Interval30Sec);
            this.panel1.Controls.Add(this.ChildNameTextbox);
            this.panel1.Controls.Add(this.Interval15Sec);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Interval10Sec);
            this.panel1.Controls.Add(this.InputOption1);
            this.panel1.Controls.Add(this.Interval5Sec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Interval2Sec);
            this.panel1.Controls.Add(this.StartModellingButton);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1813, 1387);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.ClientSize = new System.Drawing.Size(1894, 1465);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp1.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.HelpButton = true;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::WindowsFormsApp1.Properties.Settings.Default.Title;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton Interval2Sec;
        private System.Windows.Forms.RadioButton Interval5Sec;
        private System.Windows.Forms.RadioButton Interval10Sec;
        private System.Windows.Forms.RadioButton Interval15Sec;
        private System.Windows.Forms.RadioButton Interval30Sec;
        private System.Windows.Forms.RadioButton Interval20Sec;
        private System.Windows.Forms.RadioButton Interval25Sec;
        private System.Windows.Forms.Panel panel1;
    }
}

