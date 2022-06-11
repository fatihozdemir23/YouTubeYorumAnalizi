
namespace NLP
{
    partial class FormYouTubeApi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Wtf_idf = new System.Windows.Forms.Label();
            this.idf = new System.Windows.Forms.Label();
            this.tf = new System.Windows.Forms.Label();
            this.ngramNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamKelime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.benzersizKelime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kelimeOran = new System.Windows.Forms.Label();
            this.kelimelistesi = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.kelime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngramNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2cd8Olx1ZXs";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 103);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 468);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(311, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 100);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 249);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçilen Yorumun Detayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-4, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Youtube Yorumları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Youtube Video ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Wtf_idf);
            this.groupBox1.Controls.Add(this.idf);
            this.groupBox1.Controls.Add(this.tf);
            this.groupBox1.Controls.Add(this.ngramNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.stackPanel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kelimelistesi);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(432, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1009, 636);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NLP İŞLEMLERİ";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(420, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 31);
            this.button5.TabIndex = 15;
            this.button5.Text = "NGram";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(4, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "RemoveStopWords";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Wtf_idf
            // 
            this.Wtf_idf.AutoSize = true;
            this.Wtf_idf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Wtf_idf.Location = new System.Drawing.Point(796, 197);
            this.Wtf_idf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wtf_idf.Name = "Wtf_idf";
            this.Wtf_idf.Size = new System.Drawing.Size(88, 29);
            this.Wtf_idf.TabIndex = 13;
            this.Wtf_idf.Text = "Wtf-idf";
            // 
            // idf
            // 
            this.idf.AutoSize = true;
            this.idf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idf.Location = new System.Drawing.Point(796, 148);
            this.idf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idf.Name = "idf";
            this.idf.Size = new System.Drawing.Size(54, 29);
            this.idf.TabIndex = 11;
            this.idf.Text = "IDF";
            // 
            // tf
            // 
            this.tf.AutoSize = true;
            this.tf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tf.Location = new System.Drawing.Point(796, 100);
            this.tf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tf.Name = "tf";
            this.tf.Size = new System.Drawing.Size(46, 29);
            this.tf.TabIndex = 10;
            this.tf.Text = "TF";
            // 
            // ngramNumber
            // 
            this.ngramNumber.Location = new System.Drawing.Point(591, 30);
            this.ngramNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngramNumber.Name = "ngramNumber";
            this.ngramNumber.Size = new System.Drawing.Size(132, 23);
            this.ngramNumber.TabIndex = 9;
            this.ngramNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Result";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(4, 391);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(408, 187);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(241, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tokenizing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.label4);
            this.stackPanel1.Controls.Add(this.toplamKelime);
            this.stackPanel1.Controls.Add(this.label5);
            this.stackPanel1.Controls.Add(this.benzersizKelime);
            this.stackPanel1.Controls.Add(this.label6);
            this.stackPanel1.Controls.Add(this.kelimeOran);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(4, 586);
            this.stackPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(1001, 46);
            this.stackPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Kelime Sayısı:";
            // 
            // toplamKelime
            // 
            this.toplamKelime.AutoSize = true;
            this.toplamKelime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamKelime.Location = new System.Drawing.Point(243, 11);
            this.toplamKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamKelime.Name = "toplamKelime";
            this.toplamKelime.Size = new System.Drawing.Size(23, 24);
            this.toplamKelime.TabIndex = 1;
            this.toplamKelime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(274, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Benzersiz Kelime Sayısı:";
            // 
            // benzersizKelime
            // 
            this.benzersizKelime.AutoSize = true;
            this.benzersizKelime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.benzersizKelime.Location = new System.Drawing.Point(537, 11);
            this.benzersizKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.benzersizKelime.Name = "benzersizKelime";
            this.benzersizKelime.Size = new System.Drawing.Size(23, 24);
            this.benzersizKelime.TabIndex = 3;
            this.benzersizKelime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(568, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Benzersiz Kelime Oranı:";
            // 
            // kelimeOran
            // 
            this.kelimeOran.AutoSize = true;
            this.kelimeOran.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeOran.Location = new System.Drawing.Point(827, 11);
            this.kelimeOran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kelimeOran.Name = "kelimeOran";
            this.kelimeOran.Size = new System.Drawing.Size(23, 24);
            this.kelimeOran.TabIndex = 5;
            this.kelimeOran.Text = "0";
            // 
            // kelimelistesi
            // 
            this.kelimelistesi.AllowUserToAddRows = false;
            this.kelimelistesi.AllowUserToDeleteRows = false;
            this.kelimelistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelimelistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kelime,
            this.kullanim});
            this.kelimelistesi.Location = new System.Drawing.Point(420, 100);
            this.kelimelistesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kelimelistesi.Name = "kelimelistesi";
            this.kelimelistesi.ReadOnly = true;
            this.kelimelistesi.RowHeadersWidth = 51;
            this.kelimelistesi.RowTemplate.Height = 24;
            this.kelimelistesi.Size = new System.Drawing.Size(369, 255);
            this.kelimelistesi.TabIndex = 3;
            this.kelimelistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kelimelistesi_CellClick_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1, 580);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(409, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "Yorum Analizi Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kelime
            // 
            this.kelime.HeaderText = "KELİME";
            this.kelime.MinimumWidth = 6;
            this.kelime.Name = "kelime";
            this.kelime.ReadOnly = true;
            this.kelime.Width = 125;
            // 
            // kullanim
            // 
            this.kullanim.HeaderText = "KULLANIM";
            this.kullanim.MinimumWidth = 6;
            this.kullanim.Name = "kullanim";
            this.kullanim.ReadOnly = true;
            this.kullanim.Width = 125;
            // 
            // FormYouTubeApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormYouTubeApi";
            this.Text = "FormYouTubeApi";
            this.Load += new System.EventHandler(this.FormYouTubeApi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngramNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimelistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView kelimelistesi;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplamKelime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label benzersizKelime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label kelimeOran;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.NumericUpDown ngramNumber;
        private System.Windows.Forms.Label idf;
        private System.Windows.Forms.Label tf;
        private System.Windows.Forms.Label Wtf_idf;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelime;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanim;
    }
}