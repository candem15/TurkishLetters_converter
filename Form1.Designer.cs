namespace TurkishLetters_converter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_srch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.label_letters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_srch
            // 
            this.button_srch.Location = new System.Drawing.Point(12, 13);
            this.button_srch.Name = "button_srch";
            this.button_srch.Size = new System.Drawing.Size(112, 22);
            this.button_srch.TabIndex = 0;
            this.button_srch.Text = "Altyazıyı Bul";
            this.button_srch.UseVisualStyleBackColor = true;
            this.button_srch.Click += new System.EventHandler(this.button_srch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(635, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(130, 13);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(120, 22);
            this.button_replace.TabIndex = 3;
            this.button_replace.Text = "Değiştir";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // label_letters
            // 
            this.label_letters.AutoSize = true;
            this.label_letters.Location = new System.Drawing.Point(12, 69);
            this.label_letters.Name = "label_letters";
            this.label_letters.Size = new System.Drawing.Size(390, 13);
            this.label_letters.TabIndex = 4;
            this.label_letters.Text = "Değiştirilen harfler : İ, ı, Ö, ö, Ü, ü, Ş, ş, Ç, ç, ğ, â, î  => I, i, O, o, U, u" +
    ", S, s, C, c, g";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 89);
            this.Controls.Add(this.label_letters);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_srch);
            this.Name = "Form1";
            this.Text = "Türkçe karakterleri değiştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_srch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Label label_letters;
    }
}

