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
    public partial class BulbSelection : UserControl
    {
        private Dictionary<Bulb, BulbMeasurands> LoadedMeasurands;
        private BulbMeasurands SelectedBulbMeasurands = null;
        private Logger mLogger;

        public BulbSelection()
        {
            InitializeComponent();
            LoadedMeasurands = new Dictionary<Bulb, BulbMeasurands>();
        }

        public void SetLogger(Logger logger)
        {
            mLogger = logger.CreateChild("BulbSelectionUI");
        }

        public void LoadBulbs(List<Bulb> bulbs)
        {
            foreach(var bulb in bulbs)
            {
                mBulbComboBox.Items.Add(bulb);

                BulbMeasurands measurands = new BulbMeasurands(mLogger);
                measurands.PopulateFromBulb(bulb);
                LoadedMeasurands.Add(bulb, measurands);
            }
        }

        private void mBulbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bulb selectedBulb = (Bulb)mBulbComboBox.SelectedItem;
            mLogger.Info("New Active Bulb: {0} ({1})", selectedBulb, selectedBulb.Label);
            mBulbMeasurandsBox.Text = string.Format("{0} Measurands", selectedBulb.ProductName);
            
            if(SelectedBulbMeasurands != null)
            {
                mSelectedBulbMeasurandsPanel.Controls.Remove(SelectedBulbMeasurands);
            }
            SelectedBulbMeasurands = LoadedMeasurands[selectedBulb];
            mSelectedBulbMeasurandsPanel.Controls.Add(SelectedBulbMeasurands);
        }
    }
}
