using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aleimg
{
    public partial class Form1 : Form
    {
        Bitmap left_image = null;
        Bitmap right_image = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void menu_file_load_Click( object sender, EventArgs e )
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if( file.ShowDialog() == DialogResult.OK )
            {
                path = file.FileName;
                try
                {
                    left_image = ( Bitmap )Bitmap.FromFile( path );
                    right_image = ( Bitmap )left_image.Clone();
                    refresh_left();
                    refresh_right();
                }
                catch( Exception exc )
                {
                    MessageBox.Show( exc.Message );
                }
            }
        }

        private void menu_file_save_Click( object sender, EventArgs e )
        {
            if( right_image == null )
            {
                MessageBox.Show( "No image was selected" );
            }
            else
            {
                string path;
                SaveFileDialog file = new SaveFileDialog();
                file.AddExtension = true;
                file.DefaultExt = "bmp";
                if( file.ShowDialog() == DialogResult.OK )
                {
                    path = file.FileName;
                    try
                    {
                        right_image.Save( path, System.Drawing.Imaging.ImageFormat.Bmp );
                    }
                    catch( Exception exc )
                    {
                        MessageBox.Show( exc.Message );
                    }
                }
            }
        }

        private void btn_edit_some_effect_Click( object sender, EventArgs e )
        {
            if( right_image == null )
            {
                MessageBox.Show( "No image was selected" );
                return;
            }
            int i, j;
            for( i = 0; i < right_image.Width; i++ )
            {
                for( j = 0; j < right_image.Height; j++ )
                {
                    if( right_image.GetPixel( i, j ).R > 150 )
                        right_image.SetPixel( i, j, Color.White );
                    else
                        right_image.SetPixel( i, j, Color.Black );
                }
            }
            refresh_right();
        }

        private void refresh_left()
        {
            pictureBox1.Image = left_image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Refresh();
        }

        private void refresh_right()
        {
            pictureBox2.Image = right_image;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Refresh();
        }
    }
}
