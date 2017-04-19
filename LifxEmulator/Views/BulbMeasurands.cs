using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifxEmulator.Bulbs;
using LifxEmulator.Utilities;

namespace LifxEmulator.Views
{
    public partial class BulbMeasurands : UserControl
    {
        private TextBox mLabelBox;
        private CheckBox mPowerBox;
        private NumericUpDown mUniqueIdBox;
        private TrackBar mBrightnessBar;
        private BulbColorPicker mColorPicker;
        private TrackBar mKelvinBar;
        private Bulb mTrackedBulb;
        private Logger mLogger;

        public BulbMeasurands(Logger logger)
        {
            InitializeComponent();
            mLogger = logger.CreateChild("BulbMeasurandUI");
        }

        public void PopulateFromBulb(Bulb b)
        {
            mTrackedBulb = b;
            mTrackedBulb.BulbChanged += (newBulb) => {
                mTrackedBulb = newBulb;
                PopulateFromTrackedBulb();
            };

            Label mLabellbl = new Label();
            mLabellbl.Text = "Label:";
            mLabelBox = new TextBox();
            mLabelBox.Text = b.Label;
            mLabelBox.TextChanged += MLabelBox_TextChanged;
            AddLabelAndMeasurand(mLabellbl, mLabelBox);
            
            Label mPowerLbl = new Label();
            mPowerLbl.Text = "Power:";
            mPowerBox = new CheckBox();
            mPowerBox.CheckedChanged += MPowerBox_CheckedChanged;
            AddLabelAndMeasurand(mPowerLbl, mPowerBox);

            Label mUniqueIdLbl = new Label();
            mUniqueIdLbl.Text = "Unique Id:";
            mUniqueIdBox = new NumericUpDown();
            mUniqueIdBox.ValueChanged += MUniqueIdBox_ValueChanged;
            mUniqueIdBox.Maximum = int.MaxValue;
            AddLabelAndMeasurand(mUniqueIdLbl, mUniqueIdBox);

            if(b.GetType() == typeof(ColorBulb))
            {
                Label mColorPickerLbl = new Label();
                mColorPickerLbl.Text = "Color:";
                mColorPicker = new BulbColorPicker();
                mColorPicker.ColorChanged += MColorPicker_ColorChanged;
                AddLabelAndMeasurand(mColorPickerLbl, mColorPicker);
            }
            else
            {
                Label mBrightnessLbl = new Label();
                mBrightnessLbl.Text = "Brightness:";
                mBrightnessBar = new TrackBar();
                mBrightnessBar.Minimum = 0;
                mBrightnessBar.Maximum = 100;
                mBrightnessBar.ValueChanged += MBrightnessBar_ValueChanged;
                AddLabelAndMeasurand(mBrightnessLbl, mBrightnessBar);
            }

            Label mKelvinLabel = new Label();
            mKelvinLabel.Text = "Kelvin:";
            mKelvinBar = new TrackBar();
            mKelvinBar.Minimum = 0;
            mKelvinBar.Maximum = 100;
            mKelvinBar.ValueChanged += MKelvinBar_ValueChanged;
            AddLabelAndMeasurand(mKelvinLabel, mKelvinBar);

            PopulateFromTrackedBulb();
        }

        private void MKelvinBar_ValueChanged(object sender, EventArgs e)
        {
            mTrackedBulb.Kelvin = (double)mKelvinBar.Value / 100.0;
        }

        private void MColorPicker_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            ColorBulb b = (ColorBulb)mTrackedBulb;
            b.Hue = args.NewColor.GetHue();
            b.Saturation = args.NewColor.GetSaturation();
            b.Brightness = args.NewColor.GetBrightness();
        }

        private void MBrightnessBar_ValueChanged(object sender, EventArgs e)
        {
            mTrackedBulb.Brightness = (double)mBrightnessBar.Value / 100.0;
        }

        private void MUniqueIdBox_ValueChanged(object sender, EventArgs e)
        {
            mTrackedBulb.UniqueId = (int)mUniqueIdBox.Value;
        }
        
        private void MPowerBox_CheckedChanged(object sender, EventArgs e)
        {
            mTrackedBulb.Power = mPowerBox.Checked;
        }

        private void MLabelBox_TextChanged(object sender, EventArgs e)
        {
            mTrackedBulb.Label = mLabelBox.Text;
        }

        private void PopulateFromTrackedBulb()
        {
            mLabelBox.Text = mTrackedBulb.Label;
            mPowerBox.Checked = mTrackedBulb.Power;
            mUniqueIdBox.Value = mTrackedBulb.UniqueId;
            if(mTrackedBulb.GetType() == typeof(ColorBulb))
            {
                Color clr = new Color();
                // TODO: implement HSB -> RGB conversion
                mColorPicker.SetColor(clr);
            }
            else
            {
                mBrightnessBar.Value = (int)(mTrackedBulb.Brightness * 100);
            }
            mKelvinBar.Value = (int)(mTrackedBulb.Brightness * 100);
        }

        private void AddLabelAndMeasurand(Label label, Control measurand)
        {
            label.TextAlign = ContentAlignment.MiddleRight;
            measurand.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;

            mMeasurandsTable.RowCount++;
            mMeasurandsTable.Controls.Add(label, 0, mMeasurandsTable.RowCount);
            mMeasurandsTable.Controls.Add(measurand, 1, mMeasurandsTable.RowCount);
            mMeasurandsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }
    }
}
