using System.Collections;

namespace Hard_Drive_Info
{
    public abstract class DriveInformation
    {
        protected ArrayList drives = new ArrayList();
        protected ArrayList messages = new ArrayList();

        public ArrayList Drives
        {
            get { return drives; }
        }

        public ArrayList Messages
        {
            get { return messages; }
        }

        public DriveInformation()
        {
            Refresh();
        }

        public abstract void Refresh();
    }
}
