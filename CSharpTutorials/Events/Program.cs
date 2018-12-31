using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class NewVersionInfoEventArgs : EventArgs
    {
        public NewVersionInfoEventArgs(string versionNumber)
        {
            VersionNumber = versionNumber;
        }

        public string VersionNumber { get; set; }
    }

    public class MobileApp
    {
        public event EventHandler<EventArgs> UpdatedVersionAvailable;

        protected virtual void OnUpdatedVersionAvailable(EventArgs e)
        {
            EventHandler<EventArgs> eventObj = Volatile.Read(ref UpdatedVersionAvailable);
            if (eventObj != null)
            {
                eventObj(this, e);
            }
        }

        public void DeployedNewVersion()
        {
            OnUpdatedVersionAvailable(EventArgs.Empty);
        }
    }

    public class MobileAppCustom
    {
        public event EventHandler<NewVersionInfoEventArgs> UpdatedVersionAvailable;

        protected virtual void OnUpdatedVersionAvailable(NewVersionInfoEventArgs e)
        {
            EventHandler<NewVersionInfoEventArgs> eventObj = Volatile.Read(ref UpdatedVersionAvailable);
            if (eventObj != null)
            {
                eventObj(this, e);
            }
        }

        public void DeployedNewVersion(string versionNumber)
        {
            OnUpdatedVersionAvailable(new NewVersionInfoEventArgs(versionNumber));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MobileApp app = new MobileApp();
            app.UpdatedVersionAvailable += App_UpdatedVersionAvailable;

            app.DeployedNewVersion();

            //Using custom EventArgs
            MobileAppCustom cust = new MobileAppCustom();
            cust.UpdatedVersionAvailable += Cust_UpdatedVersionAvailable;

            cust.DeployedNewVersion("1.2.3.4");

            Console.Read();
        }

        private static void Cust_UpdatedVersionAvailable(object sender, NewVersionInfoEventArgs e)
        {
            Console.WriteLine("New update available. Version " + e.VersionNumber);
        }

        private static void App_UpdatedVersionAvailable(object sender, EventArgs e)
        {
            Console.WriteLine("New update of a mobile app is available");
        }
    }
}
