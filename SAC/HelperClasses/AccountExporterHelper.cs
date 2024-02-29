using System;
using System.IO;
using System.Windows.Forms;

namespace SAC.HelperClasses
{
    internal class AccountExporterHelper
    {
        public enum WhatToExport
        {
            GOODACCOUNTS,
            BADCCOUNTS,
            SGPROTECTEDACCOUNTS
        }

        public static void Export(WhatToExport whatToExport)
        {
            if (SteamAccountHelper.localToExport != string.Empty)
            {
                try
                {
                    switch (whatToExport)
                    {
                        case WhatToExport.GOODACCOUNTS:
                            var goodAccounts = string.Join("", SteamAccountHelper.GoodAccountsList.ToArray());
                            var streamWriterGoodAccounts = new StreamWriter($"{SteamAccountHelper.localToExport}\\Good Accounts.txt");

                            streamWriterGoodAccounts.WriteLine(goodAccounts);
                            streamWriterGoodAccounts.Close();
                            break;

                        case WhatToExport.BADCCOUNTS:
                            var badAccounts = string.Join("", SteamAccountHelper.badAccountsList.ToArray());
                            var streamWriterBadAccounts = new StreamWriter($"{SteamAccountHelper.localToExport}\\Bad Accounts.txt");

                            streamWriterBadAccounts.WriteLine(badAccounts);
                            streamWriterBadAccounts.Close();
                            break;

                        case WhatToExport.SGPROTECTEDACCOUNTS:
                            var sGProtectedAccounts = string.Join("", SteamAccountHelper.sGProtectedAccountsList.ToArray());
                            var streamWriterSGAccounts = new StreamWriter($"{SteamAccountHelper.localToExport}\\SteamGuard protected Accounts.txt");

                            streamWriterSGAccounts.WriteLine(sGProtectedAccounts);
                            streamWriterSGAccounts.Close();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(whatToExport), whatToExport, null);
                    }
                    MessageBox.Show(@"Done!", @"SAS.exe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Couldn't write. Error: {ex.Message}", @"SAS.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                WindowsDialogsHelper.FindPlaceToExport();
            }
        }
    }
}