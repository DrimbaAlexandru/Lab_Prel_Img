using PI_Lab1.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Lab1.EffectWithGUI
{
    public partial class Grayscale_GUI : Form, EffectWithGUI
    {
        private Grayscale effect = null;
        private double r = 1, g = 1, b = 1;

        public Grayscale_GUI()
        {
            InitializeComponent();
            onSliderValueChanged( null, null );
        }

        private void btn_apply_Click( object sender, EventArgs e )
        {
            effect = new Grayscale();
            effect.setRGBcoeffs( r, g, b );
            this.Close();
        }

        private void onSliderValueChanged( object sender, EventArgs e )
        {
            int sum = tb_R.Value + tb_G.Value + tb_B.Value;
            r = ( double )tb_R.Value / sum;
            g = ( double )tb_G.Value / sum;
            b = ( double )tb_B.Value / sum;

            lbl_r_val.Text = String.Format( "{0:0.000}", r * 3 );
            lbl_g_val.Text = String.Format( "{0:0.000}", g * 3 );
            lbl_b_val.Text = String.Format( "{0:0.000}", b * 3 );
        }

        public IEffect getPreparedEffect()
        {
            return effect;
        }
    }
}
