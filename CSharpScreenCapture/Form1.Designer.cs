namespace CSharpScreenCapture
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgdisp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsaved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgdisp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(15, 36);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(117, 23);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Screen Capture Demo";
            // 
            // imgdisp
            // 
            this.imgdisp.Location = new System.Drawing.Point(12, 103);
            this.imgdisp.Name = "imgdisp";
            this.imgdisp.Size = new System.Drawing.Size(285, 244);
            this.imgdisp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdisp.TabIndex = 2;
            this.imgdisp.TabStop = false;
            this.imgdisp.Click += new System.EventHandler(this.imgdisp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saved To: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblsaved
            // 
            this.lblsaved.AutoSize = true;
            this.lblsaved.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblsaved.Location = new System.Drawing.Point(78, 74);
            this.lblsaved.Name = "lblsaved";
            this.lblsaved.Size = new System.Drawing.Size(16, 13);
            this.lblsaved.TabIndex = 4;
            this.lblsaved.Text = "---";
            this.lblsaved.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblsaved.Click += new System.EventHandler(this.lblsaved_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 360);
            this.Controls.Add(this.lblsaved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgdisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapture);
            this.Name = "Form1";
            this.Text = "Capture Screen Demo";
            ((System.ComponentModel.ISupportInitialize)(this.imgdisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgdisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsaved;
    }
}

