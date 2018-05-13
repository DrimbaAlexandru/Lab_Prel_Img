namespace PI_Lab1.EffectWithGUI
{
    partial class Grayscale_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_apply = new System.Windows.Forms.Button();
            this.tb_R = new System.Windows.Forms.TrackBar();
            this.tb_G = new System.Windows.Forms.TrackBar();
            this.tb_B = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_r_val = new System.Windows.Forms.Label();
            this.lbl_g_val = new System.Windows.Forms.Label();
            this.lbl_b_val = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(77, 172);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // tb_R
            // 
            this.tb_R.LargeChange = 10;
            this.tb_R.Location = new System.Drawing.Point(88, 12);
            this.tb_R.Maximum = 100;
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(104, 45);
            this.tb_R.TabIndex = 1;
            this.tb_R.Value = 100;
            this.tb_R.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // tb_G
            // 
            this.tb_G.LargeChange = 10;
            this.tb_G.Location = new System.Drawing.Point(88, 63);
            this.tb_G.Maximum = 100;
            this.tb_G.Name = "tb_G";
            this.tb_G.Size = new System.Drawing.Size(104, 45);
            this.tb_G.TabIndex = 2;
            this.tb_G.Value = 100;
            this.tb_G.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // tb_B
            // 
            this.tb_B.LargeChange = 10;
            this.tb_B.Location = new System.Drawing.Point(88, 114);
            this.tb_B.Maximum = 100;
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(104, 45);
            this.tb_B.TabIndex = 3;
            this.tb_B.Value = 100;
            this.tb_B.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // lbl_r_val
            // 
            this.lbl_r_val.AutoSize = true;
            this.lbl_r_val.Location = new System.Drawing.Point(199, 18);
            this.lbl_r_val.Name = "lbl_r_val";
            this.lbl_r_val.Size = new System.Drawing.Size(29, 13);
            this.lbl_r_val.TabIndex = 7;
            this.lbl_r_val.Text = "NaN";
            // 
            // lbl_g_val
            // 
            this.lbl_g_val.AutoSize = true;
            this.lbl_g_val.Location = new System.Drawing.Point(199, 69);
            this.lbl_g_val.Name = "lbl_g_val";
            this.lbl_g_val.Size = new System.Drawing.Size(29, 13);
            this.lbl_g_val.TabIndex = 8;
            this.lbl_g_val.Text = "NaN";
            // 
            // lbl_b_val
            // 
            this.lbl_b_val.AutoSize = true;
            this.lbl_b_val.Location = new System.Drawing.Point(199, 120);
            this.lbl_b_val.Name = "lbl_b_val";
            this.lbl_b_val.Size = new System.Drawing.Size(29, 13);
            this.lbl_b_val.TabIndex = 9;
            this.lbl_b_val.Text = "NaN";
            // 
            // Grayscale_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 207);
            this.Controls.Add(this.lbl_b_val);
            this.Controls.Add(this.lbl_g_val);
            this.Controls.Add(this.lbl_r_val);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_G);
            this.Controls.Add(this.tb_R);
            this.Controls.Add(this.btn_apply);
            this.Name = "Grayscale_GUI";
            this.Text = "Grayscale_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.tb_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TrackBar tb_R;
        private System.Windows.Forms.TrackBar tb_G;
        private System.Windows.Forms.TrackBar tb_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_r_val;
        private System.Windows.Forms.Label lbl_g_val;
        private System.Windows.Forms.Label lbl_b_val;
    }
}