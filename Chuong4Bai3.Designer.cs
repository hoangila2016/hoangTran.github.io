namespace BaiTapLamTHem
{
    partial class Chuong4Bai3
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
            this.components = new System.ComponentModel.Container();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.btChon1 = new System.Windows.Forms.Button();
            this.btChonNhieu = new System.Windows.Forms.Button();
            this.btMauNen = new System.Windows.Forms.Button();
            this.btFolder = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.btMauChu = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(272, 12);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(516, 357);
            this.rtContent.TabIndex = 0;
            this.rtContent.Text = "";
            this.rtContent.TextChanged += new System.EventHandler(this.rtContent_TextChanged);
            // 
            // btChon1
            // 
            this.btChon1.Location = new System.Drawing.Point(12, 44);
            this.btChon1.Name = "btChon1";
            this.btChon1.Size = new System.Drawing.Size(236, 49);
            this.btChon1.TabIndex = 1;
            this.btChon1.Text = "Chọn 1 File";
            this.btChon1.UseVisualStyleBackColor = true;
            this.btChon1.Click += new System.EventHandler(this.btChon1_Click);
            // 
            // btChonNhieu
            // 
            this.btChonNhieu.Location = new System.Drawing.Point(12, 112);
            this.btChonNhieu.Name = "btChonNhieu";
            this.btChonNhieu.Size = new System.Drawing.Size(236, 49);
            this.btChonNhieu.TabIndex = 2;
            this.btChonNhieu.Text = "Chọn nhiều file";
            this.btChonNhieu.UseVisualStyleBackColor = true;
            this.btChonNhieu.Click += new System.EventHandler(this.btChonNhieu_Click);
            // 
            // btMauNen
            // 
            this.btMauNen.Location = new System.Drawing.Point(12, 251);
            this.btMauNen.Name = "btMauNen";
            this.btMauNen.Size = new System.Drawing.Size(236, 49);
            this.btMauNen.TabIndex = 4;
            this.btMauNen.Text = "Màu Nền";
            this.btMauNen.UseVisualStyleBackColor = true;
            this.btMauNen.Click += new System.EventHandler(this.btMauNen_Click);
            // 
            // btFolder
            // 
            this.btFolder.Location = new System.Drawing.Point(12, 183);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(236, 49);
            this.btFolder.TabIndex = 3;
            this.btFolder.Text = "Chọn Folder";
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.btFolder_Click);
            // 
            // btFont
            // 
            this.btFont.Location = new System.Drawing.Point(12, 388);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(236, 49);
            this.btFont.TabIndex = 6;
            this.btFont.Text = "Chọn font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // btMauChu
            // 
            this.btMauChu.Location = new System.Drawing.Point(12, 323);
            this.btMauChu.Name = "btMauChu";
            this.btMauChu.Size = new System.Drawing.Size(236, 49);
            this.btMauChu.TabIndex = 5;
            this.btMauChu.Text = "màu chữ";
            this.btMauChu.UseVisualStyleBackColor = true;
            this.btMauChu.Click += new System.EventHandler(this.btSize_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(272, 388);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(236, 49);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(539, 389);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(236, 49);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Chuong4Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.btMauChu);
            this.Controls.Add(this.btMauNen);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.btChonNhieu);
            this.Controls.Add(this.btChon1);
            this.Controls.Add(this.rtContent);
            this.Name = "Chuong4Bai3";
            this.Opacity = 0D;
            this.Text = "Chuong4Bai3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chuong4Bai3_FormClosing);
            this.Load += new System.EventHandler(this.Chuong4Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Button btChon1;
        private System.Windows.Forms.Button btChonNhieu;
        private System.Windows.Forms.Button btMauNen;
        private System.Windows.Forms.Button btFolder;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Button btMauChu;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}