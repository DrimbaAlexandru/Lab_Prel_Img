namespace PI_Lab1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_btn_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_load = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_btn_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_grayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_contrast_compression = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_imageSubstract = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_left_to_right = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_btn_right_to_left = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_swap_left_right = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_BW = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_drunk_vision = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< origin/versiune-seaca
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.btn_menu_edit_mirror = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.btn_menu_edit_mirror = new System.Windows.Forms.ToolStripMenuItem();
            this.scatteredTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
>>>>>>> local
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_btn_file,
            this.menu_btn_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_btn_file
            // 
            this.menu_btn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_load,
            this.menu_file_save});
            this.menu_btn_file.Name = "menu_btn_file";
            this.menu_btn_file.Size = new System.Drawing.Size(37, 20);
            this.menu_btn_file.Text = "File";
            // 
            // menu_file_load
            // 
            this.menu_file_load.Name = "menu_file_load";
            this.menu_file_load.Size = new System.Drawing.Size(134, 22);
            this.menu_file_load.Text = "Load (left)";
            this.menu_file_load.Click += new System.EventHandler(this.menu_file_load_Click);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.Size = new System.Drawing.Size(134, 22);
            this.menu_file_save.Text = "Save (right)";
            this.menu_file_save.Click += new System.EventHandler(this.menu_file_save_Click);
            // 
            // menu_btn_edit
            // 
            this.menu_btn_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< origin/versiune-seaca
            this.btn_edit_grayscale,
            this.btn_menu_edit_contrast_compression,
            this.btn_menu_edit_imageSubstract,
=======
>>>>>>> local
            this.btn_menu_edit_left_to_right,
            this.btn_menu_edit_btn_right_to_left,
            this.btn_menu_edit_swap_left_right,
            this.btn_edit_grayscale,
            this.btn_edit_menu_BW,
            this.oilPaintingToolStripMenuItem,
            this.btn_menu_drunk_vision,
            this.btn_menu_edit_mirror});
            this.menu_btn_edit.Name = "menu_btn_edit";
            this.menu_btn_edit.Size = new System.Drawing.Size(39, 20);
            this.menu_btn_edit.Text = "Edit";
            // 
            // btn_edit_grayscale
            // 
            this.btn_edit_grayscale.Name = "btn_edit_grayscale";
            this.btn_edit_grayscale.Size = new System.Drawing.Size(159, 22);
            this.btn_edit_grayscale.Text = "Grayscale";
            this.btn_edit_grayscale.Click += new System.EventHandler(this.btn_edit_grayscale_Click);
            // 
            // btn_menu_edit_contrast_compression
            // 
            this.btn_menu_edit_contrast_compression.Name = "btn_menu_edit_contrast_compression";
            this.btn_menu_edit_contrast_compression.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_contrast_compression.Text = "Contrast compression";
            this.btn_menu_edit_contrast_compression.Click += new System.EventHandler(this.btn_menu_edit_contrast_compression_Click);
            // 
            // btn_menu_edit_imageSubstract
            // 
            this.btn_menu_edit_imageSubstract.Name = "btn_menu_edit_imageSubstract";
            this.btn_menu_edit_imageSubstract.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_imageSubstract.Text = "Image substract ( B - A )";
            this.btn_menu_edit_imageSubstract.Click += new System.EventHandler(this.btn_menu_edit_imageSubstract_Click);
            // 
            // btn_menu_edit_left_to_right
            // 
            this.btn_menu_edit_left_to_right.Name = "btn_menu_edit_left_to_right";
            this.btn_menu_edit_left_to_right.Size = new System.Drawing.Size(159, 22);
            this.btn_menu_edit_left_to_right.Text = "Left->Right";
            this.btn_menu_edit_left_to_right.Click += new System.EventHandler(this.btn_menu_edit_left_to_right_Click);
            // 
            // btn_menu_edit_btn_right_to_left
            // 
            this.btn_menu_edit_btn_right_to_left.Name = "btn_menu_edit_btn_right_to_left";
            this.btn_menu_edit_btn_right_to_left.Size = new System.Drawing.Size(159, 22);
            this.btn_menu_edit_btn_right_to_left.Text = "Left<-Right";
            this.btn_menu_edit_btn_right_to_left.Click += new System.EventHandler(this.btn_menu_edit_btn_right_to_left_Click);
            // 
            // btn_menu_edit_swap_left_right
            // 
            this.btn_menu_edit_swap_left_right.Name = "btn_menu_edit_swap_left_right";
            this.btn_menu_edit_swap_left_right.Size = new System.Drawing.Size(159, 22);
            this.btn_menu_edit_swap_left_right.Text = "Left<->Right";
            this.btn_menu_edit_swap_left_right.Click += new System.EventHandler(this.btn_menu_edit_swap_left_right_Click);
            // 
            // btn_edit_menu_BW
            // 
            this.btn_edit_menu_BW.Name = "btn_edit_menu_BW";
            this.btn_edit_menu_BW.Size = new System.Drawing.Size(159, 22);
            this.btn_edit_menu_BW.Text = "Black and White";
            this.btn_edit_menu_BW.Click += new System.EventHandler(this.btn_edit_menu_BW_Click);
            // 
            // oilPaintingToolStripMenuItem
            // 
            this.oilPaintingToolStripMenuItem.Name = "oilPaintingToolStripMenuItem";
            this.oilPaintingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.oilPaintingToolStripMenuItem.Text = "Oil Painting";
            this.oilPaintingToolStripMenuItem.Click += new System.EventHandler(this.btn_edit_menu_oilPainting_click);
            // 
            // btn_menu_drunk_vision
            // 
            this.btn_menu_drunk_vision.Name = "btn_menu_drunk_vision";
            this.btn_menu_drunk_vision.Size = new System.Drawing.Size(159, 22);
            this.btn_menu_drunk_vision.Text = "Drunk Vision";
            this.btn_menu_drunk_vision.Click += new System.EventHandler(this.btn_menu_drunk_vision_Click);
            // 
