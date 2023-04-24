namespace VizeVeFinalHesaplayicisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            MskFinal = new MaskedTextBox();
            MskVize = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(375, 34);
            label1.TabIndex = 0;
            label1.Text = "Vize Ve Final Notu Hesaplayıcısı";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(MskFinal);
            groupBox2.Controls.Add(MskVize);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 174);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(15, 125);
            button1.Name = "button1";
            button1.Size = new Size(318, 34);
            button1.TabIndex = 6;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MskFinal
            // 
            MskFinal.Location = new Point(160, 71);
            MskFinal.Mask = "000";
            MskFinal.Name = "MskFinal";
            MskFinal.Size = new Size(39, 23);
            MskFinal.TabIndex = 5;
            MskFinal.ValidatingType = typeof(int);
            // 
            // MskVize
            // 
            MskVize.Location = new Point(160, 40);
            MskVize.Mask = "000";
            MskVize.Name = "MskVize";
            MskVize.Size = new Size(39, 23);
            MskVize.TabIndex = 4;
            MskVize.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 1;
            label3.Text = "Final Notunuz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 0;
            label2.Text = "Vize Notunuz :";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(766, 12);
            button2.Name = "button2";
            button2.Size = new Size(43, 33);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(716, 12);
            button3.Name = "button3";
            button3.Size = new Size(44, 33);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 19);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 3;
            label5.Text = "Ortalamanız :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 296);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 50);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(283, 19);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(189, 19);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 4;
            label6.Text = "Durumunuz :";
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(27, 369);
            button4.Name = "button4";
            button4.Size = new Size(318, 34);
            button4.TabIndex = 7;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 480);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox MskFinal;
        private MaskedTextBox MskVize;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Button button4;
    }
}