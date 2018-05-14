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
    public partial class ScatteredTiles_GUI : Form, EffectWithGUI
    {
        private int tileSize = 2;
        private int scatterAmount = 5;
        private ScatteredTiles effect = null;

        public ScatteredTiles_GUI()
        {
            InitializeComponent();
            onScrollValueChanged(null, null);
        }

        private void onScrollValueChanged(object sender, EventArgs e)
        {
            tileSize = trackBar1.Value;
            scatterAmount = trackBar2.Value;
        }

        public IEffect getPreparedEffect()
        {
            return effect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            effect = new ScatteredTiles();
            effect.setParameters(tileSize, scatterAmount);
            this.Close();
        }
    }
}
