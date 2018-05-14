using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Lab1.Effects;

namespace PI_Lab1.EffectWithGUI
{
    public partial class Pixelate_GUI : Form, EffectWithGUI
    {
        private int pixelSize = 1;
        private Pixelate effect = null;

        public Pixelate_GUI()
        {
            InitializeComponent();
            onScrollValueChanged(null, null);
        }

        public IEffect getPreparedEffect()
        {
            return effect;
        }

        private void onScrollValueChanged(object sender, EventArgs e)
        {
            pixelSize = tb_pixel_size.Value;
            lbl_size.Text = pixelSize.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            effect = new Pixelate();
            effect.setParameters( pixelSize );
            this.Close();
        }
    }
}
