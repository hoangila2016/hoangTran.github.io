namespace BaiTapLamTHem
{
    partial class Chuong4Bai1
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btPhai = new System.Windows.Forms.Button();
            this.btTrai = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.lv2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một chuỗi:";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(28, 40);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(165, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn màu:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Cyan",
            "Green",
            "Violet",
            "Black",
            "White"});
            this.comboBox1.Location = new System.Drawing.Point(513, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(28, 77);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(102, 46);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Insert";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btPhai
            // 
            this.btPhai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhai.Location = new System.Drawing.Point(336, 130);
            this.btPhai.Name = "btPhai";
            this.btPhai.Size = new System.Drawing.Size(102, 46);
            this.btPhai.TabIndex = 5;
            this.btPhai.Text = "==>";
            this.btPhai.UseVisualStyleBackColor = false;
            this.btPhai.Click += new System.EventHandler(this.btPhai_Click);
            // 
            // btTrai
            // 
            this.btTrai.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrai.Location = new System.Drawing.Point(336, 195);
            this.btTrai.Name = "btTrai";
            this.btTrai.Size = new System.Drawing.Size(102, 46);
            this.btTrai.TabIndex = 6;
            this.btTrai.Text = "<==";
            this.btTrai.UseVisualStyleBackColor = false;
            this.btTrai.Click += new System.EventHandler(this.btTrai_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(336, 247);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(102, 46);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAll.Location = new System.Drawing.Point(336, 299);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(102, 46);
            this.btClearAll.TabIndex = 8;
            this.btClearAll.Text = "Clear All";
            this.btClearAll.UseVisualStyleBackColor = false;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(336, 351);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(102, 46);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 130);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(283, 293);
            this.lv1.TabIndex = 10;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.List;
            // 
            // lv2
            // 
            this.lv2.HideSelection = false;
            this.lv2.Location = new System.Drawing.Point(495, 130);
            this.lv2.Name = "lv2";
            this.lv2.Size = new System.Drawing.Size(283, 293);
            this.lv2.TabIndex = 11;
            this.lv2.UseCompatibleStateImageBehavior = false;
            this.lv2.View = System.Windows.Forms.View.List;
            // 
            // Chuong4Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv2);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClearAll);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btTrai);
            this.Controls.Add(this.btPhai);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Chuong4Bai1";
            this.Text = "Chuong4Bai1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chuong4Bai1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btPhai;
        private System.Windows.Forms.Button btTrai;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ListView lv2;
    }
}