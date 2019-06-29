using DuetDiscordNotification.Config;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace DuetDiscordNotification
{
    public partial class DuetDiscordConfigForm : Form
    {
        private const string AppName = "DuetDiscordNotification";
        private readonly Configuration _config;
        private Printer _selectedPrinter = null;
        private Printer SelectedPrinter
        {
            get { return _selectedPrinter; }
            set
            {
                _selectedPrinter = value;
                UpdatePrinterArea();
            }
        }

        public DuetDiscordConfigForm()
        {
            InitializeComponent();
            _config = Configuration.Load();
            printerPollingTimer.Start();
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
            }
        }

        private void DuetDiscordConfigForm_Load(object sender, System.EventArgs e)
        {
            HideForm();
            UpdateList();
        }

        private void DuetDiscordConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideForm();
        }

        private void HideForm()
        {
            BeginInvoke(new MethodInvoker(Hide));
        }

        private void KillApp()
        {
            notifyIcon1.Dispose();
            Environment.Exit(0);

        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillApp();
        }

        private void showFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }


        private void UpdateList()
        {
            lstPrinters.Items.Clear();
            foreach (var printer in _config.Printers)
            {
                var item = new ListViewItem
                {
                    Text = printer.Name,
                    Tag = printer
                };
                lstPrinters.Items.Add(item);
            }
        }

        private void lstPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPrinter = lstPrinters.FocusedItem?.Tag as Printer;
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            SelectedPrinter = _config.NewPrinter();
            UpdateList();
        }

        private void btnRemovePrinter_Click(object sender, EventArgs e)
        {
            if (SelectedPrinter == null)
            {
                return;
            }

            _config.DeletePrinter(SelectedPrinter);
            SelectedPrinter = null;
            gbPrinterSettings.Enabled = false;
            UpdateList();
            _config.Save();
        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            SelectedPrinter.Name = txtPrinterName.Text;
            SelectedPrinter.IPAddress = txtPrinterAddress.Text;
            SelectedPrinter.Active = chkActive.Checked;
            SelectedPrinter.Webhook = txtWebhook.Text;
            _config.Save();
        }

        public void UpdatePrinterArea()
        {
            txtPrinterName.Text = SelectedPrinter?.Name ?? string.Empty;
            txtPrinterAddress.Text = SelectedPrinter?.IPAddress ?? string.Empty;
            chkActive.Checked = SelectedPrinter?.Active ?? false;
            txtWebhook.Text = SelectedPrinter?.Webhook ?? string.Empty;
            gbPrinterSettings.Enabled = true;
        }

        private void printerPollingTimer_Tick(object sender, EventArgs e)
        {
            foreach (var printer in _config.Printers)
            {
                printer.UpdatePrinterStatus(_config.DiscordConfig);
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KillApp();
        }

        private void addToStartupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue(AppName, Application.ExecutablePath);
        }

        private void removeFromStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.DeleteValue(AppName, false);

        }
    }
}