<<<<<<< origin/versiune-seaca
=======
            // btn_menu_edit_mirror
            // 
            this.btn_menu_edit_mirror.Name = "btn_menu_edit_mirror";
            this.btn_menu_edit_mirror.Size = new System.Drawing.Size(159, 22);
            this.btn_menu_edit_mirror.Text = "Mirror";
            this.btn_menu_edit_mirror.Click += new System.EventHandler(this.btn_menu_edit_mirror_Click);
            // 
            // scatteredTilesToolStripMenuItem
            // 
            this.scatteredTilesToolStripMenuItem.Name = "scatteredTilesToolStripMenuItem";
            this.scatteredTilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.scatteredTilesToolStripMenuItem.Text = "Scattered Tiles";
            this.scatteredTilesToolStripMenuItem.Click += new System.EventHandler(this.scatteredTilesToolStripMenuItem_Click);
            // 
            // pixelateToolStripMenuItem
            // 
            this.pixelateToolStripMenuItem.Name = "pixelateToolStripMenuItem";
            this.pixelateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pixelateToolStripMenuItem.Text = "Pixelate";
            this.pixelateToolStripMenuItem.Click += new System.EventHandler(this.pixelateToolStripMenuItem_Click);
            // 
>>>>>>> local
            // pictureBox_left
            // 
            this.pictureBox_left.Location = new System.Drawing.Point(0, 25);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(480, 360);
            this.pictureBox_left.TabIndex = 1;
            this.pictureBox_left.TabStop = false;
            // 
            // pictureBox_right
            // 
            this.pictureBox_right.Location = new System.Drawing.Point(485, 25);
            this.pictureBox_right.Name = "pictureBox_right";
            this.pictureBox_right.Size = new System.Drawing.Size(480, 360);
            this.pictureBox_right.TabIndex = 2;
            this.pictureBox_right.TabStop = false;
            // 
<<<<<<< origin/versiune-seaca
            // btn_menu_edit_mirror
            // 
            this.btn_menu_edit_mirror.Name = "btn_menu_edit_mirror";
            this.btn_menu_edit_mirror.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_mirror.Text = "Mirror";
            this.btn_menu_edit_mirror.Click += new System.EventHandler(this.btn_menu_edit_mirror_Click);
            // 
=======
>>>>>>> local
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 392);
            this.Controls.Add(this.pictureBox_right);
            this.Controls.Add(this.pictureBox_left);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_file;
        private System.Windows.Forms.ToolStripMenuItem menu_btn_edit;
        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.PictureBox pictureBox_right;
        private System.Windows.Forms.ToolStripMenuItem menu_file_load;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_grayscale;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_contrast_compression;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_imageSubstract;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_left_to_right;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_btn_right_to_left;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_swap_left_right;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_BW;
        private System.Windows.Forms.ToolStripMenuItem oilPaintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_drunk_vision;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_mirror;
    }
}

