namespace SAC
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            label1 = new System.Windows.Forms.Label();
            ButtonStart = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabManualCheck = new System.Windows.Forms.TabPage();
            label5 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            tabAutomaticCheck = new System.Windows.Forms.TabPage();
            button8 = new System.Windows.Forms.Button();
            textBoxLocalToExport = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            remainingLabel = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            checkedLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            badLabel = new System.Windows.Forms.Label();
            steamGuardLabel = new System.Windows.Forms.Label();
            loggableLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            textBoxFile = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            tabSettings = new System.Windows.Forms.TabPage();
            CheckboxShowColouredItemsInAccountList = new System.Windows.Forms.CheckBox();
            tabAbout = new System.Windows.Forms.TabPage();
            ButtonSoftwareLicense = new System.Windows.Forms.Button();
            ButtonViewThirdPartyLibraries = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            whatsHappening = new System.Windows.Forms.ListView();
            StatusColumn = new System.Windows.Forms.ColumnHeader();
            UsernameColumn = new System.Windows.Forms.ColumnHeader();
            PasswordColumn = new System.Windows.Forms.ColumnHeader();
            ResultColumn = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            loadingImage = new System.Windows.Forms.PictureBox();
            labelStatus = new System.Windows.Forms.Label();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabManualCheck.SuspendLayout();
            tabAutomaticCheck.SuspendLayout();
            groupBox1.SuspendLayout();
            tabSettings.SuspendLayout();
            tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadingImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Steam account name:";
            // 
            // ButtonStart
            // 
            ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ButtonStart.Location = new System.Drawing.Point(714, 448);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new System.Drawing.Size(158, 26);
            ButtonStart.TabIndex = 0;
            ButtonStart.Text = "Check for accounts";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(77, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Password: ";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabManualCheck);
            tabControl1.Controls.Add(tabAutomaticCheck);
            tabControl1.Controls.Add(tabSettings);
            tabControl1.Controls.Add(tabAbout);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 3;
            tabControl1.Size = new System.Drawing.Size(860, 430);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabManualCheck
            // 
            tabManualCheck.BackColor = System.Drawing.Color.White;
            tabManualCheck.Controls.Add(label5);
            tabManualCheck.Controls.Add(textBox2);
            tabManualCheck.Controls.Add(textBox1);
            tabManualCheck.Controls.Add(label2);
            tabManualCheck.Controls.Add(label1);
            tabManualCheck.Location = new System.Drawing.Point(4, 24);
            tabManualCheck.Name = "tabManualCheck";
            tabManualCheck.Padding = new System.Windows.Forms.Padding(3);
            tabManualCheck.Size = new System.Drawing.Size(852, 402);
            tabManualCheck.TabIndex = 0;
            tabManualCheck.Text = "Manual";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(21, 17);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(411, 34);
            label5.TabIndex = 7;
            label5.Text = "Check an account by manually entering an account username and a password";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(146, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(283, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(146, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(283, 23);
            textBox1.TabIndex = 5;
            // 
            // tabAutomaticCheck
            // 
            tabAutomaticCheck.BackColor = System.Drawing.Color.White;
            tabAutomaticCheck.Controls.Add(button8);
            tabAutomaticCheck.Controls.Add(textBoxLocalToExport);
            tabAutomaticCheck.Controls.Add(label11);
            tabAutomaticCheck.Controls.Add(button7);
            tabAutomaticCheck.Controls.Add(groupBox1);
            tabAutomaticCheck.Controls.Add(button6);
            tabAutomaticCheck.Controls.Add(button5);
            tabAutomaticCheck.Controls.Add(button4);
            tabAutomaticCheck.Controls.Add(label7);
            tabAutomaticCheck.Controls.Add(textBoxFile);
            tabAutomaticCheck.Controls.Add(label6);
            tabAutomaticCheck.Location = new System.Drawing.Point(4, 24);
            tabAutomaticCheck.Name = "tabAutomaticCheck";
            tabAutomaticCheck.Padding = new System.Windows.Forms.Padding(3);
            tabAutomaticCheck.Size = new System.Drawing.Size(852, 402);
            tabAutomaticCheck.TabIndex = 1;
            tabAutomaticCheck.Text = "Automatic";
            // 
            // button8
            // 
            button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button8.Location = new System.Drawing.Point(391, 84);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(35, 25);
            button8.TabIndex = 9;
            button8.Text = "...";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // textBoxLocalToExport
            // 
            textBoxLocalToExport.AllowDrop = true;
            textBoxLocalToExport.Location = new System.Drawing.Point(134, 85);
            textBoxLocalToExport.Name = "textBoxLocalToExport";
            textBoxLocalToExport.Size = new System.Drawing.Size(252, 23);
            textBoxLocalToExport.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(21, 88);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(107, 15);
            label11.TabIndex = 7;
            label11.Text = "Location to export:";
            // 
            // button7
            // 
            button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button7.Location = new System.Drawing.Point(21, 359);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(235, 24);
            button7.TabIndex = 7;
            button7.Text = "Export SteamGuard protected accounts...";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox1.Controls.Add(remainingLabel);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(checkedLabel);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(badLabel);
            groupBox1.Controls.Add(steamGuardLabel);
            groupBox1.Controls.Add(loggableLabel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new System.Drawing.Point(21, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(400, 140);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // remainingLabel
            // 
            remainingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            remainingLabel.Location = new System.Drawing.Point(154, 111);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new System.Drawing.Size(47, 15);
            remainingLabel.TabIndex = 8;
            remainingLabel.Text = "0";
            remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(19, 111);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(132, 15);
            label16.TabIndex = 8;
            label16.Text = "Remaining:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkedLabel
            // 
            checkedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkedLabel.Location = new System.Drawing.Point(154, 90);
            checkedLabel.Name = "checkedLabel";
            checkedLabel.Size = new System.Drawing.Size(47, 15);
            checkedLabel.TabIndex = 8;
            checkedLabel.Text = "0";
            checkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(19, 90);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(132, 15);
            label14.TabIndex = 8;
            label14.Text = "Checked:";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // badLabel
            // 
            badLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            badLabel.Location = new System.Drawing.Point(154, 69);
            badLabel.Name = "badLabel";
            badLabel.Size = new System.Drawing.Size(47, 15);
            badLabel.TabIndex = 8;
            badLabel.Text = "0";
            badLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // steamGuardLabel
            // 
            steamGuardLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            steamGuardLabel.Location = new System.Drawing.Point(154, 48);
            steamGuardLabel.Name = "steamGuardLabel";
            steamGuardLabel.Size = new System.Drawing.Size(47, 15);
            steamGuardLabel.TabIndex = 8;
            steamGuardLabel.Text = "0";
            steamGuardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loggableLabel
            // 
            loggableLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loggableLabel.Location = new System.Drawing.Point(154, 26);
            loggableLabel.Name = "loggableLabel";
            loggableLabel.Size = new System.Drawing.Size(47, 15);
            loggableLabel.TabIndex = 8;
            loggableLabel.Text = "0";
            loggableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(19, 69);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(132, 15);
            label10.TabIndex = 8;
            label10.Text = "Bad:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(19, 47);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(132, 15);
            label8.TabIndex = 8;
            label8.Text = "SteamGuard protected:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(19, 25);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(132, 15);
            label9.TabIndex = 8;
            label9.Text = "Loggable:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button6.Location = new System.Drawing.Point(260, 359);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(161, 24);
            button6.TabIndex = 7;
            button6.Text = "Export bad accounts...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button5.Location = new System.Drawing.Point(21, 332);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(400, 24);
            button5.TabIndex = 7;
            button5.Text = "Export good accounts...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button4.Location = new System.Drawing.Point(391, 54);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(35, 25);
            button4.TabIndex = 9;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(22, 20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(238, 15);
            label7.TabIndex = 10;
            label7.Text = "Select a file with multiple accounts to check";
            // 
            // textBoxFile
            // 
            textBoxFile.AllowDrop = true;
            textBoxFile.Location = new System.Drawing.Point(55, 55);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new System.Drawing.Size(331, 23);
            textBoxFile.TabIndex = 8;
            textBoxFile.DragOver += textBoxFile_DragOver;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(21, 58);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(28, 15);
            label6.TabIndex = 7;
            label6.Text = "File:";
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(CheckboxShowColouredItemsInAccountList);
            tabSettings.Location = new System.Drawing.Point(4, 24);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new System.Windows.Forms.Padding(3);
            tabSettings.Size = new System.Drawing.Size(852, 402);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Settings";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // CheckboxShowColouredItemsInAccountList
            // 
            CheckboxShowColouredItemsInAccountList.AutoSize = true;
            CheckboxShowColouredItemsInAccountList.Checked = true;
            CheckboxShowColouredItemsInAccountList.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckboxShowColouredItemsInAccountList.Location = new System.Drawing.Point(19, 19);
            CheckboxShowColouredItemsInAccountList.Name = "CheckboxShowColouredItemsInAccountList";
            CheckboxShowColouredItemsInAccountList.Size = new System.Drawing.Size(234, 19);
            CheckboxShowColouredItemsInAccountList.TabIndex = 8;
            CheckboxShowColouredItemsInAccountList.Text = "Show coloured items in the account list";
            CheckboxShowColouredItemsInAccountList.UseVisualStyleBackColor = true;
            CheckboxShowColouredItemsInAccountList.CheckedChanged += checkShowPasswordInLogs_CheckedChanged;
            // 
            // tabAbout
            // 
            tabAbout.BackColor = System.Drawing.Color.White;
            tabAbout.Controls.Add(ButtonSoftwareLicense);
            tabAbout.Controls.Add(ButtonViewThirdPartyLibraries);
            tabAbout.Controls.Add(pictureBox1);
            tabAbout.Controls.Add(label4);
            tabAbout.Controls.Add(button3);
            tabAbout.Controls.Add(label3);
            tabAbout.Location = new System.Drawing.Point(4, 24);
            tabAbout.Name = "tabAbout";
            tabAbout.Size = new System.Drawing.Size(852, 402);
            tabAbout.TabIndex = 2;
            tabAbout.Text = "About";
            // 
            // ButtonSoftwareLicense
            // 
            ButtonSoftwareLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            ButtonSoftwareLicense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ButtonSoftwareLicense.Location = new System.Drawing.Point(211, 362);
            ButtonSoftwareLicense.Name = "ButtonSoftwareLicense";
            ButtonSoftwareLicense.Size = new System.Drawing.Size(132, 24);
            ButtonSoftwareLicense.TabIndex = 6;
            ButtonSoftwareLicense.Text = "View software license";
            ButtonSoftwareLicense.UseVisualStyleBackColor = true;
            ButtonSoftwareLicense.Click += ButtonViewSoftwareLicense_Click;
            // 
            // ButtonViewThirdPartyLibraries
            // 
            ButtonViewThirdPartyLibraries.Anchor = System.Windows.Forms.AnchorStyles.None;
            ButtonViewThirdPartyLibraries.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ButtonViewThirdPartyLibraries.Location = new System.Drawing.Point(345, 362);
            ButtonViewThirdPartyLibraries.Name = "ButtonViewThirdPartyLibraries";
            ButtonViewThirdPartyLibraries.Size = new System.Drawing.Size(162, 24);
            ButtonViewThirdPartyLibraries.TabIndex = 6;
            ButtonViewThirdPartyLibraries.Text = "View third party libraries...";
            ButtonViewThirdPartyLibraries.UseVisualStyleBackColor = true;
            ButtonViewThirdPartyLibraries.Click += ButtonViewThirdPartyLibraries_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(390, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(72, 72);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(293, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(266, 45);
            label4.TabIndex = 7;
            label4.Text = "Made by 𝙨𝙬𝙤𝙤𝙨𝙝#1673\r\nsext is a faggit";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button3.Location = new System.Drawing.Point(510, 362);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(132, 24);
            button3.TabIndex = 6;
            button3.Text = "Copy Discord name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(320, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(212, 23);
            label3.TabIndex = 7;
            label3.Text = "Steam Account Checker";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem4, toolStripSeparator1, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMSAutomaticAccounts";
            contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            contextMenuStrip1.Size = new System.Drawing.Size(204, 98);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(203, 22);
            toolStripMenuItem4.Text = "Copy all";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            toolStripMenuItem1.Text = "Copy selected";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
            toolStripMenuItem2.Text = "Copy selected username";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
            toolStripMenuItem3.Text = "Copy selected password";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // whatsHappening
            // 
            whatsHappening.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            whatsHappening.BorderStyle = System.Windows.Forms.BorderStyle.None;
            whatsHappening.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StatusColumn, UsernameColumn, PasswordColumn, ResultColumn });
            whatsHappening.ContextMenuStrip = contextMenuStrip1;
            whatsHappening.FullRowSelect = true;
            whatsHappening.GridLines = true;
            whatsHappening.HideSelection = false;
            whatsHappening.Location = new System.Drawing.Point(453, 35);
            whatsHappening.Name = "whatsHappening";
            whatsHappening.Size = new System.Drawing.Size(416, 403);
            whatsHappening.TabIndex = 5;
            whatsHappening.UseCompatibleStateImageBehavior = false;
            whatsHappening.View = System.Windows.Forms.View.Details;
            // 
            // StatusColumn
            // 
            StatusColumn.Name = "StatusColumn";
            StatusColumn.Text = "Status";
            StatusColumn.Width = 45;
            // 
            // UsernameColumn
            // 
            UsernameColumn.Name = "UsernameColumn";
            UsernameColumn.Text = "Username";
            UsernameColumn.Width = 90;
            // 
            // PasswordColumn
            // 
            PasswordColumn.Name = "PasswordColumn";
            PasswordColumn.Text = "Password";
            PasswordColumn.Width = 90;
            // 
            // ResultColumn
            // 
            ResultColumn.Name = "ResultColumn";
            ResultColumn.Text = "Result";
            ResultColumn.Width = 180;
            // 
            // loadingImage
            // 
            loadingImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            loadingImage.Location = new System.Drawing.Point(3, 3);
            loadingImage.Name = "loadingImage";
            loadingImage.Size = new System.Drawing.Size(26, 26);
            loadingImage.TabIndex = 5;
            loadingImage.TabStop = false;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelStatus.AutoEllipsis = true;
            labelStatus.BackColor = System.Drawing.SystemColors.Control;
            labelStatus.Location = new System.Drawing.Point(35, 2);
            labelStatus.Name = "labelStatus";
            labelStatus.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            labelStatus.Size = new System.Drawing.Size(637, 28);
            labelStatus.TabIndex = 6;
            // 
            // columnHeader4
            // 
            columnHeader4.Name = "columnHeader4";
            columnHeader4.Text = "Status";
            columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            columnHeader5.Name = "columnHeader5";
            columnHeader5.Text = "Username";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Name = "columnHeader6";
            columnHeader6.Text = "Password";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Name = "columnHeader7";
            columnHeader7.Text = "Result";
            columnHeader7.Width = 180;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            flowLayoutPanel1.Controls.Add(loadingImage);
            flowLayoutPanel1.Controls.Add(labelStatus);
            flowLayoutPanel1.Location = new System.Drawing.Point(13, 444);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(695, 34);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(884, 486);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(whatsHappening);
            Controls.Add(ButtonStart);
            Controls.Add(tabControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(900, 525);
            Name = "MainWindow";
            Text = "Steam Account Checker";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            tabControl1.ResumeLayout(false);
            tabManualCheck.ResumeLayout(false);
            tabManualCheck.PerformLayout();
            tabAutomaticCheck.ResumeLayout(false);
            tabAutomaticCheck.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            tabSettings.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loadingImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabManualCheck;
        private System.Windows.Forms.TabPage tabAutomaticCheck;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button ButtonStart;
        public System.Windows.Forms.Label badLabel;
        public System.Windows.Forms.Label steamGuardLabel;
        public System.Windows.Forms.Label loggableLabel;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxFile;
        public System.Windows.Forms.Label remainingLabel;
        public System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.CheckBox CheckboxShowColouredItemsInAccountList;
        public System.Windows.Forms.TextBox textBoxLocalToExport;
        private System.Windows.Forms.Button ButtonViewThirdPartyLibraries;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader StatusColumn;
        public System.Windows.Forms.ColumnHeader UsernameColumn;
        public System.Windows.Forms.ColumnHeader PasswordColumn;
        public System.Windows.Forms.ColumnHeader ResultColumn;
        public System.Windows.Forms.PictureBox loadingImage;
        public System.Windows.Forms.ListView whatsHappening;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button ButtonSoftwareLicense;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

