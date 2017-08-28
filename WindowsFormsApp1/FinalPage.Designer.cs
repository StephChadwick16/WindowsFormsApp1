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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OutputOptionsLabel = new System.Windows.Forms.Label();
            this.StudentOption = new System.Windows.Forms.Label();
            this.IntervalSelection = new System.Windows.Forms.Label();
            this.OptionSelected = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputMethodLabel = new System.Windows.Forms.Label();
            this.TimeIntLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OutputOptionsLabel
            // 
            this.OutputOptionsLabel.AutoSize = true;
            this.OutputOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputOptionsLabel.Location = new System.Drawing.Point(57, 48);
            this.OutputOptionsLabel.Name = "OutputOptionsLabel";
            this.OutputOptionsLabel.Size = new System.Drawing.Size(1684, 63);
            this.OutputOptionsLabel.TabIndex = 0;
            this.OutputOptionsLabel.Text = "These are the options that you have selected to create your model:";
            this.OutputOptionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentOption
            // 
            this.StudentOption.AutoSize = true;
            this.StudentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOption.Location = new System.Drawing.Point(257, 132);
            this.StudentOption.Name = "StudentOption";
            this.StudentOption.Size = new System.Drawing.Size(240, 37);
            this.StudentOption.TabIndex = 5;
            this.StudentOption.Text = "SHOWS NAME";
            // 
            // IntervalSelection
            // 
            this.IntervalSelection.AutoSize = true;
            this.IntervalSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalSelection.Location = new System.Drawing.Point(257, 206);
            this.IntervalSelection.Name = "IntervalSelection";
            this.IntervalSelection.Size = new System.Drawing.Size(332, 37);
            this.IntervalSelection.TabIndex = 4;
            this.IntervalSelection.Text = "SHOWS INT SELECT";
            // 
            // OptionSelected
            // 
            this.OptionSelected.AutoSize = true;
            this.OptionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionSelected.Location = new System.Drawing.Point(257, 285);
            this.OptionSelected.Name = "OptionSelected";
            this.OptionSelected.Size = new System.Drawing.Size(298, 37);
            this.OptionSelected.TabIndex = 3;
            this.OptionSelected.Text = "SHOWS INPUT OP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputMethodLabel);
            this.panel1.Controls.Add(this.TimeIntLabel);
            this.panel1.Controls.Add(this.StudentNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OptionSelected);
            this.panel1.Controls.Add(this.StudentOption);
            this.panel1.Controls.Add(this.IntervalSelection);
            this.panel1.Location = new System.Drawing.Point(68, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 400);
            this.panel1.TabIndex = 6;
            // 
            // InputMethodLabel
            // 
            this.InputMethodLabel.AutoSize = true;
            this.InputMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMethodLabel.Location = new System.Drawing.Point(27, 285);
            this.InputMethodLabel.Name = "InputMethodLabel";
            this.InputMethodLabel.Size = new System.Drawing.Size(212, 37);
            this.InputMethodLabel.TabIndex = 9;
            this.InputMethodLabel.Text = "Input Method:";
            // 
            // TimeIntLabel
            // 
            this.TimeIntLabel.AutoSize = true;
            this.TimeIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIntLabel.Location = new System.Drawing.Point(27, 206);
            this.TimeIntLabel.Name = "TimeIntLabel";
            this.TimeIntLabel.Size = new System.Drawing.Size(209, 37);
            this.TimeIntLabel.TabIndex = 8;
            this.TimeIntLabel.Text = "Time Interval:";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.Location = new System.Drawing.Point(20, 132);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(231, 37);
            this.StudentNameLabel.TabIndex = 7;
            this.StudentNameLabel.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Settings Chosen:";
            // 
            // FinalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1818, 1113);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputOptionsLabel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "FinalPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Page";
            this.Load += new System.EventHandler(this.FinalPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label OutputOptionsLabel;
        private System.Windows.Forms.Label StudentOption;
        private System.Windows.Forms.Label IntervalSelection;
        private System.Windows.Forms.Label OptionSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InputMethodLabel;
        private System.Windows.Forms.Label TimeIntLabel;
        private System.Windows.Forms.Label StudentNameLabel;
    }
}