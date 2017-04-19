using LifxEmulator.Bulbs;
using LifxEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifxEmulator
{
    public partial class Form1 : Form
    {
        private BulbManager mBulbManager;
        private Logger mLogger;

        public Form1()
        {
            InitializeComponent();

            mLogger = new Logger(mLoggingBox, "Root");
            mBulbSelection.SetLogger(mLogger);

            mLogger.Info("Initializing...");
            mBulbManager = BulbManager.GetInstance(mLogger);
            mBulbSelection.LoadBulbs(mBulbManager.Bulbs);
            mLogger.Info("Initialization complete.");
        }
    }
}
