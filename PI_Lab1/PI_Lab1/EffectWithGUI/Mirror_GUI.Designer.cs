namespace PI_Lab1.EffectWithGUI
{
    partial class Mirror_GUI
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
            this.lbl_angle = new System.Windows.Forms.Label();
            this.lbl_y_pos = new System.Windows.Forms.Label();
            this.lbl_x_pos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_angle = new System.Windows.Forms.TrackBar();
            this.tb_y_pos = new System.Windows.Forms.TrackBar();
            this.tb_x_pos = new System.Windows.Forms.TrackBar();
            this.btn_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_y_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_x_pos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_angle
            // 
            this.lbl_angle.AutoSize = true;
            this.lbl_angle.Location = new System.Drawing.Point(222, 148);
            this.lbl_angle.Name = "lbl_angle";
            this.lbl_angle.Size = new System.Drawing.Size(29, 13);
            this.lbl_angle.TabIndex = 19;
            this.lbl_angle.Text = "NaN";
            // 
            // lbl_y_pos
            // 
            this.lbl_y_pos.AutoSize = true;
            this.lbl_y_pos.Location = new System.Drawing.Point(222, 97);
            this.lbl_y_pos.Name = "lbl_y_pos";
            this.lbl_y_pos.Size = new System.Drawing.Size(29, 13);
            this.lbl_y_pos.TabIndex = 18;
            this.lbl_y_pos.Text = "NaN";
            // 
            // lbl_x_pos
            // 
            this.lbl_x_pos.AutoSize = true;
            this.lbl_x_pos.Location = new System.Drawing.Point(222, 46);
            this.lbl_x_pos.Name = "lbl_x_pos";
            this.lbl_x_pos.Size = new System.Drawing.Size(29, 13);
            this.lbl_x_pos.TabIndex = 17;
            this.lbl_x_pos.Text = "NaN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X position";
            // 
            // tb_angle
            // 
            this.tb_angle.LargeChange = 15;
            this.tb_angle.Location = new System.Drawing.Point(111, 142);
            this.tb_angle.Maximum = 359;
            this.tb_angle.Name = "tb_angle";
            this.tb_angle.Size = new System.Drawing.Size(104, 45);
            this.tb_angle.TabIndex = 13;
            this.tb_angle.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // tb_y_pos
            // 
            this.tb_y_pos.LargeChange = 10;
            this.tb_y_pos.Location = new System.Drawing.Point(111, 91);
            this.tb_y_pos.Maximum = 100;
            this.tb_y_pos.Minimum = -100;
            this.tb_y_pos.Name = "tb_y_pos";
            this.tb_y_pos.Size = new System.Drawing.Size(104, 45);
            this.tb_y_pos.TabIndex = 12;
            this.tb_y_pos.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // tb_x_pos
            // 
            this.tb_x_pos.LargeChange = 10;
            this.tb_x_pos.Location = new System.Drawing.Point(111, 40);
            this.tb_x_pos.Maximum = 100;
            this.tb_x_pos.Minimum = -100;
            this.tb_x_pos.Name = "tb_x_pos";
            this.tb_x_pos.Size = new System.Drawing.Size(104, 45);
            this.tb_x_pos.TabIndex = 11;
            this.tb_x_pos.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(100, 200);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 10;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Mirror_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.lbl_angle);
            this.Controls.Add(this.lbl_y_pos);
            this.Controls.Add(this.lbl_x_pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_angle);
            this.Controls.Add(this.tb_y_pos);
            this.Controls.Add(this.tb_x_pos);
            this.Controls.Add(this.btn_apply);
            this.Name = "Mirror_GUI";
            this.Text = "Mirror_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.tb_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_y_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_x_pos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_angle;
        private System.Windows.Forms.Label lbl_y_pos;
        private System.Windows.Forms.Label lbl_x_pos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_angle;
        private System.Windows.Forms.TrackBar tb_y_pos;
        private System.Windows.Forms.TrackBar tb_x_pos;
        private System.Windows.Forms.Button btn_apply;

    }
}