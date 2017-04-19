using LifxEmulator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxEmulator.Bulbs
{
    public class Bulb
    {
        protected string mLabel;
        protected int mUniqueId;
        protected bool mPower;
        protected double mBrightness, mHue, mKelvin, mSaturation;
        protected Logger mLogger;

        public delegate void BulbChangedEventHandler(Bulb changedBulb);
        public event BulbChangedEventHandler BulbChanged;

        public string ProductName { get; set; }
        public string Label
        {
            get { return mLabel; }
            set
            {
                if(value != mLabel)
                {
                    mLogger.Info("Updating Label to {0}", value);
                    mLabel = value;
                    InvokeBulbChanged();
                }
            }
        }
        public int ProductId { get; set; }
        public int UniqueId
        {
            get { return mUniqueId; }
            set
            {
                if(value != mUniqueId)
                {
                    mLogger.Info("Updating UniqueId to {0}", value);
                    mUniqueId = value;
                    InvokeBulbChanged();
                }
            }
        }
        public bool Power
        {
            get { return mPower; }
            set
            {
                if(value != mPower)
                {
                    mLogger.Info("Updating Power to {0}", value? "ON":"OFF");
                    mPower = value;
                    InvokeBulbChanged();
                }
            }
        }
        public double Brightness
        {
            get { return mBrightness; }
            set
            {
                if(value != mBrightness)
                {
                    mLogger.Info("Updating Brightness to {0}", value);
                    mBrightness = value;
                    InvokeBulbChanged();
                }
            }
        }
        public double Kelvin
        {
            get { return mKelvin; }
            set
            {
                if(value != mKelvin)
                {
                    mLogger.Info("Updating Kelvin to {0}", value);
                    mKelvin = value;
                    InvokeBulbChanged();
                }
            }
        }
        public virtual double Hue
        {
            get
            {
                return mHue;
            }
            set
            {
                throw new InvalidOperationException("Black and White bulbs cannot change Hue");
            }
        }
        public virtual double Saturation
        {
            get
            {
                return mSaturation;
            }
            set
            {
                throw new InvalidOperationException("Black and White bulbs cannot change Saturation");
            }
        }

        public Bulb(Logger logger)
        {
            mLogger = logger.CreateChild("Bulb");
            mPower = false;
            mBrightness = 0.0;
            mHue = 1.0;
            mSaturation = 1.0;
        }

        public override string ToString()
        {
            return string.Format("{0}",ProductName);
        }

        protected void InvokeBulbChanged()
        {
            BulbChanged?.Invoke(this);
        }
    }
}
