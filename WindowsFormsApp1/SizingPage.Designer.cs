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
            this.SizeSelectLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SmallLabel = new System.Windows.Forms.Label();
            this.MedLabel = new System.Windows.Forms.Label();
            this.BigLabel = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeSelectLabel
            // 
            this.SizeSelectLabel.AutoSize = true;
            this.SizeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeSelectLabel.Location = new System.Drawing.Point(538, 63);
            this.SizeSelectLabel.Name = "SizeSelectLabel";
            this.SizeSelectLabel.Size = new System.Drawing.Size(615, 107);
            this.SizeSelectLabel.TabIndex = 0;
            this.SizeSelectLabel.Text = "Select A Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 408);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(655, 381);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(444, 408);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1231, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(444, 408);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // SmallLabel
            // 
            this.SmallLabel.AutoSize = true;
            this.SmallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallLabel.Location = new System.Drawing.Point(188, 288);
            this.SmallLabel.Name = "SmallLabel";
            this.SmallLabel.Size = new System.Drawing.Size(164, 63);
            this.SmallLabel.TabIndex = 4;
            this.SmallLabel.Text = "Small";
            // 
            // MedLabel
            // 
            this.MedLabel.AutoSize = true;
            this.MedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedLabel.Location = new System.Drawing.Point(760, 288);
            this.MedLabel.Name = "MedLabel";
            this.MedLabel.Size = new System.Drawing.Size(220, 63);
            this.MedLabel.TabIndex = 5;
            this.MedLabel.Text = "Medium";
            // 
            // BigLabel
            // 
            this.BigLabel.AutoSize = true;
            this.BigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigLabel.Location = new System.Drawing.Point(1406, 288);
            this.BigLabel.Name = "BigLabel";
            this.BigLabel.Size = new System.Drawing.Size(106, 63);
            this.BigLabel.TabIndex = 6;
            this.BigLabel.Text = "Big";
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Yellow;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.Color.Black;
            this.NextBtn.Location = new System.Drawing.Point(1455, 869);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(220, 118);
            this.NextBtn.TabIndex = 11;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Yellow;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(57, 869);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(206, 118);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SizingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1773, 1037);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BigLabel);
            this.Controls.Add(this.MedLabel);
            this.Controls.Add(this.SmallLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SizeSelectLabel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "SizingPage";
            this.Text = "Sizes";
            this.Load += new System.EventHandler(this.SizingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SizeSelectLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label SmallLabel;
        private System.Windows.Forms.Label MedLabel;
        private System.Windows.Forms.Label BigLabel;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}