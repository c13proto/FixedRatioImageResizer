namespace FixedRatioImageResizer
{
    partial class FixedRatioImageResizer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_frame = new System.Windows.Forms.TextBox();
            this.label_frame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_g = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(91, 20);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "open images";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "height";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(18, 50);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(30, 19);
            this.textBox_width.TabIndex = 3;
            this.textBox_width.Text = "1280";
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(56, 50);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(30, 19);
            this.textBox_height.TabIndex = 4;
            this.textBox_height.Text = "1280";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(14, 149);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(91, 20);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_frame
            // 
            this.textBox_frame.Location = new System.Drawing.Point(14, 87);
            this.textBox_frame.Name = "textBox_frame";
            this.textBox_frame.Size = new System.Drawing.Size(30, 19);
            this.textBox_frame.TabIndex = 8;
            this.textBox_frame.Text = "1";
            // 
            // label_frame
            // 
            this.label_frame.AutoSize = true;
            this.label_frame.Location = new System.Drawing.Point(12, 72);
            this.label_frame.Name = "label_frame";
            this.label_frame.Size = new System.Drawing.Size(62, 12);
            this.label_frame.TabIndex = 7;
            this.label_frame.Text = "frameWidth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "background (r,g,b)";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(14, 124);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(23, 19);
            this.textBox_r.TabIndex = 10;
            this.textBox_r.Text = "255";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(72, 124);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(23, 19);
            this.textBox_b.TabIndex = 12;
            this.textBox_b.Text = "255";
            // 
            // textBox_g
            // 
            this.textBox_g.Location = new System.Drawing.Point(43, 124);
            this.textBox_g.Name = "textBox_g";
            this.textBox_g.Size = new System.Drawing.Size(23, 19);
            this.textBox_g.TabIndex = 13;
            this.textBox_g.Text = "255";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FixedRatioImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this.textBox_g);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_r);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_frame);
            this.Controls.Add(this.label_frame);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FixedRatioImageResizer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FixedRatioImageResizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_frame;
        private System.Windows.Forms.Label label_frame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_g;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

