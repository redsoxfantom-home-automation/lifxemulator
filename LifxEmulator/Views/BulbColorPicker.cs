using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifxEmulator.Views
{
    public partial class BulbColorPicker : Button
    {
        public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs args);
        public event ColorChangedEventHandler ColorChanged;

        public BulbColorPicker()
        {
            InitializeComponent();
            Click += BulbColorPicker_Click;
            BackColor = Color.White;
        }

        private void BulbColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if(d.ShowDialog() == DialogResult.OK)
                {
                    BackColor = d.Color;

                    ColorChanged?.Invoke(this, new ColorChangedEventArgs() { NewColor = d.Color });
                }
            }
        }

        public void SetColor(Color clr)
        {
            BackColor = clr;
        }
    }

    public class ColorChangedEventArgs:EventArgs
    {
        public Color NewColor { get; set; }
    }
}
