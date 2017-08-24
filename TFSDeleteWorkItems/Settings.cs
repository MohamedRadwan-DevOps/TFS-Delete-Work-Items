using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TFSDeleteWorkItems
{
    class Settings
    {
        internal static bool EnabledConfirmationForBulkDelete = true;
        internal static bool EnabledConfirmationForSinglekDelete = false;
        public static void LoadSettings()
        {
            string enabledConfirmationForBulkDeleteValue = "true";
            string enabledConfirmationForSinglekDeleteValue = "false";
            XDocument root = null;

            try
            {
                root = XDocument.Load("TFSDeleteWorkItems.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(Utilities.ReadException(e) , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XElement settings = root.Element("Settings");
            if (settings != null)
            {
                XElement enabledConfirmationForBulkDeleteString = settings.Element("EnabledConfirmationForBulkDelete");
                if (enabledConfirmationForBulkDeleteString != null)
                {
                    enabledConfirmationForBulkDeleteValue = enabledConfirmationForBulkDeleteString.Value;
                }
                XElement enabledConfirmationForSinglekDeleteString = settings.Element("EnabledConfirmationForSinglekDelete");
                if (enabledConfirmationForSinglekDeleteString != null)
                {
                    enabledConfirmationForSinglekDeleteValue = enabledConfirmationForSinglekDeleteString.Value;
                }
            }
            EnabledConfirmationForBulkDelete = bool.Parse(enabledConfirmationForBulkDeleteValue);
            EnabledConfirmationForSinglekDelete = bool.Parse(enabledConfirmationForSinglekDeleteValue);
        }

        public static void SaveSettings(bool enableBulkConfirm, bool enableSingleConfirm)
        {
            XDocument root = null;
            try
            {
                root = XDocument.Load("TFSDeleteWorkItems.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(Utilities.ReadException(e), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XElement settings = root.Element("Settings");
            if (settings != null)
            {
                XElement enabledConfirmationForBulkDeleteString = settings.Element("EnabledConfirmationForBulkDelete");
                if (enabledConfirmationForBulkDeleteString != null)
                {
                    settings.Element("EnabledConfirmationForBulkDelete").SetValue(enableBulkConfirm.ToString()); 
                }
                XElement enabledConfirmationForSinglekDeleteString = settings.Element("EnabledConfirmationForSinglekDelete");
                if (enabledConfirmationForSinglekDeleteString != null)
                {
                    settings.Element("EnabledConfirmationForSinglekDelete").SetValue(enableSingleConfirm.ToString());
                }
                
            }
            try
            {
                root.Save("TFSDeleteWorkItems.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(Utilities.ReadException(e)+Environment.NewLine+" Try to run the tool as Administrator","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
