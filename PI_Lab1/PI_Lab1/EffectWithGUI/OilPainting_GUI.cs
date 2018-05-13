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
    public partial class OilPainting_GUI : Form, EffectWithGUI
    {
        private int color_nr = 255;
        private int brush_width = 1;
        private OilPainting effect = null;

        public OilPainting_GUI()
        {
            InitializeComponent();
            onScrollValueChanged( null, null );
        }

        private void btn_apply_Click( object sender, EventArgs e )
        {
            effect = new OilPainting();
            effect.setParameters( brush_width, color_nr );
            this.Close();
        }

        private void onScrollValueChanged( object sender, EventArgs e )
        {
            color_nr = tb_colors.Value;
            brush_width = tb_bw.Value;

            lbl_brush.Text = brush_width.ToString();
            lbl_nr_colors.Text = color_nr.ToString();
        }

        public IEffect getPreparedEffect()
        {
            return effect;
        }
    }
}
