namespace Otopark2
{
    partial class Form5
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
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(104, 41);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 0;
            label1.Text = "Plaka Bilgilerini Giriniz :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(298, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            panel1.Location = new Point(296, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 1);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(280, 23);
            label2.TabIndex = 0;
            label2.Text = "Müşteri Telefon Numarasını Giriniz :";
            label2.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(298, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            panel2.Location = new Point(296, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 1);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(311, 164);
            button1.Name = "button1";
            button1.Size = new Size(210, 42);
            button1.TabIndex = 3;
            button1.Text = "KAYIT İŞLEMİNİ TAMAMLA";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(97, 128);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
            label3.TabIndex = 4;
            label3.Text = "Araç Park Yerini Seçiniz :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(294, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 28);
            comboBox2.TabIndex = 30;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 245);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ARAÇ KAYIT";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private ComboBox comboBox2;
    }
}