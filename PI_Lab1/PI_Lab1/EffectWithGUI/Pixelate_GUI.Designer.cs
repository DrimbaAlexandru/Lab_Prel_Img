namespace PI_Lab1.EffectWithGUI
{
    partial class Pixelate_GUI
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
            this.tb_pixel_size = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pixel_size)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixel size";
            // 
            // tb_pixel_size
            // 
            this.tb_pixel_size.Location = new System.Drawing.Point(66, 55);
            this.tb_pixel_size.Maximum = 255;
            this.tb_pixel_size.Minimum = 1;
            this.tb_pixel_size.Name = "tb_pixel_size";
            this.tb_pixel_size.Size = new System.Drawing.Size(176, 45);
            this.tb_pixel_size.TabIndex = 1;
            this.tb_pixel_size.Value = 25;
            this.tb_pixel_size.ValueChanged += new System.EventHandler(this.onScrollValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(249, 64);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(29, 13);
            this.lbl_size.TabIndex = 3;
            this.lbl_size.Text = "NaN";
            // 
            // Pixelate_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 176);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pixel_size);
            this.Controls.Add(this.label1);
            this.Name = "Pixelate_GUI";
            this.Text = "Pixelate_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.tb_pixel_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_pixel_size;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_size;
    }
}