namespace NRSSSNamespace
{
    partial class SizingPage
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
            this.SizeSelectLabel = new System.Windows.Forms.Label();
            this.SmallLabel = new System.Windows.Forms.Label();
            this.MedLabel = new System.Windows.Forms.Label();
            this.BigLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSize3 = new System.Windows.Forms.Button();
            this.btnSize2 = new System.Windows.Forms.Button();
            this.btnSize1 = new System.Windows.Forms.Button();
            this.timerSwitch = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SizeSelectLabel
            // 
            this.SizeSelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SizeSelectLabel.AutoSize = true;
            this.SizeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeSelectLabel.Location = new System.Drawing.Point(181, 30);
            this.SizeSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SizeSelectLabel.Name = "SizeSelectLabel";
            this.SizeSelectLabel.Size = new System.Drawing.Size(1602, 113);
            this.SizeSelectLabel.TabIndex = 0;
            this.SizeSelectLabel.Text = "Select A Size for the Whole Model";
            // 
            // SmallLabel
            // 
            this.SmallLabel.AutoSize = true;
            this.SmallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallLabel.Location = new System.Drawing.Point(187, 235);
            this.SmallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SmallLabel.Name = "SmallLabel";
            this.SmallLabel.Size = new System.Drawing.Size(210, 79);
            this.SmallLabel.TabIndex = 4;
            this.SmallLabel.Text = "Small";
            this.SmallLabel.Click += new System.EventHandler(this.SmallLabel_Click);
            // 
            // MedLabel
            // 
            this.MedLabel.AutoSize = true;
            this.MedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedLabel.Location = new System.Drawing.Point(838, 235);
            this.MedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MedLabel.Name = "MedLabel";
            this.MedLabel.Size = new System.Drawing.Size(283, 79);
            this.MedLabel.TabIndex = 5;
            this.MedLabel.Text = "Medium";
            // 
            // BigLabel
            // 
            this.BigLabel.AutoSize = true;
            this.BigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigLabel.Location = new System.Drawing.Point(1576, 235);
            this.BigLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BigLabel.Name = "BigLabel";
            this.BigLabel.Size = new System.Drawing.Size(136, 79);
            this.BigLabel.TabIndex = 6;
            this.BigLabel.Text = "Big";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(28, 1128);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(225, 144);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(303, 1128);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(225, 144);
            this.HomeBtn.TabIndex = 5;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.btnSize3);
            this.panel1.Controls.Add(this.btnSize2);
            this.panel1.Controls.Add(this.btnSize1);
            this.panel1.Controls.Add(this.SizeSelectLabel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.BigLabel);
            this.panel1.Controls.Add(this.SmallLabel);
            this.panel1.Controls.Add(this.MedLabel);
            this.panel1.Location = new System.Drawing.Point(63, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1950, 1298);
            this.panel1.TabIndex = 14;
            // 
            // btnSize3
            // 
            this.btnSize3.BackColor = System.Drawing.Color.Silver;
            this.btnSize3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSize3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSize3.FlatAppearance.BorderSize = 10;
            this.btnSize3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize3.Location = new System.Drawing.Point(1320, 356);
            this.btnSize3.Name = "btnSize3";
            this.btnSize3.Size = new System.Drawing.Size(630, 630);
            this.btnSize3.TabIndex = 3;
            this.btnSize3.UseVisualStyleBackColor = false;
            this.btnSize3.Click += new System.EventHandler(this.Size_Click3);
            this.btnSize3.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnSize3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyDown);
            this.btnSize3.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnSize2
            // 
            this.btnSize2.BackColor = System.Drawing.Color.Silver;
            this.btnSize2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSize2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSize2.FlatAppearance.BorderSize = 10;
            this.btnSize2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize2.Location = new System.Drawing.Point(671, 356);
            this.btnSize2.Name = "btnSize2";
            this.btnSize2.Size = new System.Drawing.Size(630, 630);
            this.btnSize2.TabIndex = 2;
            this.btnSize2.UseVisualStyleBackColor = false;
            this.btnSize2.Click += new System.EventHandler(this.Size_Click2);
            this.btnSize2.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnSize2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyDown);
            this.btnSize2.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnSize1
            // 
            this.btnSize1.BackColor = System.Drawing.Color.Silver;
            this.btnSize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSize1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSize1.FlatAppearance.BorderSize = 10;
            this.btnSize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize1.Location = new System.Drawing.Point(19, 356);
            this.btnSize1.Name = "btnSize1";
            this.btnSize1.Size = new System.Drawing.Size(630, 630);
            this.btnSize1.TabIndex = 1;
            this.btnSize1.UseVisualStyleBackColor = false;
            this.btnSize1.Click += new System.EventHandler(this.Size_Click1);
            this.btnSize1.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnSize1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyDown);
            this.btnSize1.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // timerSwitch
            // 
            this.timerSwitch.Tick += new System.EventHandler(this.timerSwitch_Tick);
            // 
            // SizingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2080, 1262);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SizingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sizes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SizingPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SizeSelectLabel;
        private System.Windows.Forms.Label SmallLabel;
        private System.Windows.Forms.Label MedLabel;
        private System.Windows.Forms.Label BigLabel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSize3;
        private System.Windows.Forms.Button btnSize2;
        private System.Windows.Forms.Button btnSize1;
        private System.Windows.Forms.Timer timerSwitch;
    }
}