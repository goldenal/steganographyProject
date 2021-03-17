namespace finalyear
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encode_btn = new System.Windows.Forms.Button();
            this.decode_btn = new System.Windows.Forms.Button();
            this.filePath_tbx = new System.Windows.Forms.TextBox();
            this.message_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encode_btn
            // 
            this.encode_btn.Location = new System.Drawing.Point(196, 420);
            this.encode_btn.Name = "encode_btn";
            this.encode_btn.Size = new System.Drawing.Size(75, 23);
            this.encode_btn.TabIndex = 2;
            this.encode_btn.Text = "Encode";
            this.encode_btn.UseVisualStyleBackColor = true;
            this.encode_btn.Click += new System.EventHandler(this.encode_btn_Click);
            // 
            // decode_btn
            // 
            this.decode_btn.Location = new System.Drawing.Point(287, 420);
            this.decode_btn.Name = "decode_btn";
            this.decode_btn.Size = new System.Drawing.Size(75, 23);
            this.decode_btn.TabIndex = 3;
            this.decode_btn.Text = "Decode";
            this.decode_btn.UseVisualStyleBackColor = true;
            // 
            // filePath_tbx
            // 
            this.filePath_tbx.Location = new System.Drawing.Point(253, 257);
            this.filePath_tbx.Name = "filePath_tbx";
            this.filePath_tbx.Size = new System.Drawing.Size(179, 20);
            this.filePath_tbx.TabIndex = 4;
            // 
            // message_tbx
            // 
            this.message_tbx.Location = new System.Drawing.Point(272, 363);
            this.message_tbx.Name = "message_tbx";
            this.message_tbx.Size = new System.Drawing.Size(194, 20);
            this.message_tbx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message_tbx);
            this.Controls.Add(this.filePath_tbx);
            this.Controls.Add(this.decode_btn);
            this.Controls.Add(this.encode_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button encode_btn;
        private System.Windows.Forms.Button decode_btn;
        private System.Windows.Forms.TextBox filePath_tbx;
        private System.Windows.Forms.TextBox message_tbx;
        private System.Windows.Forms.Label label1;
    }
}

