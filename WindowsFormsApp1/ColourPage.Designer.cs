namespace NRSSSNamespace
{
    partial class ColourPage
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
            this.SelectColourLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColour8 = new System.Windows.Forms.Button();
            this.btnColour7 = new System.Windows.Forms.Button();
            this.btnColour6 = new System.Windows.Forms.Button();
            this.btnColour4 = new System.Windows.Forms.Button();
            this.btnColour3 = new System.Windows.Forms.Button();
            this.btnColour2 = new System.Windows.Forms.Button();
            this.btnColour5 = new System.Windows.Forms.Button();
            this.btnColour1 = new System.Windows.Forms.Button();
            this.timerSwitch = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectColourLabel
            // 
            this.SelectColourLabel.AutoSize = true;
            this.SelectColourLabel.Font = new System.Drawing.Font("Century Gothic", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectColourLabel.Location = new System.Drawing.Point(278, 21);
            this.SelectColourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectColourLabel.Name = "SelectColourLabel";
            this.SelectColourLabel.Size = new System.Drawing.Size(434, 64);
            this.SelectColourLabel.TabIndex = 0;
            this.SelectColourLabel.Text = "Select A Colour";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(26, 657);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(125, 78);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(208, 657);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(125, 78);
            this.HomeBtn.TabIndex = 9;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnColour8);
            this.panel1.Controls.Add(this.btnColour7);
            this.panel1.Controls.Add(this.btnColour6);
            this.panel1.Controls.Add(this.btnColour4);
            this.panel1.Controls.Add(this.btnColour3);
            this.panel1.Controls.Add(this.btnColour2);
            this.panel1.Controls.Add(this.btnColour5);
            this.panel1.Controls.Add(this.btnColour1);
            this.panel1.Controls.Add(this.SelectColourLabel);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 736);
            this.panel1.TabIndex = 13;
            // 
            // btnColour8
            // 
            this.btnColour8.BackColor = System.Drawing.Color.Gray;
            this.btnColour8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour8.FlatAppearance.BorderSize = 10;
            this.btnColour8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour8.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour8.Location = new System.Drawing.Point(736, 413);
            this.btnColour8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour8.Name = "btnColour8";
            this.btnColour8.Size = new System.Drawing.Size(225, 208);
            this.btnColour8.TabIndex = 8;
            this.btnColour8.UseVisualStyleBackColor = false;
            this.btnColour8.Click += new System.EventHandler(this.Colour_Click8);
            this.btnColour8.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour8.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour7
            // 
            this.btnColour7.BackColor = System.Drawing.Color.Gray;
            this.btnColour7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour7.FlatAppearance.BorderSize = 10;
            this.btnColour7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour7.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour7.Location = new System.Drawing.Point(496, 413);
            this.btnColour7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour7.Name = "btnColour7";
            this.btnColour7.Size = new System.Drawing.Size(225, 208);
            this.btnColour7.TabIndex = 7;
            this.btnColour7.UseVisualStyleBackColor = false;
            this.btnColour7.Click += new System.EventHandler(this.Colour_Click7);
            this.btnColour7.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour7.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour6
            // 
            this.btnColour6.BackColor = System.Drawing.Color.Gray;
            this.btnColour6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour6.FlatAppearance.BorderSize = 10;
            this.btnColour6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour6.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour6.Location = new System.Drawing.Point(259, 413);
            this.btnColour6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour6.Name = "btnColour6";
            this.btnColour6.Size = new System.Drawing.Size(225, 208);
            this.btnColour6.TabIndex = 6;
            this.btnColour6.UseVisualStyleBackColor = false;
            this.btnColour6.Click += new System.EventHandler(this.Colour_Click6);
            this.btnColour6.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour6.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour4
            // 
            this.btnColour4.BackColor = System.Drawing.Color.Gray;
            this.btnColour4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour4.FlatAppearance.BorderSize = 10;
            this.btnColour4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour4.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour4.Location = new System.Drawing.Point(736, 148);
            this.btnColour4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour4.Name = "btnColour4";
            this.btnColour4.Size = new System.Drawing.Size(225, 208);
            this.btnColour4.TabIndex = 4;
            this.btnColour4.UseVisualStyleBackColor = false;
            this.btnColour4.Click += new System.EventHandler(this.Colour_Click4);
            this.btnColour4.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour4.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour3
            // 
            this.btnColour3.BackColor = System.Drawing.Color.Gray;
            this.btnColour3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour3.FlatAppearance.BorderSize = 10;
            this.btnColour3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour3.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour3.Location = new System.Drawing.Point(496, 148);
            this.btnColour3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour3.Name = "btnColour3";
            this.btnColour3.Size = new System.Drawing.Size(225, 208);
            this.btnColour3.TabIndex = 3;
            this.btnColour3.UseVisualStyleBackColor = false;
            this.btnColour3.Click += new System.EventHandler(this.Colour_Click3);
            this.btnColour3.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour3.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour2
            // 
            this.btnColour2.BackColor = System.Drawing.Color.Gray;
            this.btnColour2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour2.FlatAppearance.BorderSize = 10;
            this.btnColour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour2.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour2.Location = new System.Drawing.Point(259, 148);
            this.btnColour2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour2.Name = "btnColour2";
            this.btnColour2.Size = new System.Drawing.Size(225, 208);
            this.btnColour2.TabIndex = 2;
            this.btnColour2.UseVisualStyleBackColor = false;
            this.btnColour2.Click += new System.EventHandler(this.Colour_Click2);
            this.btnColour2.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour2.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour5
            // 
            this.btnColour5.BackColor = System.Drawing.Color.Gray;
            this.btnColour5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour5.FlatAppearance.BorderSize = 10;
            this.btnColour5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour5.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour5.Location = new System.Drawing.Point(22, 413);
            this.btnColour5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour5.Name = "btnColour5";
            this.btnColour5.Size = new System.Drawing.Size(225, 208);
            this.btnColour5.TabIndex = 5;
            this.btnColour5.UseVisualStyleBackColor = false;
            this.btnColour5.Click += new System.EventHandler(this.Colour_Click5);
            this.btnColour5.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour5.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // btnColour1
            // 
            this.btnColour1.BackColor = System.Drawing.Color.Gray;
            this.btnColour1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColour1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColour1.FlatAppearance.BorderSize = 10;
            this.btnColour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColour1.ForeColor = System.Drawing.Color.Transparent;
            this.btnColour1.Location = new System.Drawing.Point(22, 148);
            this.btnColour1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColour1.Name = "btnColour1";
            this.btnColour1.Size = new System.Drawing.Size(225, 208);
            this.btnColour1.TabIndex = 1;
            this.btnColour1.UseVisualStyleBackColor = false;
            this.btnColour1.Click += new System.EventHandler(this.Colour_Click1);
            this.btnColour1.Enter += new System.EventHandler(this.butSelection_Enter);
            this.btnColour1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.btnColour1.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // timerSwitch
            // 
            this.timerSwitch.Tick += new System.EventHandler(this.timerSwitch_Tick);
            // 
            // ColourPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(991, 549);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ColourPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Colour";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectColourLabel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColour8;
        private System.Windows.Forms.Button btnColour7;
        private System.Windows.Forms.Button btnColour6;
        private System.Windows.Forms.Button btnColour4;
        private System.Windows.Forms.Button btnColour3;
        private System.Windows.Forms.Button btnColour2;
        private System.Windows.Forms.Button btnColour5;
        private System.Windows.Forms.Button btnColour1;
        private System.Windows.Forms.Timer timerSwitch;
    }
}