namespace NRSSSNamespace
{
    partial class CategoryPage
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.Category1Label = new System.Windows.Forms.Label();
            this.Category2Label = new System.Windows.Forms.Label();
            this.Category3Label = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butSelectionC = new System.Windows.Forms.Button();
            this.butSelectionB = new System.Windows.Forms.Button();
            this.butSelectionA = new System.Windows.Forms.Button();
            this.PreviousPgBtn = new System.Windows.Forms.Button();
            this.timerSwitch = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(47, 1248);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(250, 150);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Font = new System.Drawing.Font("Century Gothic", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.Location = new System.Drawing.Point(665, 26);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(621, 126);
            this.CategoriesLabel.TabIndex = 4;
            this.CategoriesLabel.Text = "Categories";
            // 
            // Category1Label
            // 
            this.Category1Label.AutoSize = true;
            this.Category1Label.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category1Label.Location = new System.Drawing.Point(114, 260);
            this.Category1Label.Name = "Category1Label";
            this.Category1Label.Size = new System.Drawing.Size(397, 80);
            this.Category1Label.TabIndex = 8;
            this.Category1Label.Text = "Category 1";
            this.Category1Label.Click += new System.EventHandler(this.Category1Label_Click);
            // 
            // Category2Label
            // 
            this.Category2Label.AutoSize = true;
            this.Category2Label.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category2Label.Location = new System.Drawing.Point(768, 260);
            this.Category2Label.Name = "Category2Label";
            this.Category2Label.Size = new System.Drawing.Size(397, 80);
            this.Category2Label.TabIndex = 9;
            this.Category2Label.Text = "Category 2";
            // 
            // Category3Label
            // 
            this.Category3Label.AutoSize = true;
            this.Category3Label.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category3Label.Location = new System.Drawing.Point(1419, 260);
            this.Category3Label.Name = "Category3Label";
            this.Category3Label.Size = new System.Drawing.Size(397, 80);
            this.Category3Label.TabIndex = 10;
            this.Category3Label.Text = "Category 3";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(387, 1248);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(250, 150);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.BackColor = System.Drawing.Color.Yellow;
            this.NextPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NextPageBtn.FlatAppearance.BorderSize = 10;
            this.NextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageBtn.ForeColor = System.Drawing.Color.Black;
            this.NextPageBtn.Location = new System.Drawing.Point(1566, 1236);
            this.NextPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(325, 175);
            this.NextPageBtn.TabIndex = 5;
            this.NextPageBtn.Text = "Next Page";
            this.NextPageBtn.UseVisualStyleBackColor = false;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            this.NextPageBtn.Enter += new System.EventHandler(this.butSelection_Enter);
            this.NextPageBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyDown);
            this.NextPageBtn.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.butSelectionC);
            this.panel1.Controls.Add(this.butSelectionB);
            this.panel1.Controls.Add(this.butSelectionA);
            this.panel1.Controls.Add(this.PreviousPgBtn);
            this.panel1.Controls.Add(this.CategoriesLabel);
            this.panel1.Controls.Add(this.NextPageBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.Category3Label);
            this.panel1.Controls.Add(this.Category2Label);
            this.panel1.Controls.Add(this.Category1Label);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 1449);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // butSelectionC
            // 
            this.butSelectionC.BackColor = System.Drawing.Color.Transparent;
            this.butSelectionC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSelectionC.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.butSelectionC.FlatAppearance.BorderSize = 10;
            this.butSelectionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelectionC.ForeColor = System.Drawing.Color.Black;
            this.butSelectionC.Location = new System.Drawing.Point(1310, 410);
            this.butSelectionC.Margin = new System.Windows.Forms.Padding(4);
            this.butSelectionC.Name = "butSelectionC";
            this.butSelectionC.Size = new System.Drawing.Size(600, 720);
            this.butSelectionC.TabIndex = 3;
            this.butSelectionC.UseVisualStyleBackColor = false;
            this.butSelectionC.Click += new System.EventHandler(this.Category_Click3);
            this.butSelectionC.Enter += new System.EventHandler(this.butSelection_Enter);
            this.butSelectionC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.butSelectionC.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // butSelectionB
            // 
            this.butSelectionB.BackColor = System.Drawing.Color.Transparent;
            this.butSelectionB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSelectionB.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.butSelectionB.FlatAppearance.BorderSize = 10;
            this.butSelectionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelectionB.ForeColor = System.Drawing.Color.Black;
            this.butSelectionB.Location = new System.Drawing.Point(665, 410);
            this.butSelectionB.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.butSelectionB.Name = "butSelectionB";
            this.butSelectionB.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.butSelectionB.Size = new System.Drawing.Size(600, 720);
            this.butSelectionB.TabIndex = 2;
            this.butSelectionB.UseVisualStyleBackColor = false;
            this.butSelectionB.Click += new System.EventHandler(this.Category_Click2);
            this.butSelectionB.Enter += new System.EventHandler(this.butSelection_Enter);
            this.butSelectionB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.butSelectionB.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // butSelectionA
            // 
            this.butSelectionA.BackColor = System.Drawing.Color.Transparent;
            this.butSelectionA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSelectionA.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.butSelectionA.FlatAppearance.BorderSize = 10;
            this.butSelectionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelectionA.ForeColor = System.Drawing.Color.Black;
            this.butSelectionA.Location = new System.Drawing.Point(27, 410);
            this.butSelectionA.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.butSelectionA.Name = "butSelectionA";
            this.butSelectionA.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.butSelectionA.Size = new System.Drawing.Size(600, 720);
            this.butSelectionA.TabIndex = 1;
            this.butSelectionA.UseVisualStyleBackColor = false;
            this.butSelectionA.Click += new System.EventHandler(this.Category_Click1);
            this.butSelectionA.Enter += new System.EventHandler(this.butSelection_Enter);
            this.butSelectionA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyUp);
            this.butSelectionA.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // PreviousPgBtn
            // 
            this.PreviousPgBtn.BackColor = System.Drawing.Color.Yellow;
            this.PreviousPgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PreviousPgBtn.FlatAppearance.BorderSize = 10;
            this.PreviousPgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPgBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPgBtn.ForeColor = System.Drawing.Color.Black;
            this.PreviousPgBtn.Location = new System.Drawing.Point(1235, 1236);
            this.PreviousPgBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousPgBtn.Name = "PreviousPgBtn";
            this.PreviousPgBtn.Size = new System.Drawing.Size(325, 175);
            this.PreviousPgBtn.TabIndex = 4;
            this.PreviousPgBtn.Text = "Previous Page";
            this.PreviousPgBtn.UseVisualStyleBackColor = false;
            this.PreviousPgBtn.Click += new System.EventHandler(this.PreviousPgBtn_Click);
            this.PreviousPgBtn.Enter += new System.EventHandler(this.butSelection_Enter);
            this.PreviousPgBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butSelection_KeyDown);
            this.PreviousPgBtn.Leave += new System.EventHandler(this.butSelection_Leave);
            // 
            // timerSwitch
            // 
            this.timerSwitch.Tick += new System.EventHandler(this.timerSwitch_Tick);
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1966, 1491);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label Category1Label;
        private System.Windows.Forms.Label Category2Label;
        private System.Windows.Forms.Label Category3Label;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviousPgBtn;
        private System.Windows.Forms.Button butSelectionA;
        private System.Windows.Forms.Button butSelectionC;
        private System.Windows.Forms.Button butSelectionB;
        private System.Windows.Forms.Timer timerSwitch;
    }
}