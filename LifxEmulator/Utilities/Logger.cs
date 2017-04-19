using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifxEmulator.Utilities
{
    public class Logger
    {
        private const string LOG_FORMAT = "{0,-5} [{1}]: {2}\r\n";

        private TextBox mTargetBox;
        private String mName;

        public Logger(TextBox targetBox, String name)
        {
            mTargetBox = targetBox;
            mName = name;
        }

        private void createLog(string logLevel, string msg)
        {
            string logMsg = string.Format(LOG_FORMAT, logLevel, mName, msg);
            lock(mTargetBox)
            {
                if (mTargetBox.Text.Length == 0)
                {
                    mTargetBox.Text = logMsg;
                }
                else
                {
                    mTargetBox.AppendText(logMsg);
                }
            }
        }

        public void Info(string log, params object[] parms)
        {
            string msg = string.Format(log, parms);
            createLog("INFO", msg);
        }

        public void Debug(string log, params object[] parms)
        {
            string msg = string.Format(log, parms);
            createLog("DEBUG", msg);
        }
        public void Warn(string log, params object[] parms)
        {
            string msg = string.Format(log, parms);
            createLog("WARN", msg);
        }

        public void Error(string log, params object[] parms)
        {
            string msg = string.Format(log, parms);
            createLog("ERROR", msg);
        }

        public Logger CreateChild(string Name)
        {
            Logger l = new Logger(mTargetBox, mName + "." + Name);
            return l;
        }
    }
}
