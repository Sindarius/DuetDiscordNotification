namespace DuetDiscordNotification
{
    partial class DuetDiscordConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuetDiscordConfigForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lstPrinters = new System.Windows.Forms.ListView();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnRemovePrinter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrinterSettings = new System.Windows.Forms.GroupBox();
            this.txtWebhook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSavePrinter = new System.Windows.Forms.Button();
            this.txtPrinterAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.printerPollingTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToStartupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.gbPrinterSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.menuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Duet Discord Notification";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(135, 48);
            this.menuStrip.Text = "File";
            // 
            // showFormToolStripMenuItem
            // 
            this.showFormToolStripMenuItem.Name = "showFormToolStripMenuItem";
            this.showFormToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.showFormToolStripMenuItem.Text = "Show Form";
            this.showFormToolStripMenuItem.Click += new System.EventHandler(this.showFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lstPrinters
            // 
            this.lstPrinters.Location = new System.Drawing.Point(15, 46);
            this.lstPrinters.Name = "lstPrinters";
            this.lstPrinters.Size = new System.Drawing.Size(121, 156);
            this.lstPrinters.TabIndex = 2;
            this.lstPrinters.UseCompatibleStateImageBehavior = false;
            this.lstPrinters.View = System.Windows.Forms.View.List;
            this.lstPrinters.SelectedIndexChanged += new System.EventHandler(this.lstPrinters_SelectedIndexChanged);
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Location = new System.Drawing.Point(66, 208);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(32, 23);
            this.btnAddPrinter.TabIndex = 3;
            this.btnAddPrinter.Text = "+";
            this.btnAddPrinter.UseVisualStyleBackColor = true;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // btnRemovePrinter
            // 
            this.btnRemovePrinter.Location = new System.Drawing.Point(104, 208);
            this.btnRemovePrinter.Name = "btnRemovePrinter";
            this.btnRemovePrinter.Size = new System.Drawing.Size(32, 23);
            this.btnRemovePrinter.TabIndex = 4;
            this.btnRemovePrinter.Text = "-";
            this.btnRemovePrinter.UseVisualStyleBackColor = true;
            this.btnRemovePrinter.Click += new System.EventHandler(this.btnRemovePrinter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Printers";
            // 
            // gbPrinterSettings
            // 
            this.gbPrinterSettings.Controls.Add(this.txtWebhook);
            this.gbPrinterSettings.Controls.Add(this.label6);
            this.gbPrinterSettings.Controls.Add(this.label5);
            this.gbPrinterSettings.Controls.Add(this.chkActive);
            this.gbPrinterSettings.Controls.Add(this.btnSavePrinter);
            this.gbPrinterSettings.Controls.Add(this.txtPrinterAddress);
            this.gbPrinterSettings.Controls.Add(this.label4);
            this.gbPrinterSettings.Controls.Add(this.label3);
            this.gbPrinterSettings.Controls.Add(this.txtPrinterName);
            this.gbPrinterSettings.Enabled = false;
            this.gbPrinterSettings.Location = new System.Drawing.Point(142, 30);
            this.gbPrinterSettings.Name = "gbPrinterSettings";
            this.gbPrinterSettings.Size = new System.Drawing.Size(288, 201);
            this.gbPrinterSettings.TabIndex = 6;
            this.gbPrinterSettings.TabStop = false;
            this.gbPrinterSettings.Text = "Printer Settings";
            // 
            // txtWebhook
            // 
            this.txtWebhook.Location = new System.Drawing.Point(62, 90);
            this.txtWebhook.Name = "txtWebhook";
            this.txtWebhook.Size = new System.Drawing.Size(220, 20);
            this.txtWebhook.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Webhook";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Active";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(62, 118);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 5;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSavePrinter
            // 
            this.btnSavePrinter.Location = new System.Drawing.Point(206, 172);
            this.btnSavePrinter.Name = "btnSavePrinter";
            this.btnSavePrinter.Size = new System.Drawing.Size(75, 23);
            this.btnSavePrinter.TabIndex = 4;
            this.btnSavePrinter.Text = "Save";
            this.btnSavePrinter.UseVisualStyleBackColor = true;
            this.btnSavePrinter.Click += new System.EventHandler(this.btnSavePrinter_Click);
            // 
            // txtPrinterAddress
            // 
            this.txtPrinterAddress.Location = new System.Drawing.Point(61, 64);
            this.txtPrinterAddress.Name = "txtPrinterAddress";
            this.txtPrinterAddress.Size = new System.Drawing.Size(220, 20);
            this.txtPrinterAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(62, 38);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(220, 20);
            this.txtPrinterName.TabIndex = 0;
            // 
            // printerPollingTimer
            // 
            this.printerPollingTimer.Interval = 30000;
            this.printerPollingTimer.Tick += new System.EventHandler(this.printerPollingTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStartupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToStartupToolStripMenuItem
            // 
            this.addToStartupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStartupToolStripMenuItem1,
            this.removeFromStartupToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.addToStartupToolStripMenuItem.Name = "addToStartupToolStripMenuItem";
            this.addToStartupToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.addToStartupToolStripMenuItem.Text = "File";
            // 
            // addToStartupToolStripMenuItem1
            // 
            this.addToStartupToolStripMenuItem1.Name = "addToStartupToolStripMenuItem1";
            this.addToStartupToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.addToStartupToolStripMenuItem1.Text = "Add To Startup";
            this.addToStartupToolStripMenuItem1.Click += new System.EventHandler(this.addToStartupToolStripMenuItem1_Click);
            // 
            // removeFromStartupToolStripMenuItem
            // 
            this.removeFromStartupToolStripMenuItem.Name = "removeFromStartupToolStripMenuItem";
            this.removeFromStartupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeFromStartupToolStripMenuItem.Text = "Remove From Startup";
            this.removeFromStartupToolStripMenuItem.Click += new System.EventHandler(this.removeFromStartupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // DuetDiscordConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 237);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbPrinterSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemovePrinter);
            this.Controls.Add(this.btnAddPrinter);
            this.Controls.Add(this.lstPrinters);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DuetDiscordConfigForm";
            this.Text = "Duet Discord Notification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuetDiscordConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.DuetDiscordConfigForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.gbPrinterSettings.ResumeLayout(false);
            this.gbPrinterSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFormToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ListView lstPrinters;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnRemovePrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPrinterSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.TextBox txtPrinterAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSavePrinter;
        private System.Windows.Forms.Timer printerPollingTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtWebhook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToStartupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeFromStartupToolStripMenuItem;
    }
}

