namespace BaiTapLamTHem
{
    partial class Chuong4Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFont = new System.Windows.Forms.ListBox();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.btU = new System.Windows.Forms.Button();
            this.bti = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hscRed = new System.Windows.Forms.HScrollBar();
            this.hscBlue = new System.Windows.Forms.HScrollBar();
            this.hscGreen = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // lbFont
            // 
            this.lbFont.FormattingEnabled = true;
            this.lbFont.ItemHeight = 16;
            this.lbFont.Items.AddRange(new object[] {
            "VnPresent",
            "VnPresentH",
            "VnTime",
            "VnTimeH",
            "Arial",
            "Microsoft Sans Serif",
            "Mistral"});
            this.lbFont.Location = new System.Drawing.Point(13, 60);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(253, 276);
            this.lbFont.TabIndex = 2;
            this.lbFont.SelectedIndexChanged += new System.EventHandler(this.lbFont_SelectedIndexChanged);
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(291, 60);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(497, 276);
            this.rtContent.TabIndex = 3;
            this.rtContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "size:";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbSize.Location = new System.Drawing.Point(82, 391);
            this.cbSize.MaxDropDownItems = 5;
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(123, 24);
            this.cbSize.TabIndex = 5;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(413, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 23);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btB
            // 
            this.btB.Location = new System.Drawing.Point(223, 391);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(43, 33);
            this.btB.TabIndex = 6;
            this.btB.Text = "B";
            this.btB.UseVisualStyleBackColor = true;
            this.btB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btU
            // 
            this.btU.Location = new System.Drawing.Point(321, 391);
            this.btU.Name = "btU";
            this.btU.Size = new System.Drawing.Size(43, 33);
            this.btU.TabIndex = 7;
            this.btU.Text = "u";
            this.btU.UseVisualStyleBackColor = true;
            this.btU.Click += new System.EventHandler(this.btU_Click);
            // 
            // bti
            // 
            this.bti.Location = new System.Drawing.Point(272, 391);
            this.bti.Name = "bti";
            this.bti.Size = new System.Drawing.Size(43, 33);
            this.bti.TabIndex = 8;
            this.bti.Text = "/";
            this.bti.UseVisualStyleBackColor = true;
            this.bti.Click += new System.EventHandler(this.bti_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(413, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 23);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(413, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 23);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // hscRed
            // 
            this.hscRed.Location = new System.Drawing.Point(487, 352);
            this.hscRed.Maximum = 255;
            this.hscRed.Name = "hscRed";
            this.hscRed.Size = new System.Drawing.Size(301, 21);
            this.hscRed.TabIndex = 12;
            this.hscRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscRed_Scroll);
            // 
            // hscBlue
            // 
            this.hscBlue.Location = new System.Drawing.Point(487, 383);
            this.hscBlue.Maximum = 255;
            this.hscBlue.Name = "hscBlue";
            this.hscBlue.Size = new System.Drawing.Size(301, 21);
            this.hscBlue.TabIndex = 13;
            this.hscBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscRed_Scroll);
            // 
            // hscGreen
            // 
            this.hscGreen.Location = new System.Drawing.Point(487, 412);
            this.hscGreen.Maximum = 255;
            this.hscGreen.Name = "hscGreen";
            this.hscGreen.Size = new System.Drawing.Size(301, 21);
            this.hscGreen.TabIndex = 14;
            this.hscGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscRed_Scroll);
            // 
            // Chuong4Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hscGreen);
            this.Controls.Add(this.hscBlue);
            this.Controls.Add(this.hscRed);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bti);
            this.Controls.Add(this.btU);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtContent);
            this.Controls.Add(this.lbFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chuong4Bai2";
            this.Text = "Chuong4Bai2";
            this.Load += new System.EventHandler(this.Chuong4Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFont;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btB;
        private System.Windows.Forms.Button btU;
        private System.Windows.Forms.Button bti;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.HScrollBar hscRed;
        private System.Windows.Forms.HScrollBar hscBlue;
        private System.Windows.Forms.HScrollBar hscGreen;
    }
}