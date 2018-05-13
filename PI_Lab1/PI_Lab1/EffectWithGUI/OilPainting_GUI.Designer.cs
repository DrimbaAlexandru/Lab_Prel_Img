namespace PI_Lab1.EffectWithGUI
{
    partial class OilPainting_GUI
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
            this.lbl_brush = new System.Windows.Forms.Label();
            this.lbl_nr_colors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bw = new System.Windows.Forms.TrackBar();
            this.tb_colors = new System.Windows.Forms.TrackBar();
            this.btn_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_colors)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_brush
            // 
            this.lbl_brush.AutoSize = true;
            this.lbl_brush.Location = new System.Drawing.Point(221, 97);
            this.lbl_brush.Name = "lbl_brush";
            this.lbl_brush.Size = new System.Drawing.Size(29, 13);
            this.lbl_brush.TabIndex = 15;
            this.lbl_brush.Text = "NaN";
            // 
            // lbl_nr_colors
            // 
            this.lbl_nr_colors.AutoSize = true;
            this.lbl_nr_colors.Location = new System.Drawing.Point(221, 46);
            this.lbl_nr_colors.Name = "lbl_nr_colors";
            this.lbl_nr_colors.Size = new System.Drawing.Size(29, 13);
            this.lbl_nr_colors.TabIndex = 14;
            this.lbl_nr_colors.Text = "NaN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brush Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Colors";
            // 
            // tb_bw
            // 
            this.tb_bw.LargeChange = 4;
            this.tb_bw.Location = new System.Drawing.Point(110, 91);
            this.tb_bw.Maximum = 32;
            this.tb_bw.Minimum = 1;
            this.tb_bw.Name = "tb_bw";
            this.tb_bw.Size = new System.Drawing.Size(104, 45);
            this.tb_bw.TabIndex = 11;
            this.tb_bw.Value = 4;
            this.tb_bw.ValueChanged += new System.EventHandler(this.onScrollValueChanged);
            // 
            // tb_colors
            // 
            this.tb_colors.LargeChange = 20;
            this.tb_colors.Location = new System.Drawing.Point(110, 40);
            this.tb_colors.Maximum = 255;
            this.tb_colors.Minimum = 4;
            this.tb_colors.Name = "tb_colors";
            this.tb_colors.Size = new System.Drawing.Size(104, 45);
            this.tb_colors.TabIndex = 10;
            this.tb_colors.Value = 64;
            this.tb_colors.ValueChanged += new System.EventHandler(this.onScrollValueChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(101, 162);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 9;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // OilPainting_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.lbl_brush);
            this.Controls.Add(this.lbl_nr_colors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_bw);
            this.Controls.Add(this.tb_colors);
            this.Controls.Add(this.btn_apply);
            this.Name = "OilPainting_GUI";
            this.Text = "OilPainting_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.tb_bw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_brush;
        private System.Windows.Forms.Label lbl_nr_colors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_bw;
        private System.Windows.Forms.TrackBar tb_colors;
        private System.Windows.Forms.Button btn_apply;
    }
}