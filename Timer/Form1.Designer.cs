namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.buttonDurdur = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelDakika = new System.Windows.Forms.Label();
            this.labelSaniye = new System.Windows.Forms.Label();
            this.labelSalise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DAKİKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(276, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SANİYE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(369, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SALİSE";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.Location = new System.Drawing.Point(102, 120);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(25, 25);
            this.labelSaat.TabIndex = 4;
            this.labelSaat.Text = "0";
            // 
            // buttonBasla
            // 
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(122, 184);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(80, 29);
            this.buttonBasla.TabIndex = 8;
            this.buttonBasla.Text = "BAŞLAT";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // buttonDurdur
            // 
            this.buttonDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDurdur.Location = new System.Drawing.Point(220, 184);
            this.buttonDurdur.Name = "buttonDurdur";
            this.buttonDurdur.Size = new System.Drawing.Size(93, 29);
            this.buttonDurdur.TabIndex = 9;
            this.buttonDurdur.Text = "DURDUR";
            this.buttonDurdur.UseVisualStyleBackColor = true;
            this.buttonDurdur.Click += new System.EventHandler(this.buttonDurdur_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(332, 184);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(80, 29);
            this.buttonTemizle.TabIndex = 10;
            this.buttonTemizle.Text = "TEMİZLE";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(482, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 11;
            // 
            // labelDakika
            // 
            this.labelDakika.AutoSize = true;
            this.labelDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDakika.Location = new System.Drawing.Point(205, 120);
            this.labelDakika.Name = "labelDakika";
            this.labelDakika.Size = new System.Drawing.Size(25, 25);
            this.labelDakika.TabIndex = 12;
            this.labelDakika.Text = "0";
            // 
            // labelSaniye
            // 
            this.labelSaniye.AutoSize = true;
            this.labelSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaniye.Location = new System.Drawing.Point(299, 120);
            this.labelSaniye.Name = "labelSaniye";
            this.labelSaniye.Size = new System.Drawing.Size(25, 25);
            this.labelSaniye.TabIndex = 13;
            this.labelSaniye.Text = "0";
            // 
            // labelSalise
            // 
            this.labelSalise.AutoSize = true;
            this.labelSalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalise.Location = new System.Drawing.Point(387, 120);
            this.labelSalise.Name = "labelSalise";
            this.labelSalise.Size = new System.Drawing.Size(25, 25);
            this.labelSalise.TabIndex = 14;
            this.labelSalise.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 266);
            this.Controls.Add(this.labelSalise);
            this.Controls.Add(this.labelSaniye);
            this.Controls.Add(this.labelDakika);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonDurdur);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Button buttonDurdur;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelDakika;
        private System.Windows.Forms.Label labelSaniye;
        private System.Windows.Forms.Label labelSalise;
    }
}

