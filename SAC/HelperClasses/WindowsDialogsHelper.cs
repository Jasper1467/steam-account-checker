using System;
using System.Windows.Forms;

namespace SAC.HelperClasses
{
    internal class WindowsDialogsHelper
    {
        public static void FindPlaceToExport()
        {
            try
            {
                var folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
                SteamAccountHelper.localToExport = folderBrowserDialog.SelectedPath;
                Program.mw.textBoxLocalToExport.Text = SteamAccountHelper.localToExport;
                //TODO: Change this, so instead of showing this message, it automatically exports without requiring user intervention
                MessageBox.Show(@"You've successfully set the place to export accounts from.

Click the button again to export your selected accounts.", @"Path is now set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Failed. Error: {ex.Message}", @"Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
