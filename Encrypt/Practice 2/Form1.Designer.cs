namespace Practice_2
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Шифрование";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(7, 158);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(763, 50);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(7, 140);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 5;
            label3.Text = "Зашифрованный текст:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(598, 103);
            button1.Name = "button1";
            button1.Size = new Size(172, 25);
            button1.TabIndex = 4;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F);
            numericUpDown1.Location = new Point(88, 105);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Сдвиг (2-32):";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(6, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(764, 50);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Текст для шифрования:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 199);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дешифрование";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(6, 136);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(764, 50);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(6, 109);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 4;
            label5.Text = "Расшифрованный текст:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(598, 71);
            button3.Name = "button3";
            button3.Size = new Size(172, 25);
            button3.TabIndex = 3;
            button3.Text = "Дешифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 9F);
            numericUpDown2.Location = new Point(87, 73);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 1;
            label4.Text = "Ключ (2-32):";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(6, 32);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 0;
            button2.Text = "Выбрать файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button button3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Button button2;
        private TextBox textBox3;
        private Label label5;
    }
}
