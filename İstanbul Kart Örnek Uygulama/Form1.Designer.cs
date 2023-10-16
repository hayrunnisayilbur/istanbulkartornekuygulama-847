namespace İstanbul_Kart_Örnek_Uygulama
{
    partial class Form1
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
            this.scre = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOgrenci = new System.Windows.Forms.CheckBox();
            this.rbAktarma4 = new System.Windows.Forms.RadioButton();
            this.rbAktarma3 = new System.Windows.Forms.RadioButton();
            this.rbAktarma2 = new System.Windows.Forms.RadioButton();
            this.rbAktarma1 = new System.Windows.Forms.RadioButton();
            this.rbAktarma0 = new System.Windows.Forms.RadioButton();
            this.btn50 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOgrenci);
            this.groupBox1.Controls.Add(this.rbAktarma4);
            this.groupBox1.Controls.Add(this.rbAktarma3);
            this.groupBox1.Controls.Add(this.rbAktarma2);
            this.groupBox1.Controls.Add(this.rbAktarma1);
            this.groupBox1.Controls.Add(this.rbAktarma0);
            this.groupBox1.Location = new System.Drawing.Point(44, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme";
            // 
            // cbOgrenci
            // 
            this.cbOgrenci.AutoSize = true;
            this.cbOgrenci.Location = new System.Drawing.Point(26, 176);
            this.cbOgrenci.Name = "cbOgrenci";
            this.cbOgrenci.Size = new System.Drawing.Size(63, 17);
            this.cbOgrenci.TabIndex = 6;
            this.cbOgrenci.Text = "Öğrenci";
            this.cbOgrenci.UseVisualStyleBackColor = true;
            // 
            // rbAktarma4
            // 
            this.rbAktarma4.AutoSize = true;
            this.rbAktarma4.Location = new System.Drawing.Point(26, 142);
            this.rbAktarma4.Name = "rbAktarma4";
            this.rbAktarma4.Size = new System.Drawing.Size(76, 17);
            this.rbAktarma4.TabIndex = 5;
            this.rbAktarma4.TabStop = true;
            this.rbAktarma4.Text = "4. Aktarma";
            this.rbAktarma4.UseVisualStyleBackColor = true;
            // 
            // rbAktarma3
            // 
            this.rbAktarma3.AutoSize = true;
            this.rbAktarma3.Location = new System.Drawing.Point(26, 119);
            this.rbAktarma3.Name = "rbAktarma3";
            this.rbAktarma3.Size = new System.Drawing.Size(76, 17);
            this.rbAktarma3.TabIndex = 4;
            this.rbAktarma3.TabStop = true;
            this.rbAktarma3.Text = "3. Aktarma";
            this.rbAktarma3.UseVisualStyleBackColor = true;
            // 
            // rbAktarma2
            // 
            this.rbAktarma2.AutoSize = true;
            this.rbAktarma2.Location = new System.Drawing.Point(26, 96);
            this.rbAktarma2.Name = "rbAktarma2";
            this.rbAktarma2.Size = new System.Drawing.Size(76, 17);
            this.rbAktarma2.TabIndex = 3;
            this.rbAktarma2.TabStop = true;
            this.rbAktarma2.Text = "2. Aktarma";
            this.rbAktarma2.UseVisualStyleBackColor = true;
            // 
            // rbAktarma1
            // 
            this.rbAktarma1.AutoSize = true;
            this.rbAktarma1.Location = new System.Drawing.Point(26, 73);
            this.rbAktarma1.Name = "rbAktarma1";
            this.rbAktarma1.Size = new System.Drawing.Size(76, 17);
            this.rbAktarma1.TabIndex = 2;
            this.rbAktarma1.TabStop = true;
            this.rbAktarma1.Text = "1. Aktarma";
            this.rbAktarma1.UseVisualStyleBackColor = true;
            // 
            // rbAktarma0
            // 
            this.rbAktarma0.AutoSize = true;
            this.rbAktarma0.Location = new System.Drawing.Point(26, 50);
            this.rbAktarma0.Name = "rbAktarma0";
            this.rbAktarma0.Size = new System.Drawing.Size(61, 17);
            this.rbAktarma0.TabIndex = 1;
            this.rbAktarma0.TabStop = true;
            this.rbAktarma0.Text = "İlk Biniş";
            this.rbAktarma0.UseVisualStyleBackColor = true;
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(6, 29);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(188, 37);
            this.btn50.TabIndex = 1;
            this.btn50.Text = "50 Lira Yükle";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn200);
            this.groupBox2.Controls.Add(this.btn100);
            this.groupBox2.Controls.Add(this.btn50);
            this.groupBox2.Location = new System.Drawing.Point(282, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(6, 115);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(188, 37);
            this.btn200.TabIndex = 3;
            this.btn200.Text = "200 Lira Yükle";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(6, 72);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(188, 37);
            this.btn100.TabIndex = 2;
            this.btn100.Text = "100 Lira Yükle";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bakiye";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(44, 61);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(94, 31);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "10000";
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(288, 32);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(188, 49);
            this.btnOde.TabIndex = 5;
            this.btnOde.Text = "Ödeme";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 384);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker scre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbOgrenci;
        private System.Windows.Forms.RadioButton rbAktarma4;
        private System.Windows.Forms.RadioButton rbAktarma3;
        private System.Windows.Forms.RadioButton rbAktarma2;
        private System.Windows.Forms.RadioButton rbAktarma1;
        private System.Windows.Forms.RadioButton rbAktarma0;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnOde;
    }
}

