namespace BaiTapLamTHem
{
    partial class Chuong6bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chuong6bai1));
            this.tvFile = new System.Windows.Forms.TreeView();
            this.picture = new System.Windows.Forms.PictureBox();
            this.pnIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tvFile
            // 
            this.tvFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvFile.ImageIndex = 0;
            this.tvFile.ImageList = this.imageList1;
            this.tvFile.Location = new System.Drawing.Point(13, 13);
            this.tvFile.Name = "tvFile";
            this.tvFile.SelectedImageIndex = 0;
            this.tvFile.Size = new System.Drawing.Size(211, 413);
            this.tvFile.StateImageList = this.imageList1;
            this.tvFile.TabIndex = 0;
            this.tvFile.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFile_BeforeCollapse);
            this.tvFile.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFile_BeforeExpand);
            this.tvFile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFile_AfterSelect);
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picture.Location = new System.Drawing.Point(249, 13);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(459, 307);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // pnIcon
            // 
            this.pnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnIcon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnIcon.Location = new System.Drawing.Point(249, 326);
            this.pnIcon.Name = "pnIcon";
            this.pnIcon.Size = new System.Drawing.Size(459, 100);
            this.pnIcon.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "backgound2.jpg");
            this.imageList1.Images.SetKeyName(1, "backgound1.jpg");
            // 
            // Chuong6bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 438);
            this.Controls.Add(this.pnIcon);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.tvFile);
            this.Name = "Chuong6bai1";
            this.Text = "Chuong6bai1";
            this.Load += new System.EventHandler(this.Chuong6bai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.FlowLayoutPanel pnIcon;
        private System.Windows.Forms.ImageList imageList1;
    }
}