namespace RSAAppDestop
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
            System.Windows.Forms.Label lablele;
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryt_Btn = new System.Windows.Forms.Button();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createNumber_Btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypt_Btn = new System.Windows.Forms.Button();
            this.createKey_Btn = new System.Windows.Forms.Button();
            this.randomNumber_Btn = new System.Windows.Forms.RadioButton();
            this.messageDecryt_Rtb = new System.Windows.Forms.RichTextBox();
            this.encryt_Rtb = new System.Windows.Forms.RichTextBox();
            this.decrypt_Rtb = new System.Windows.Forms.RichTextBox();
            this.messageEncryt_Rtb = new System.Windows.Forms.RichTextBox();
            this.numberD_Txt = new System.Windows.Forms.TextBox();
            this.numberE_Txt = new System.Windows.Forms.TextBox();
            this.numberP_Txt = new System.Windows.Forms.TextBox();
            this.numberN_Txt = new System.Windows.Forms.TextBox();
            this.numberQ_Txt = new System.Windows.Forms.TextBox();
            this.numberPhi_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lebald = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberQ_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelphi = new System.Windows.Forms.Label();
            this.rsaTab = new System.Windows.Forms.TabControl();
            lablele = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.rsaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lablele
            // 
            lablele.AutoEllipsis = true;
            lablele.AutoSize = true;
            lablele.Location = new System.Drawing.Point(72, 279);
            lablele.Name = "lablele";
            lablele.Size = new System.Drawing.Size(45, 16);
            lablele.TabIndex = 31;
            lablele.Text = "Số e =";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comming soon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.encryt_Btn);
            this.tabPage1.Controls.Add(this.Reset_Btn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.createNumber_Btn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.decrypt_Btn);
            this.tabPage1.Controls.Add(this.createKey_Btn);
            this.tabPage1.Controls.Add(this.randomNumber_Btn);
            this.tabPage1.Controls.Add(this.messageDecryt_Rtb);
            this.tabPage1.Controls.Add(this.encryt_Rtb);
            this.tabPage1.Controls.Add(this.decrypt_Rtb);
            this.tabPage1.Controls.Add(this.messageEncryt_Rtb);
            this.tabPage1.Controls.Add(this.numberD_Txt);
            this.tabPage1.Controls.Add(this.numberE_Txt);
            this.tabPage1.Controls.Add(this.numberP_Txt);
            this.tabPage1.Controls.Add(this.numberN_Txt);
            this.tabPage1.Controls.Add(this.numberQ_Txt);
            this.tabPage1.Controls.Add(this.numberPhi_Txt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lebald);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(lablele);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.labeln);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numberQ_text);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelphi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            // 
            // encryt_Btn
            // 
            this.encryt_Btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.encryt_Btn.FlatAppearance.BorderSize = 0;
            this.encryt_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryt_Btn.Location = new System.Drawing.Point(709, 146);
            this.encryt_Btn.Name = "encryt_Btn";
            this.encryt_Btn.Size = new System.Drawing.Size(75, 44);
            this.encryt_Btn.TabIndex = 53;
            this.encryt_Btn.Text = "Mã hóa";
            this.encryt_Btn.UseVisualStyleBackColor = false;
            this.encryt_Btn.Click += new System.EventHandler(this.encryt_Btn_Click);
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Reset_Btn.FlatAppearance.BorderSize = 0;
            this.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Btn.Location = new System.Drawing.Point(1005, 12);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(75, 44);
            this.Reset_Btn.TabIndex = 52;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = false;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(812, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Bảng rõ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Bảng mã hóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(812, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Bảng mã hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Bảng rõ";
            // 
            // createNumber_Btn
            // 
            this.createNumber_Btn.AutoSize = true;
            this.createNumber_Btn.Location = new System.Drawing.Point(218, 53);
            this.createNumber_Btn.Name = "createNumber_Btn";
            this.createNumber_Btn.Size = new System.Drawing.Size(121, 20);
            this.createNumber_Btn.TabIndex = 46;
            this.createNumber_Btn.TabStop = true;
            this.createNumber_Btn.Text = "Tự tạo mã khóa";
            this.createNumber_Btn.UseVisualStyleBackColor = true;
            this.createNumber_Btn.CheckedChanged += new System.EventHandler(this.createNumber_Btn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giải mã";
            // 
            // decrypt_Btn
            // 
            this.decrypt_Btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.decrypt_Btn.FlatAppearance.BorderSize = 0;
            this.decrypt_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt_Btn.Location = new System.Drawing.Point(709, 378);
            this.decrypt_Btn.Name = "decrypt_Btn";
            this.decrypt_Btn.Size = new System.Drawing.Size(75, 44);
            this.decrypt_Btn.TabIndex = 44;
            this.decrypt_Btn.Text = "Giải mã";
            this.decrypt_Btn.UseVisualStyleBackColor = false;
            this.decrypt_Btn.Click += new System.EventHandler(this.decrypt_Btn_Click);
            // 
            // createKey_Btn
            // 
            this.createKey_Btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.createKey_Btn.FlatAppearance.BorderSize = 0;
            this.createKey_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createKey_Btn.Location = new System.Drawing.Point(113, 417);
            this.createKey_Btn.Name = "createKey_Btn";
            this.createKey_Btn.Size = new System.Drawing.Size(198, 45);
            this.createKey_Btn.TabIndex = 43;
            this.createKey_Btn.Text = "Tạo khóa";
            this.createKey_Btn.UseVisualStyleBackColor = false;
            this.createKey_Btn.Click += new System.EventHandler(this.createKey_Btn_Click);
            // 
            // randomNumber_Btn
            // 
            this.randomNumber_Btn.AutoSize = true;
            this.randomNumber_Btn.Location = new System.Drawing.Point(56, 53);
            this.randomNumber_Btn.Name = "randomNumber_Btn";
            this.randomNumber_Btn.Size = new System.Drawing.Size(135, 20);
            this.randomNumber_Btn.TabIndex = 41;
            this.randomNumber_Btn.TabStop = true;
            this.randomNumber_Btn.Text = "Random mã khóa";
            this.randomNumber_Btn.UseVisualStyleBackColor = true;
            this.randomNumber_Btn.CheckedChanged += new System.EventHandler(this.randomNumber_Btn_CheckedChanged);
            // 
            // messageDecryt_Rtb
            // 
            this.messageDecryt_Rtb.Location = new System.Drawing.Point(815, 323);
            this.messageDecryt_Rtb.Name = "messageDecryt_Rtb";
            this.messageDecryt_Rtb.Size = new System.Drawing.Size(265, 164);
            this.messageDecryt_Rtb.TabIndex = 39;
            this.messageDecryt_Rtb.Text = "";
            // 
            // encryt_Rtb
            // 
            this.encryt_Rtb.Location = new System.Drawing.Point(815, 89);
            this.encryt_Rtb.Name = "encryt_Rtb";
            this.encryt_Rtb.Size = new System.Drawing.Size(265, 164);
            this.encryt_Rtb.TabIndex = 38;
            this.encryt_Rtb.Text = "";
            // 
            // decrypt_Rtb
            // 
            this.decrypt_Rtb.Location = new System.Drawing.Point(413, 320);
            this.decrypt_Rtb.Name = "decrypt_Rtb";
            this.decrypt_Rtb.Size = new System.Drawing.Size(265, 164);
            this.decrypt_Rtb.TabIndex = 37;
            this.decrypt_Rtb.Text = "";
            // 
            // messageEncryt_Rtb
            // 
            this.messageEncryt_Rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageEncryt_Rtb.Location = new System.Drawing.Point(413, 89);
            this.messageEncryt_Rtb.Name = "messageEncryt_Rtb";
            this.messageEncryt_Rtb.Size = new System.Drawing.Size(265, 164);
            this.messageEncryt_Rtb.TabIndex = 35;
            this.messageEncryt_Rtb.Text = "";
            // 
            // numberD_Txt
            // 
            this.numberD_Txt.Location = new System.Drawing.Point(197, 357);
            this.numberD_Txt.Name = "numberD_Txt";
            this.numberD_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberD_Txt.TabIndex = 33;
            // 
            // numberE_Txt
            // 
            this.numberE_Txt.Location = new System.Drawing.Point(197, 276);
            this.numberE_Txt.Name = "numberE_Txt";
            this.numberE_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberE_Txt.TabIndex = 30;
            // 
            // numberP_Txt
            // 
            this.numberP_Txt.Location = new System.Drawing.Point(197, 89);
            this.numberP_Txt.Name = "numberP_Txt";
            this.numberP_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberP_Txt.TabIndex = 19;
            // 
            // numberN_Txt
            // 
            this.numberN_Txt.Location = new System.Drawing.Point(197, 244);
            this.numberN_Txt.Name = "numberN_Txt";
            this.numberN_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberN_Txt.TabIndex = 28;
            // 
            // numberQ_Txt
            // 
            this.numberQ_Txt.Location = new System.Drawing.Point(197, 121);
            this.numberQ_Txt.Name = "numberQ_Txt";
            this.numberQ_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberQ_Txt.TabIndex = 22;
            // 
            // numberPhi_Txt
            // 
            this.numberPhi_Txt.Location = new System.Drawing.Point(197, 157);
            this.numberPhi_Txt.Name = "numberPhi_Txt";
            this.numberPhi_Txt.Size = new System.Drawing.Size(158, 22);
            this.numberPhi_Txt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(715, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã hóa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lebald
            // 
            this.lebald.AutoEllipsis = true;
            this.lebald.AutoSize = true;
            this.lebald.Location = new System.Drawing.Point(72, 360);
            this.lebald.Name = "lebald";
            this.lebald.Size = new System.Drawing.Size(48, 16);
            this.lebald.TabIndex = 34;
            this.lebald.Text = "Số d = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Khóa bí mật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tạo khóa";
            // 
            // labeln
            // 
            this.labeln.AutoEllipsis = true;
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(72, 247);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(47, 16);
            this.labeln.TabIndex = 29;
            this.labeln.Text = "Số n = ";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số nguyên tố p =";
            // 
            // numberQ_text
            // 
            this.numberQ_text.AutoEllipsis = true;
            this.numberQ_text.AutoSize = true;
            this.numberQ_text.Location = new System.Drawing.Point(72, 124);
            this.numberQ_text.Name = "numberQ_text";
            this.numberQ_text.Size = new System.Drawing.Size(106, 16);
            this.numberQ_text.TabIndex = 23;
            this.numberQ_text.Text = "Số nguyên tố q =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cặp khóa công khai";
            // 
            // labelphi
            // 
            this.labelphi.AutoEllipsis = true;
            this.labelphi.AutoSize = true;
            this.labelphi.Location = new System.Drawing.Point(72, 160);
            this.labelphi.Name = "labelphi";
            this.labelphi.Size = new System.Drawing.Size(115, 16);
            this.labelphi.TabIndex = 25;
            this.labelphi.Text = "Φ(n) = (q-1)*(p-1) =";
            // 
            // rsaTab
            // 
            this.rsaTab.Controls.Add(this.tabPage1);
            this.rsaTab.Controls.Add(this.tabPage2);
            this.rsaTab.Location = new System.Drawing.Point(1, 0);
            this.rsaTab.Name = "rsaTab";
            this.rsaTab.SelectedIndex = 0;
            this.rsaTab.Size = new System.Drawing.Size(1108, 568);
            this.rsaTab.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 570);
            this.Controls.Add(this.rsaTab);
            this.Name = "Form1";
            this.Text = "Chương trình mã hóa RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.rsaTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Reset_Btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton createNumber_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decrypt_Btn;
        private System.Windows.Forms.Button createKey_Btn;
        private System.Windows.Forms.RadioButton randomNumber_Btn;
        private System.Windows.Forms.RichTextBox messageDecryt_Rtb;
        private System.Windows.Forms.RichTextBox encryt_Rtb;
        private System.Windows.Forms.RichTextBox decrypt_Rtb;
        private System.Windows.Forms.RichTextBox messageEncryt_Rtb;
        private System.Windows.Forms.TextBox numberD_Txt;
        private System.Windows.Forms.TextBox numberE_Txt;
        private System.Windows.Forms.TextBox numberP_Txt;
        private System.Windows.Forms.TextBox numberN_Txt;
        private System.Windows.Forms.TextBox numberQ_Txt;
        private System.Windows.Forms.TextBox numberPhi_Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lebald;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberQ_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelphi;
        private System.Windows.Forms.TabControl rsaTab;
        private System.Windows.Forms.Button encryt_Btn;
    }
}

