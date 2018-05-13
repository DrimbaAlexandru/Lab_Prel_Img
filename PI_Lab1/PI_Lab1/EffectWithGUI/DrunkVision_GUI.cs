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
    public partial class DrunkVision_GUI : Form, EffectWithGUI
    {
        private int drunkenness = 0, eyes = 1;
        private DrunkVision effect = null;

        public DrunkVision_GUI()
        {
            InitializeComponent();
            onSliderValueChanged( null, null );
        }

        private void btn_apply_Click( object sender, EventArgs e )
        {
            effect = new DrunkVision();
            effect.setParameters( eyes, drunkenness );
            this.Close();
        }

        public Effects.IEffect getPreparedEffect()
        {
            return effect;
        }

        private void onSliderValueChanged( object sender, EventArgs e )
        {
            drunkenness = tb_drunk.Value;
            eyes = tb_eyes.Value;

            lbl_drunkenness.Text = drunkenness.ToString();
            lbl_nr_eyes.Text = eyes.ToString();
        }
    }
}
