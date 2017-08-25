﻿namespace NRSSSNamespace
{
    partial class ModelsPage
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
            this.ModelsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ModelLabel1 = new System.Windows.Forms.Label();
            this.ModelLabel2 = new System.Windows.Forms.Label();
            this.ModelLabel3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ModelPanel = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ModelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelsLabel
            // 
            this.ModelsLabel.AutoSize = true;
            this.ModelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelsLabel.Location = new System.Drawing.Point(748, 35);
            this.ModelsLabel.Name = "ModelsLabel";
            this.ModelsLabel.Size = new System.Drawing.Size(353, 107);
            this.ModelsLabel.TabIndex = 0;
            this.ModelsLabel.Text = "Models";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 492);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1189, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(518, 492);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Yellow;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(62, 896);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(206, 118);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // ModelLabel1
            // 
            this.ModelLabel1.AutoSize = true;
            this.ModelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel1.Location = new System.Drawing.Point(179, 71);
            this.ModelLabel1.Name = "ModelLabel1";
            this.ModelLabel1.Size = new System.Drawing.Size(219, 63);
            this.ModelLabel1.TabIndex = 5;
            this.ModelLabel1.Text = "Model 1";
            // 
            // ModelLabel2
            // 
            this.ModelLabel2.AutoSize = true;
            this.ModelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel2.Location = new System.Drawing.Point(758, 71);
            this.ModelLabel2.Name = "ModelLabel2";
            this.ModelLabel2.Size = new System.Drawing.Size(219, 63);
            this.ModelLabel2.TabIndex = 6;
            this.ModelLabel2.Text = "Model 2";
            // 
            // ModelLabel3
            // 
            this.ModelLabel3.AutoSize = true;
            this.ModelLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel3.Location = new System.Drawing.Point(1365, 71);
            this.ModelLabel3.Name = "ModelLabel3";
            this.ModelLabel3.Size = new System.Drawing.Size(219, 63);
            this.ModelLabel3.TabIndex = 7;
            this.ModelLabel3.Text = "Model 3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(612, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(518, 492);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ModelPanel
            // 
            this.ModelPanel.BackColor = System.Drawing.Color.Transparent;
            this.ModelPanel.Controls.Add(this.ModelLabel1);
            this.ModelPanel.Controls.Add(this.ModelLabel3);
            this.ModelPanel.Controls.Add(this.pictureBox3);
            this.ModelPanel.Controls.Add(this.ModelLabel2);
            this.ModelPanel.Controls.Add(this.pictureBox2);
            this.ModelPanel.Controls.Add(this.pictureBox1);
            this.ModelPanel.Location = new System.Drawing.Point(62, 177);
            this.ModelPanel.Name = "ModelPanel";
            this.ModelPanel.Size = new System.Drawing.Size(1717, 698);
            this.ModelPanel.TabIndex = 8;
            this.ModelPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Yellow;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.Color.Black;
            this.NextBtn.Location = new System.Drawing.Point(1549, 896);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(220, 118);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ModelsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1831, 1039);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ModelPanel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ModelsLabel);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "ModelsPage";
            this.Text = "Models";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ModelPanel.ResumeLayout(false);
            this.ModelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModelsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label ModelLabel1;
        private System.Windows.Forms.Label ModelLabel2;
        private System.Windows.Forms.Label ModelLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ModelPanel;
        private System.Windows.Forms.Button NextBtn;
    }
}