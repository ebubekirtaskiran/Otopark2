namespace Otopark2
{
    partial class Form3
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(526, 50);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 0;
            button1.Text = "ARAÇ KAYIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(488, 20);
            label1.TabIndex = 1;
            label1.Text = "Aracı otoparka kaydetmek istiyorsanız \"ARAÇ KAYIT\" butonuna tıklayınız.";
            // 
            // button2
            // 
            button2.Location = new Point(526, 116);
            button2.Name = "button2";
            button2.Size = new Size(200, 47);
            button2.TabIndex = 2;
            button2.Text = "ARAÇ ÇIKIŞ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(508, 44);
            label2.TabIndex = 3;
            label2.Text = "Aracın otoparktan çıkış işlemini tamamlamak istiyorsanız \"ARAÇ ÇIKIŞ\" butonuna tıklayınız.";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(526, 187);
            button3.Name = "button3";
            button3.Size = new Size(200, 56);
            button3.TabIndex = 4;
            button3.Text = "OTOPARK DURUMU SORGULAMA";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(508, 47);
            label3.TabIndex = 5;
            label3.Text = "Otopark durmunu öğrenmek istiyorsanız \"OTOPARK DURUMU SORGULAMA\" butonuna tıklayınız.";
            // 
            // button4
            // 
            button4.Location = new Point(526, 265);
            button4.Name = "button4";
            button4.Size = new Size(200, 47);
            button4.TabIndex = 6;
            button4.Text = "HASILAT";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(12, 265);
            label4.Name = "label4";
            label4.Size = new Size(346, 47);
            label4.TabIndex = 7;
            label4.Text = "Otoparkın hasılatını(gelirini) öğrenmek istiyorsanız \"HASILAT\"butonuna tıklayınız.";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PERSONEL PANELİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
    }
}