using LifxEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxEmulator.Bulbs
{
    public class ColorBulb : Bulb
    {
        public override double Hue
        {
            get { return mHue; }
            set
            {
                if(value != mHue)
                {
                    mLogger.Info("Updating Hue to {0}", value);
                    mHue = value;
                    InvokeBulbChanged();
                }
            }
        }
        public override double Saturation
        {
            get { return mSaturation; }
            set
            {
                if(value != mSaturation)
                {
                    mLogger.Info("Updating Saturation to {0}", value);
                    mSaturation = value;
                    InvokeBulbChanged();
                }
            }
        }
        public ColorBulb(Logger logger):base(logger)
        {
            mHue = 0.0;
            mKelvin = 0.0;
            mSaturation = 0.0;
        }
    }
}
