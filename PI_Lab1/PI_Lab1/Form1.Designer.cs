﻿namespace PI_Lab1
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
            this.btn_menu_edit_left_to_right = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_btn_right_to_left = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_swap_left_right = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_filter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_CISS = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_pseudocolouring = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_BW = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_contour = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_Skeletization = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit_menu_shrinking = new System.Windows.Forms.ToolStripMenuItem();
            this.oilPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_drunk_vision = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_edit_mirror = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.scatteredTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btn_edit_grayscale,
            this.btn_menu_edit_left_to_right,
            this.btn_menu_edit_btn_right_to_left,
            this.btn_menu_edit_swap_left_right,
            this.btn_menu_edit_filter1,
            this.btn_edit_menu_CISS,
            this.btn_edit_menu_pseudocolouring,
            this.btn_edit_menu_BW,
            this.btn_edit_menu_contour,
            this.btn_edit_menu_Skeletization,
            this.btn_edit_menu_shrinking,
            this.oilPaintingToolStripMenuItem,
            this.btn_menu_drunk_vision,
            this.btn_menu_edit_mirror,
            this.scatteredTilesToolStripMenuItem,
            this.pixelateToolStripMenuItem});
            this.menu_btn_edit.Name = "menu_btn_edit";
            this.menu_btn_edit.Size = new System.Drawing.Size(39, 20);
            this.menu_btn_edit.Text = "Edit";
            // 
            // btn_edit_grayscale
            // 
            this.btn_edit_grayscale.Name = "btn_edit_grayscale";
            this.btn_edit_grayscale.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_grayscale.Text = "Grayscale";
            this.btn_edit_grayscale.Click += new System.EventHandler(this.btn_edit_grayscale_Click);
            // 
            // btn_menu_edit_left_to_right
            // 
            this.btn_menu_edit_left_to_right.Name = "btn_menu_edit_left_to_right";
            this.btn_menu_edit_left_to_right.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_left_to_right.Text = "Left->Right";
            this.btn_menu_edit_left_to_right.Click += new System.EventHandler(this.btn_menu_edit_left_to_right_Click);
            // 
            // btn_menu_edit_btn_right_to_left
            // 
            this.btn_menu_edit_btn_right_to_left.Name = "btn_menu_edit_btn_right_to_left";
            this.btn_menu_edit_btn_right_to_left.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_btn_right_to_left.Text = "Left<-Right";
            this.btn_menu_edit_btn_right_to_left.Click += new System.EventHandler(this.btn_menu_edit_btn_right_to_left_Click);
            // 
            // btn_menu_edit_swap_left_right
            // 
            this.btn_menu_edit_swap_left_right.Name = "btn_menu_edit_swap_left_right";
            this.btn_menu_edit_swap_left_right.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_swap_left_right.Text = "Left<->Right";
            this.btn_menu_edit_swap_left_right.Click += new System.EventHandler(this.btn_menu_edit_swap_left_right_Click);
            // 
            // btn_menu_edit_filter1
            // 
            this.btn_menu_edit_filter1.Name = "btn_menu_edit_filter1";
            this.btn_menu_edit_filter1.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_filter1.Text = "Directional Filter";
            this.btn_menu_edit_filter1.Click += new System.EventHandler(this.btn_menu_edit_filter1_Click);
            // 
            // btn_edit_menu_CISS
            // 
            this.btn_edit_menu_CISS.Name = "btn_edit_menu_CISS";
            this.btn_edit_menu_CISS.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_CISS.Text = "Contrast invert and statistic scaling";
            this.btn_edit_menu_CISS.Click += new System.EventHandler(this.btn_edit_menu_CISS_Click);
            // 
            // btn_edit_menu_pseudocolouring
            // 
            this.btn_edit_menu_pseudocolouring.Name = "btn_edit_menu_pseudocolouring";
            this.btn_edit_menu_pseudocolouring.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_pseudocolouring.Text = "Pseudocolouring";
            this.btn_edit_menu_pseudocolouring.Click += new System.EventHandler(this.btn_edit_menu_pseudocolouring_Click);
            // 
            // btn_edit_menu_BW
            // 
            this.btn_edit_menu_BW.Name = "btn_edit_menu_BW";
            this.btn_edit_menu_BW.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_BW.Text = "Black and White";
            this.btn_edit_menu_BW.Click += new System.EventHandler(this.btn_edit_menu_BW_Click);
            // 
            // btn_edit_menu_contour
            // 
            this.btn_edit_menu_contour.Name = "btn_edit_menu_contour";
            this.btn_edit_menu_contour.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_contour.Text = "Contour";
            this.btn_edit_menu_contour.Click += new System.EventHandler(this.btn_edit_menu_contour_Click);
            // 
            // btn_edit_menu_Skeletization
            // 
            this.btn_edit_menu_Skeletization.Name = "btn_edit_menu_Skeletization";
            this.btn_edit_menu_Skeletization.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_Skeletization.Text = "Skeletonize";
            this.btn_edit_menu_Skeletization.Click += new System.EventHandler(this.btn_edit_menu_Skeletization_Click);
            // 
            // btn_edit_menu_shrinking
            // 
            this.btn_edit_menu_shrinking.Name = "btn_edit_menu_shrinking";
            this.btn_edit_menu_shrinking.Size = new System.Drawing.Size(258, 22);
            this.btn_edit_menu_shrinking.Text = "Thining";
            this.btn_edit_menu_shrinking.Click += new System.EventHandler(this.btn_edit_menu_shrinking_Click);
            // 
            // oilPaintingToolStripMenuItem
            // 
            this.oilPaintingToolStripMenuItem.Name = "oilPaintingToolStripMenuItem";
            this.oilPaintingToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.oilPaintingToolStripMenuItem.Text = "Oil Painting";
            this.oilPaintingToolStripMenuItem.Click += new System.EventHandler(this.btn_edit_menu_oilPainting_click);
            // 
            // btn_menu_drunk_vision
            // 
            this.btn_menu_drunk_vision.Name = "btn_menu_drunk_vision";
            this.btn_menu_drunk_vision.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_drunk_vision.Text = "Drunk Vision";
            this.btn_menu_drunk_vision.Click += new System.EventHandler(this.btn_menu_drunk_vision_Click);
            // 
            // btn_menu_edit_mirror
            // 
            this.btn_menu_edit_mirror.Name = "btn_menu_edit_mirror";
            this.btn_menu_edit_mirror.Size = new System.Drawing.Size(258, 22);
            this.btn_menu_edit_mirror.Text = "Mirror";
            this.btn_menu_edit_mirror.Click += new System.EventHandler(this.btn_menu_edit_mirror_Click);
            // 
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
            // scatteredTilesToolStripMenuItem
            // 
            this.scatteredTilesToolStripMenuItem.Name = "scatteredTilesToolStripMenuItem";
            this.scatteredTilesToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.scatteredTilesToolStripMenuItem.Text = "Scattered Tiles";
            this.scatteredTilesToolStripMenuItem.Click += new System.EventHandler(this.scatteredTilesToolStripMenuItem_Click);
            // 
            // pixelateToolStripMenuItem
            // 
            this.pixelateToolStripMenuItem.Name = "pixelateToolStripMenuItem";
            this.pixelateToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.pixelateToolStripMenuItem.Text = "Pixelate";
            this.pixelateToolStripMenuItem.Click += new System.EventHandler(this.pixelateToolStripMenuItem_Click);
            // 
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
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_left_to_right;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_btn_right_to_left;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_swap_left_right;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_filter1;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_CISS;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_pseudocolouring;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_BW;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_contour;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_Skeletization;
        private System.Windows.Forms.ToolStripMenuItem btn_edit_menu_shrinking;
        private System.Windows.Forms.ToolStripMenuItem oilPaintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_drunk_vision;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_edit_mirror;
        private System.Windows.Forms.ToolStripMenuItem scatteredTilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelateToolStripMenuItem;
    }
}

