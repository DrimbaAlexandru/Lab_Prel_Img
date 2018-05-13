using PI_Lab1.Effects;
using PI_Lab1.EffectWithGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Lab1
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
                    refresh_left();
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

        private void btn_edit_grayscale_Click( object sender, EventArgs e )
        {
            Grayscale_GUI gui = new Grayscale_GUI();
            gui.ShowDialog();
            apply_effect( gui.getPreparedEffect() );
        }

        private void refresh_left()
        {
            pictureBox_left.Image = left_image;
            pictureBox_left.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_left.Refresh();
        }

        private void refresh_right()
        {
            pictureBox_right.Image = right_image;
            pictureBox_right.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_right.Refresh();
        }

        private void copy_A_to_B()
        {
            if( left_image == null )
            {
                throw new ImageProcessingException( "Left image is uninitialized" );
            }
            right_image = ( Bitmap )left_image.Clone();
        }

        private void copy_B_to_A()
        {
            if( right_image == null )
            {
                throw new ImageProcessingException( "Right image is uninitialized" );
            }
            left_image = ( Bitmap )right_image.Clone();
        }

        private void swap_A_with_B()
        {
            Bitmap aux = left_image;
            left_image = right_image;
            right_image = aux;
        }

        private void apply_effect( IEffect effect )
        {
            if( effect == null )
                return;
            try
            {
                if( right_image == null )
                {
                    throw new ImageProcessingException( "No image was selected" );
                }
                effect.apply( right_image );
                refresh_right();
            }
            catch( Exception e )
            {
                MessageBox.Show( e.Message );
            }
        }

        private void btn_menu_edit_contrast_compression_Click( object sender, EventArgs e )
        {
            apply_effect( new ContrastCompression() );
        }



        private void btn_menu_edit_imageSubstract_Click( object sender, EventArgs e )
        {
            ImageSubstraction eff = new ImageSubstraction();
            eff.set_operand_b( left_image );
            eff.set_threshold( 10 );
            apply_effect( eff );
        }

        private void btn_menu_edit_left_to_right_Click( object sender, EventArgs e )
        {
            try
            {
                copy_A_to_B();
                refresh_right();
            }
            catch( Exception exc )
            {
                MessageBox.Show( exc.Message );
            }
        }

        private void btn_menu_edit_btn_right_to_left_Click( object sender, EventArgs e )
        {
            try
            {
                copy_B_to_A();
                refresh_left();
            }
            catch( Exception exc )
            {
                MessageBox.Show( exc.Message );
            }
        }

        private void btn_menu_edit_swap_left_right_Click( object sender, EventArgs e )
        {
            try
            {
                swap_A_with_B();
                refresh_left();
                refresh_right();
            }
            catch( Exception exc )
            {
                MessageBox.Show( exc.Message );
            }
        }

        private void btn_menu_edit_filter1_Click( object sender, EventArgs e )
        {
            int h = 1, v = 1;
            DirectionalFilter filter = new DirectionalFilter();
            filter.set_coeffs( v, h );
            apply_effect( filter );
        }

        private void btn_edit_menu_CISS_Click( object sender, EventArgs e )
        {
            int h = 1, v = 1;
            InvContScalStat ICSS = new InvContScalStat();
            ICSS.set_coeffs( v, h );
            apply_effect( ICSS );
        }

        private void btn_edit_menu_pseudocolouring_Click( object sender, EventArgs e )
        {
            Pseudocolor pc = new Pseudocolor();
            apply_effect( pc );
        }

        private void btn_edit_menu_BW_Click( object sender, EventArgs e )
        {
            BlackWhite bw = new BlackWhite();
            apply_effect( bw );
        }

        private void btn_edit_menu_contour_Click( object sender, EventArgs e )
        {
            Contour contour = new Contour();
            apply_effect( contour );
        }

        private void btn_edit_menu_Skeletization_Click( object sender, EventArgs e )
        {
            Skeletonize skeletization = new Skeletonize();
            apply_effect( skeletization );
        }

        private void btn_edit_menu_shrinking_Click( object sender, EventArgs e )
        {
            Thin shrink = new Thin();
            apply_effect( shrink );
        }

        private void btn_edit_menu_oilPainting_click( object sender, EventArgs e )
        {
            OilPainting_GUI op = new OilPainting_GUI();
            op.ShowDialog();
            apply_effect( op.getPreparedEffect() );
        }
    }
}
