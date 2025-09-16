namespace WinFormsApp1
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
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(313, 291);
            button2.Name = "button2";
            button2.Size = new Size(131, 68);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(117, 172);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(144, 291);
            button1.Name = "button1";
            button1.Size = new Size(83, 38);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = Properties.Resources._2b3f6ff00db7a1efae21d85cfb8995eaff2da8d8;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(329, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 157);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(84, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
