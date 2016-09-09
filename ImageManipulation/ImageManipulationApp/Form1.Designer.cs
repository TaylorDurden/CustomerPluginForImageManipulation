namespace ImageManipulationApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RadiusBar = new System.Windows.Forms.TrackBar();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.btnUploadImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageFileDialog
            // 
            this.ImageFileDialog.Multiselect = true;
            // 
            // RadiusBar
            // 
            this.RadiusBar.Location = new System.Drawing.Point(360, 95);
            this.RadiusBar.Maximum = 40;
            this.RadiusBar.Name = "RadiusBar";
            this.RadiusBar.Size = new System.Drawing.Size(216, 45);
            this.RadiusBar.TabIndex = 0;
            this.RadiusBar.Scroll += new System.EventHandler(this.RadiusBar_Scroll);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(369, 146);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(86, 21);
            this.tbWidth.TabIndex = 1;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(488, 146);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(88, 21);
            this.tbHeight.TabIndex = 1;
            // 
            // btnUploadImages
            // 
            this.btnUploadImages.Location = new System.Drawing.Point(32, 95);
            this.btnUploadImages.Name = "btnUploadImages";
            this.btnUploadImages.Size = new System.Drawing.Size(226, 72);
            this.btnUploadImages.TabIndex = 2;
            this.btnUploadImages.Text = "Upload Images";
            this.btnUploadImages.UseVisualStyleBackColor = true;
            this.btnUploadImages.Click += new System.EventHandler(this.btnUploadImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(475, 80);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(0, 12);
            this.lblRadius.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadImages);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.RadiusBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RadiusBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImageFileDialog;
        private System.Windows.Forms.TrackBar RadiusBar;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btnUploadImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRadius;
    }
}

