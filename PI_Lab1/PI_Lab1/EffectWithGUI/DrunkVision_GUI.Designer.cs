namespace PI_Lab1.EffectWithGUI
{
    partial class DrunkVision_GUI
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
            this.lbl_drunkenness = new System.Windows.Forms.Label();
            this.lbl_nr_eyes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_drunk = new System.Windows.Forms.TrackBar();
            this.tb_eyes = new System.Windows.Forms.TrackBar();
            this.btn_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_drunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_eyes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_drunkenness
            // 
            this.lbl_drunkenness.AutoSize = true;
            this.lbl_drunkenness.Location = new System.Drawing.Point(221, 116);
            this.lbl_drunkenness.Name = "lbl_drunkenness";
            this.lbl_drunkenness.Size = new System.Drawing.Size(29, 13);
            this.lbl_drunkenness.TabIndex = 22;
            this.lbl_drunkenness.Text = "NaN";
            // 
            // lbl_nr_eyes
            // 
            this.lbl_nr_eyes.AutoSize = true;
            this.lbl_nr_eyes.Location = new System.Drawing.Point(221, 65);
            this.lbl_nr_eyes.Name = "lbl_nr_eyes";
            this.lbl_nr_eyes.Size = new System.Drawing.Size(29, 13);
            this.lbl_nr_eyes.TabIndex = 21;
            this.lbl_nr_eyes.Text = "NaN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Drunkenness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "No. of eyes";
            // 
            // tb_drunk
            // 
            this.tb_drunk.Location = new System.Drawing.Point(110, 110);
            this.tb_drunk.Maximum = 50;
            this.tb_drunk.Minimum = 1;
            this.tb_drunk.Name = "tb_drunk";
            this.tb_drunk.Size = new System.Drawing.Size(104, 45);
            this.tb_drunk.TabIndex = 18;
            this.tb_drunk.Value = 10;
            this.tb_drunk.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // tb_eyes
            // 
            this.tb_eyes.LargeChange = 2;
            this.tb_eyes.Location = new System.Drawing.Point(110, 59);
            this.tb_eyes.Maximum = 16;
            this.tb_eyes.Minimum = 2;
            this.tb_eyes.Name = "tb_eyes";
            this.tb_eyes.Size = new System.Drawing.Size(104, 45);
            this.tb_eyes.TabIndex = 17;
            this.tb_eyes.Value = 2;
            this.tb_eyes.ValueChanged += new System.EventHandler(this.onSliderValueChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(101, 181);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 16;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // DrunkVision_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.lbl_drunkenness);
            this.Controls.Add(this.lbl_nr_eyes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_drunk);
            this.Controls.Add(this.tb_eyes);
            this.Controls.Add(this.btn_apply);
            this.Name = "DrunkVision_GUI";
            this.Text = "DrunkVision_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.tb_drunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_eyes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_drunkenness;
        private System.Windows.Forms.Label lbl_nr_eyes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_drunk;
        private System.Windows.Forms.TrackBar tb_eyes;
        private System.Windows.Forms.Button btn_apply;
    }
}