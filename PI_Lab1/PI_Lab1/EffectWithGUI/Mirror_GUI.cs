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
    public partial class Mirror_GUI : Form, EffectWithGUI
    {
        private Mirror effect = null;
        private double x_rp = 0, y_rp = 0, angle = 0;


        public Mirror_GUI()
        {
            InitializeComponent();
            onSliderValueChanged( null, null );
        }

        private void onSliderValueChanged( object sender, EventArgs e )
        {
            x_rp = 1.0 * tb_x_pos.Value / 100;
            y_rp = 1.0 * tb_y_pos.Value / 100;
            angle = 1.0 * tb_angle.Value / 360 * 2 * Math.PI;

            lbl_angle.Text = tb_angle.Value.ToString() + "\u00b0";
            lbl_x_pos.Text = String.Format( "{0:0.00}", x_rp );
            lbl_y_pos.Text = String.Format( "{0:0.00}", y_rp );
        }

        private void btn_apply_Click( object sender, EventArgs e )
        {
            effect = new Mirror();
            effect.setParameters( x_rp, y_rp, angle );
            this.Close();
        }

        public Effects.IEffect getPreparedEffect()
        {
            return effect;
        }
    }
}
