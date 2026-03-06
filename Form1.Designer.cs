namespace MyBusinessCard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 50F);
            label1.Location = new Point(364, 60);
            label1.Name = "label1";
            label1.Size = new Size(299, 112);
            label1.TabIndex = 1;
            label1.Text = "최상훈";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 27F);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(364, 199);
            label2.Name = "label2";
            label2.Size = new Size(455, 61);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터학부 컴퓨터sw";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.신분증사진;
            pictureBox1.Location = new Point(69, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 27F);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(364, 260);
            label3.Name = "label3";
            label3.Size = new Size(580, 61);
            label3.TabIndex = 4;
            label3.Text = "cheonggae77@suwon.ac.kr";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 15F);
            button1.Location = new Point(677, 415);
            button1.Name = "button1";
            button1.Size = new Size(251, 58);
            button1.TabIndex = 5;
            button1.Text = "배경색 랜덤 변경";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 20F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(406, 415);
            button2.Name = "button2";
            button2.Size = new Size(163, 58);
            button2.TabIndex = 6;
            button2.Text = "Github";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 15F);
            button3.Location = new Point(113, 415);
            button3.Name = "button3";
            button3.Size = new Size(156, 58);
            button3.TabIndex = 7;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 503);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            MouseLeave += Form1_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
