using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManagmentTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\control.exe");
        }

        private void notepad_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal currentPrincipal = new WindowsPrincipal(currentIdentity);

            if (currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                System.Diagnostics.Process.Start(@"C:\Windows\regedit.exe");
            }
            else
            {
                MessageBox.Show("I am sorry, but you don't have the permissions to do this. Did you try running as Administrator?");
            }
        }

        private void fexp_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\explorer.exe");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal currentPrincipal = new WindowsPrincipal(currentIdentity);

            if (currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
            }
            else
            {
                MessageBox.Show("I am sorry, but you don't have the permissions to do this. Did you try running as Administrator?");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe");
        }

        private void appwiz_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\appwiz.cpl") { UseShellExecute = true });
        }

        private void datetime_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\timedate.cpl") { UseShellExecute = true });
        }

        private void devmgmt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\hdwwiz.cpl") { UseShellExecute = true });
        }

        private void display_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\desk.cpl") { UseShellExecute = true });
        }

        private void firewall_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\firewall.cpl") { UseShellExecute = true });
        }

        private void internetO_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\inetcpl.cpl") { UseShellExecute = true });
        }

        private void gamecontrollers_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\joy.cpl") { UseShellExecute = true });
        }

        private void mousesettings_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\main.cpl") { UseShellExecute = true });
        }

        private void network_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\ncpa.cpl") { UseShellExecute = true });
        }

        private void powercfg_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\powercfg.cpl") { UseShellExecute = true });
        }

        private void regionO_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\intl.cpl") { UseShellExecute = true });
        }

        private void soundSettings_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\mmsys.cpl") { UseShellExecute = true });
        }

        private void sys_set_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\sysdm.cpl") { UseShellExecute = true });
        }

        private void bluetooth_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\bthprops.cpl") { UseShellExecute = true });
        }

        private void security_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\wscui.cpl") { UseShellExecute = true });
        }

        private void locationIn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\telephon.cpl") { UseShellExecute = true });
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(@"C:\Windows\System32\gpedit.msc") { UseShellExecute = true });
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your computer will be shut down in 10 seconds.");
            Process.Start("shutdown", "/s /t 10");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your computer will be restarted in 10 seconds.");
            Process.Start("shutdown", "/r /t 10");
        }
    }
}
