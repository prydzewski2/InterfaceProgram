﻿
using System.Collections.Generic;
using System.Windows.Forms;

namespace QS_DS_Program
{
    partial class QS_DS_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QS_DS_Program));
            this.Label1 = new System.Windows.Forms.Label();
            this.RPMRead = new System.Windows.Forms.Label();
            this.Reset_BTN = new System.Windows.Forms.Button();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.Read_BTN = new System.Windows.Forms.Button();
            this.LabelRPMCur = new System.Windows.Forms.Label();
            this.Connect_BTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tabs_All = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.Pulses = new System.Windows.Forms.NumericUpDown();
            this.LabelGeneral1 = new System.Windows.Forms.Label();
            this.QSPage = new System.Windows.Forms.TabPage();
            this.PostDelayQS = new System.Windows.Forms.NumericUpDown();
            this.LabelQS12 = new System.Windows.Forms.Label();
            this.LabelCutTime = new System.Windows.Forms.Label();
            this.Push_Check_QS = new System.Windows.Forms.CheckBox();
            this.CutTest_BTN = new System.Windows.Forms.Button();
            this.LabelQS1 = new System.Windows.Forms.Label();
            this.LabelQS2 = new System.Windows.Forms.Label();
            this.LabelQS3 = new System.Windows.Forms.Label();
            this.LabelQS4 = new System.Windows.Forms.Label();
            this.LabelQS11 = new System.Windows.Forms.Label();
            this.LabelQS10 = new System.Windows.Forms.Label();
            this.LabelQS5 = new System.Windows.Forms.Label();
            this.MinRPMQS = new System.Windows.Forms.NumericUpDown();
            this.CutTime8 = new System.Windows.Forms.NumericUpDown();
            this.LabelQS6 = new System.Windows.Forms.Label();
            this.CutTime7 = new System.Windows.Forms.NumericUpDown();
            this.LabelQS7 = new System.Windows.Forms.Label();
            this.CutTime6 = new System.Windows.Forms.NumericUpDown();
            this.LabelQS8 = new System.Windows.Forms.Label();
            this.QSForce = new System.Windows.Forms.NumericUpDown();
            this.CutTime5 = new System.Windows.Forms.NumericUpDown();
            this.LabelQS9 = new System.Windows.Forms.Label();
            this.CutTime4 = new System.Windows.Forms.NumericUpDown();
            this.QSEnable_Check = new System.Windows.Forms.CheckBox();
            this.CutTime3 = new System.Windows.Forms.NumericUpDown();
            this.PreDelayQS = new System.Windows.Forms.NumericUpDown();
            this.CutTime2 = new System.Windows.Forms.NumericUpDown();
            this.CutTime1 = new System.Windows.Forms.NumericUpDown();
            this.Pull_Check_QS = new System.Windows.Forms.CheckBox();
            this.DSPage = new System.Windows.Forms.TabPage();
            this.LabelDS13 = new System.Windows.Forms.Label();
            this.PostDelayDS = new System.Windows.Forms.NumericUpDown();
            this.Pull_Check_DS = new System.Windows.Forms.CheckBox();
            this.Push_Check_DS = new System.Windows.Forms.CheckBox();
            this.MaxRPMDS = new System.Windows.Forms.NumericUpDown();
            this.LabelDS12 = new System.Windows.Forms.Label();
            this.LabelDS2 = new System.Windows.Forms.Label();
            this.LabelDS10 = new System.Windows.Forms.Label();
            this.LabelDS11 = new System.Windows.Forms.Label();
            this.BlipTime7 = new System.Windows.Forms.NumericUpDown();
            this.MinRPMDS = new System.Windows.Forms.NumericUpDown();
            this.LabelDS1 = new System.Windows.Forms.Label();
            this.BlipTime8 = new System.Windows.Forms.NumericUpDown();
            this.DSEnable_Check = new System.Windows.Forms.CheckBox();
            this.BlipTime6 = new System.Windows.Forms.NumericUpDown();
            this.BlipTest_BTN = new System.Windows.Forms.Button();
            this.BlipTime5 = new System.Windows.Forms.NumericUpDown();
            this.LabelDS3 = new System.Windows.Forms.Label();
            this.BlipTime4 = new System.Windows.Forms.NumericUpDown();
            this.DSForce = new System.Windows.Forms.NumericUpDown();
            this.LabelDS4 = new System.Windows.Forms.Label();
            this.BlipTime3 = new System.Windows.Forms.NumericUpDown();
            this.LabelDS5 = new System.Windows.Forms.Label();
            this.BlipTime2 = new System.Windows.Forms.NumericUpDown();
            this.LabelDS6 = new System.Windows.Forms.Label();
            this.BlipTime1 = new System.Windows.Forms.NumericUpDown();
            this.LabelDS7 = new System.Windows.Forms.Label();
            this.PreDelayDS = new System.Windows.Forms.NumericUpDown();
            this.LabelDS8 = new System.Windows.Forms.Label();
            this.LabelDS9 = new System.Windows.Forms.Label();
            this.LabelSensorReading = new System.Windows.Forms.Label();
            this.ProgressBarSensor = new System.Windows.Forms.ProgressBar();
            this.LabelSensorOutput = new System.Windows.Forms.Label();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelSensorDirection = new System.Windows.Forms.Label();
            this.Refresh_BTN = new System.Windows.Forms.Button();
            this.MainSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Tabs_All.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pulses)).BeginInit();
            this.QSPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDelayQS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRPMQS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QSForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayQS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime1)).BeginInit();
            this.DSPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDelayDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRPMDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRPMDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayDS)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(28, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 17);
            this.Label1.TabIndex = 102;
            this.Label1.Text = "Port";
            this.Tips.SetToolTip(this.Label1, "Available COM ports.");
            // 
            // RPMRead
            // 
            this.RPMRead.AutoSize = true;
            this.RPMRead.BackColor = System.Drawing.Color.Transparent;
            this.RPMRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RPMRead.Location = new System.Drawing.Point(710, 91);
            this.RPMRead.Name = "RPMRead";
            this.RPMRead.Size = new System.Drawing.Size(16, 18);
            this.RPMRead.TabIndex = 103;
            this.RPMRead.Text = "0";
            this.RPMRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reset_BTN
            // 
            this.Reset_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_BTN.Location = new System.Drawing.Point(650, 23);
            this.Reset_BTN.Name = "Reset_BTN";
            this.Reset_BTN.Size = new System.Drawing.Size(110, 40);
            this.Reset_BTN.TabIndex = 101;
            this.Reset_BTN.Text = "RESET";
            this.Tips.SetToolTip(this.Reset_BTN, "Press to reset module data to defaults.");
            this.Reset_BTN.UseVisualStyleBackColor = true;
            this.Reset_BTN.Click += new System.EventHandler(this.Reset_BTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Save_BTN.Location = new System.Drawing.Point(509, 23);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(110, 40);
            this.Save_BTN.TabIndex = 100;
            this.Save_BTN.Text = "Save";
            this.Tips.SetToolTip(this.Save_BTN, "Press to save new data to module.");
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // Read_BTN
            // 
            this.Read_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Read_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Read_BTN.Location = new System.Drawing.Point(371, 23);
            this.Read_BTN.Name = "Read_BTN";
            this.Read_BTN.Size = new System.Drawing.Size(110, 40);
            this.Read_BTN.TabIndex = 99;
            this.Read_BTN.Text = "Read";
            this.Tips.SetToolTip(this.Read_BTN, "Press to read data from module.");
            this.Read_BTN.UseVisualStyleBackColor = true;
            this.Read_BTN.Click += new System.EventHandler(this.Read_BTN_Click);
            // 
            // LabelRPMCur
            // 
            this.LabelRPMCur.AutoSize = true;
            this.LabelRPMCur.BackColor = System.Drawing.Color.Transparent;
            this.LabelRPMCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelRPMCur.Location = new System.Drawing.Point(570, 91);
            this.LabelRPMCur.Name = "LabelRPMCur";
            this.LabelRPMCur.Size = new System.Drawing.Size(95, 18);
            this.LabelRPMCur.TabIndex = 104;
            this.LabelRPMCur.Text = "Current RPM";
            this.Tips.SetToolTip(this.LabelRPMCur, "Current read RPM.");
            // 
            // Connect_BTN
            // 
            this.Connect_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Connect_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Connect_BTN.Location = new System.Drawing.Point(233, 23);
            this.Connect_BTN.Name = "Connect_BTN";
            this.Connect_BTN.Size = new System.Drawing.Size(110, 40);
            this.Connect_BTN.TabIndex = 98;
            this.Connect_BTN.Text = "Connect";
            this.Tips.SetToolTip(this.Connect_BTN, "Press to connect to selected COM port or disconnect if already connected.");
            this.Connect_BTN.UseCompatibleTextRendering = true;
            this.Connect_BTN.UseVisualStyleBackColor = true;
            this.Connect_BTN.Click += new System.EventHandler(this.Connect_BTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 26);
            this.comboBox1.TabIndex = 97;
            this.Tips.SetToolTip(this.comboBox1, "Select COM port where module is connected.");
            // 
            // Tabs_All
            // 
            this.Tabs_All.Controls.Add(this.GeneralPage);
            this.Tabs_All.Controls.Add(this.QSPage);
            this.Tabs_All.Controls.Add(this.DSPage);
            this.Tabs_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Tabs_All.Location = new System.Drawing.Point(24, 69);
            this.Tabs_All.Name = "Tabs_All";
            this.Tabs_All.SelectedIndex = 0;
            this.Tabs_All.Size = new System.Drawing.Size(525, 468);
            this.Tabs_All.TabIndex = 106;
            // 
            // GeneralPage
            // 
            this.GeneralPage.BackColor = System.Drawing.Color.Transparent;
            this.GeneralPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralPage.Controls.Add(this.Pulses);
            this.GeneralPage.Controls.Add(this.LabelGeneral1);
            this.GeneralPage.Location = new System.Drawing.Point(4, 27);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralPage.Size = new System.Drawing.Size(517, 437);
            this.GeneralPage.TabIndex = 0;
            this.GeneralPage.Text = "General";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // Pulses
            // 
            this.Pulses.DecimalPlaces = 1;
            this.Pulses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pulses.Location = new System.Drawing.Point(138, 25);
            this.Pulses.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Pulses.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Pulses.Name = "Pulses";
            this.Pulses.Size = new System.Drawing.Size(60, 24);
            this.Pulses.TabIndex = 10;
            this.Pulses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pulses.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Pulses.ValueChanged += new System.EventHandler(this.Pulses_ValueChanged);
            // 
            // LabelGeneral1
            // 
            this.LabelGeneral1.AutoSize = true;
            this.LabelGeneral1.BackColor = System.Drawing.Color.Transparent;
            this.LabelGeneral1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelGeneral1.Location = new System.Drawing.Point(18, 28);
            this.LabelGeneral1.Name = "LabelGeneral1";
            this.LabelGeneral1.Size = new System.Drawing.Size(91, 18);
            this.LabelGeneral1.TabIndex = 21;
            this.LabelGeneral1.Text = "Pulses/RPM";
            this.Tips.SetToolTip(this.LabelGeneral1, "Pulses per revolution of crankshaft - check current RPM value with vehicle tachom" +
        "eter.");
            // 
            // QSPage
            // 
            this.QSPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QSPage.Controls.Add(this.PostDelayQS);
            this.QSPage.Controls.Add(this.LabelQS12);
            this.QSPage.Controls.Add(this.LabelCutTime);
            this.QSPage.Controls.Add(this.Push_Check_QS);
            this.QSPage.Controls.Add(this.CutTest_BTN);
            this.QSPage.Controls.Add(this.LabelQS1);
            this.QSPage.Controls.Add(this.LabelQS2);
            this.QSPage.Controls.Add(this.LabelQS3);
            this.QSPage.Controls.Add(this.LabelQS4);
            this.QSPage.Controls.Add(this.LabelQS11);
            this.QSPage.Controls.Add(this.LabelQS10);
            this.QSPage.Controls.Add(this.LabelQS5);
            this.QSPage.Controls.Add(this.MinRPMQS);
            this.QSPage.Controls.Add(this.CutTime8);
            this.QSPage.Controls.Add(this.LabelQS6);
            this.QSPage.Controls.Add(this.CutTime7);
            this.QSPage.Controls.Add(this.LabelQS7);
            this.QSPage.Controls.Add(this.CutTime6);
            this.QSPage.Controls.Add(this.LabelQS8);
            this.QSPage.Controls.Add(this.QSForce);
            this.QSPage.Controls.Add(this.CutTime5);
            this.QSPage.Controls.Add(this.LabelQS9);
            this.QSPage.Controls.Add(this.CutTime4);
            this.QSPage.Controls.Add(this.QSEnable_Check);
            this.QSPage.Controls.Add(this.CutTime3);
            this.QSPage.Controls.Add(this.PreDelayQS);
            this.QSPage.Controls.Add(this.CutTime2);
            this.QSPage.Controls.Add(this.CutTime1);
            this.QSPage.Controls.Add(this.Pull_Check_QS);
            this.QSPage.Location = new System.Drawing.Point(4, 27);
            this.QSPage.Name = "QSPage";
            this.QSPage.Padding = new System.Windows.Forms.Padding(3);
            this.QSPage.Size = new System.Drawing.Size(517, 437);
            this.QSPage.TabIndex = 1;
            this.QSPage.Text = "QuickShifter";
            this.QSPage.UseVisualStyleBackColor = true;
            // 
            // PostDelayQS
            // 
            this.PostDelayQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PostDelayQS.Location = new System.Drawing.Point(390, 182);
            this.PostDelayQS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PostDelayQS.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PostDelayQS.Name = "PostDelayQS";
            this.PostDelayQS.Size = new System.Drawing.Size(60, 24);
            this.PostDelayQS.TabIndex = 69;
            this.PostDelayQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostDelayQS.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // LabelQS12
            // 
            this.LabelQS12.AutoSize = true;
            this.LabelQS12.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS12.Location = new System.Drawing.Point(275, 185);
            this.LabelQS12.Name = "LabelQS12";
            this.LabelQS12.Size = new System.Drawing.Size(78, 18);
            this.LabelQS12.TabIndex = 68;
            this.LabelQS12.Text = "Post-delay";
            this.LabelQS12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS12, "Time after cutting - before next allowed cut.");
            // 
            // LabelCutTime
            // 
            this.LabelCutTime.AutoSize = true;
            this.LabelCutTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelCutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelCutTime.Location = new System.Drawing.Point(64, 67);
            this.LabelCutTime.Name = "LabelCutTime";
            this.LabelCutTime.Size = new System.Drawing.Size(63, 18);
            this.LabelCutTime.TabIndex = 67;
            this.LabelCutTime.Text = "Cut time";
            this.LabelCutTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelCutTime, "Cut time");
            // 
            // Push_Check_QS
            // 
            this.Push_Check_QS.AutoSize = true;
            this.Push_Check_QS.BackColor = System.Drawing.Color.Transparent;
            this.Push_Check_QS.Checked = true;
            this.Push_Check_QS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Push_Check_QS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Push_Check_QS.Location = new System.Drawing.Point(290, 25);
            this.Push_Check_QS.Name = "Push_Check_QS";
            this.Push_Check_QS.Size = new System.Drawing.Size(61, 22);
            this.Push_Check_QS.TabIndex = 0;
            this.Push_Check_QS.Text = "Push";
            this.Tips.SetToolTip(this.Push_Check_QS, "Check if sensor is pulled when engaging next gear (text above sensor output shows" +
        " \"Push\").");
            this.Push_Check_QS.UseVisualStyleBackColor = false;
            this.Push_Check_QS.CheckedChanged += new System.EventHandler(this.Push_Check_QS_CheckedChanged);
            // 
            // CutTest_BTN
            // 
            this.CutTest_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CutTest_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTest_BTN.Location = new System.Drawing.Point(118, 12);
            this.CutTest_BTN.Name = "CutTest_BTN";
            this.CutTest_BTN.Size = new System.Drawing.Size(101, 33);
            this.CutTest_BTN.TabIndex = 0;
            this.CutTest_BTN.Text = "Cut TEST";
            this.Tips.SetToolTip(this.CutTest_BTN, "Press to check ignition cut.");
            this.CutTest_BTN.UseVisualStyleBackColor = true;
            this.CutTest_BTN.Click += new System.EventHandler(this.CutTest_BTN_Click);
            // 
            // LabelQS1
            // 
            this.LabelQS1.AutoSize = true;
            this.LabelQS1.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS1.Location = new System.Drawing.Point(278, 145);
            this.LabelQS1.Name = "LabelQS1";
            this.LabelQS1.Size = new System.Drawing.Size(70, 18);
            this.LabelQS1.TabIndex = 23;
            this.LabelQS1.Text = "Pre-delay";
            this.LabelQS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS1, "Time after action on sensor - before cutting.");
            // 
            // LabelQS2
            // 
            this.LabelQS2.AutoSize = true;
            this.LabelQS2.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS2.Location = new System.Drawing.Point(44, 68);
            this.LabelQS2.Name = "LabelQS2";
            this.LabelQS2.Size = new System.Drawing.Size(40, 18);
            this.LabelQS2.TabIndex = 24;
            this.LabelQS2.Text = "2000";
            this.LabelQS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS2, "Cut time at 2000 RPM.");
            // 
            // LabelQS3
            // 
            this.LabelQS3.AutoSize = true;
            this.LabelQS3.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS3.Location = new System.Drawing.Point(44, 108);
            this.LabelQS3.Name = "LabelQS3";
            this.LabelQS3.Size = new System.Drawing.Size(40, 18);
            this.LabelQS3.TabIndex = 25;
            this.LabelQS3.Text = "4000";
            this.LabelQS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS3, "Cut time at 4000 RPM.");
            // 
            // LabelQS4
            // 
            this.LabelQS4.AutoSize = true;
            this.LabelQS4.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS4.Location = new System.Drawing.Point(44, 148);
            this.LabelQS4.Name = "LabelQS4";
            this.LabelQS4.Size = new System.Drawing.Size(40, 18);
            this.LabelQS4.TabIndex = 26;
            this.LabelQS4.Text = "6000";
            this.LabelQS4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS4, "Cut time at 6000 RPM.");
            // 
            // LabelQS11
            // 
            this.LabelQS11.AutoSize = true;
            this.LabelQS11.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS11.Location = new System.Drawing.Point(265, 105);
            this.LabelQS11.Name = "LabelQS11";
            this.LabelQS11.Size = new System.Drawing.Size(100, 18);
            this.LabelQS11.TabIndex = 22;
            this.LabelQS11.Text = "Min. RPM QS";
            this.Tips.SetToolTip(this.LabelQS11, "Minimum RPM for QS to work.");
            // 
            // LabelQS10
            // 
            this.LabelQS10.AutoSize = true;
            this.LabelQS10.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS10.Location = new System.Drawing.Point(255, 65);
            this.LabelQS10.Name = "LabelQS10";
            this.LabelQS10.Size = new System.Drawing.Size(121, 18);
            this.LabelQS10.TabIndex = 17;
            this.LabelQS10.Text = "Sensor threshold";
            this.Tips.SetToolTip(this.LabelQS10, "Quickshifter activation threshold - check value at sensor output.");
            // 
            // LabelQS5
            // 
            this.LabelQS5.AutoSize = true;
            this.LabelQS5.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS5.Location = new System.Drawing.Point(44, 188);
            this.LabelQS5.Name = "LabelQS5";
            this.LabelQS5.Size = new System.Drawing.Size(40, 18);
            this.LabelQS5.TabIndex = 27;
            this.LabelQS5.Text = "8000";
            this.LabelQS5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS5, "Cut time at 8000 RPM.");
            // 
            // MinRPMQS
            // 
            this.MinRPMQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinRPMQS.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MinRPMQS.Location = new System.Drawing.Point(390, 102);
            this.MinRPMQS.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MinRPMQS.Name = "MinRPMQS";
            this.MinRPMQS.Size = new System.Drawing.Size(60, 24);
            this.MinRPMQS.TabIndex = 51;
            this.MinRPMQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinRPMQS.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // CutTime8
            // 
            this.CutTime8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime8.Location = new System.Drawing.Point(142, 345);
            this.CutTime8.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime8.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime8.Name = "CutTime8";
            this.CutTime8.Size = new System.Drawing.Size(60, 24);
            this.CutTime8.TabIndex = 66;
            this.CutTime8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime8.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelQS6
            // 
            this.LabelQS6.AutoSize = true;
            this.LabelQS6.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS6.Location = new System.Drawing.Point(39, 228);
            this.LabelQS6.Name = "LabelQS6";
            this.LabelQS6.Size = new System.Drawing.Size(48, 18);
            this.LabelQS6.TabIndex = 28;
            this.LabelQS6.Text = "10000";
            this.LabelQS6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS6, "Cut time at 10000 RPM.");
            // 
            // CutTime7
            // 
            this.CutTime7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime7.Location = new System.Drawing.Point(142, 305);
            this.CutTime7.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime7.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime7.Name = "CutTime7";
            this.CutTime7.Size = new System.Drawing.Size(60, 24);
            this.CutTime7.TabIndex = 65;
            this.CutTime7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime7.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelQS7
            // 
            this.LabelQS7.AutoSize = true;
            this.LabelQS7.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS7.Location = new System.Drawing.Point(39, 268);
            this.LabelQS7.Name = "LabelQS7";
            this.LabelQS7.Size = new System.Drawing.Size(48, 18);
            this.LabelQS7.TabIndex = 29;
            this.LabelQS7.Text = "12000";
            this.LabelQS7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS7, "Cut time at 12000 RPM.");
            // 
            // CutTime6
            // 
            this.CutTime6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime6.Location = new System.Drawing.Point(142, 265);
            this.CutTime6.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime6.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime6.Name = "CutTime6";
            this.CutTime6.Size = new System.Drawing.Size(60, 24);
            this.CutTime6.TabIndex = 64;
            this.CutTime6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime6.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelQS8
            // 
            this.LabelQS8.AutoSize = true;
            this.LabelQS8.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS8.Location = new System.Drawing.Point(39, 308);
            this.LabelQS8.Name = "LabelQS8";
            this.LabelQS8.Size = new System.Drawing.Size(48, 18);
            this.LabelQS8.TabIndex = 30;
            this.LabelQS8.Text = "14000";
            this.LabelQS8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS8, "Cut time at 14000 RPM.");
            // 
            // QSForce
            // 
            this.QSForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QSForce.Location = new System.Drawing.Point(390, 62);
            this.QSForce.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.QSForce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QSForce.Name = "QSForce";
            this.QSForce.Size = new System.Drawing.Size(60, 24);
            this.QSForce.TabIndex = 55;
            this.QSForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QSForce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CutTime5
            // 
            this.CutTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime5.Location = new System.Drawing.Point(142, 225);
            this.CutTime5.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime5.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime5.Name = "CutTime5";
            this.CutTime5.Size = new System.Drawing.Size(60, 24);
            this.CutTime5.TabIndex = 63;
            this.CutTime5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime5.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelQS9
            // 
            this.LabelQS9.AutoSize = true;
            this.LabelQS9.BackColor = System.Drawing.Color.Transparent;
            this.LabelQS9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelQS9.Location = new System.Drawing.Point(34, 348);
            this.LabelQS9.Name = "LabelQS9";
            this.LabelQS9.Size = new System.Drawing.Size(61, 18);
            this.LabelQS9.TabIndex = 31;
            this.LabelQS9.Text = "> 16000";
            this.LabelQS9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelQS9, "Cut time above 16000 RPM.");
            // 
            // CutTime4
            // 
            this.CutTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime4.Location = new System.Drawing.Point(142, 185);
            this.CutTime4.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime4.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime4.Name = "CutTime4";
            this.CutTime4.Size = new System.Drawing.Size(60, 24);
            this.CutTime4.TabIndex = 62;
            this.CutTime4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime4.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // QSEnable_Check
            // 
            this.QSEnable_Check.AutoSize = true;
            this.QSEnable_Check.BackColor = System.Drawing.Color.Transparent;
            this.QSEnable_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QSEnable_Check.Location = new System.Drawing.Point(18, 17);
            this.QSEnable_Check.Name = "QSEnable_Check";
            this.QSEnable_Check.Size = new System.Drawing.Size(72, 22);
            this.QSEnable_Check.TabIndex = 34;
            this.QSEnable_Check.Text = "Enable";
            this.Tips.SetToolTip(this.QSEnable_Check, "Check to enable QS.");
            this.QSEnable_Check.UseVisualStyleBackColor = false;
            // 
            // CutTime3
            // 
            this.CutTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime3.Location = new System.Drawing.Point(142, 145);
            this.CutTime3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime3.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime3.Name = "CutTime3";
            this.CutTime3.Size = new System.Drawing.Size(60, 24);
            this.CutTime3.TabIndex = 61;
            this.CutTime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // PreDelayQS
            // 
            this.PreDelayQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreDelayQS.Location = new System.Drawing.Point(390, 142);
            this.PreDelayQS.Name = "PreDelayQS";
            this.PreDelayQS.Size = new System.Drawing.Size(60, 24);
            this.PreDelayQS.TabIndex = 58;
            this.PreDelayQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CutTime2
            // 
            this.CutTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime2.Location = new System.Drawing.Point(142, 105);
            this.CutTime2.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime2.Name = "CutTime2";
            this.CutTime2.Size = new System.Drawing.Size(60, 24);
            this.CutTime2.TabIndex = 60;
            this.CutTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // CutTime1
            // 
            this.CutTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CutTime1.Location = new System.Drawing.Point(142, 65);
            this.CutTime1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CutTime1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CutTime1.Name = "CutTime1";
            this.CutTime1.Size = new System.Drawing.Size(60, 24);
            this.CutTime1.TabIndex = 59;
            this.CutTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CutTime1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Pull_Check_QS
            // 
            this.Pull_Check_QS.AutoSize = true;
            this.Pull_Check_QS.BackColor = System.Drawing.Color.Transparent;
            this.Pull_Check_QS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pull_Check_QS.Location = new System.Drawing.Point(390, 25);
            this.Pull_Check_QS.Name = "Pull_Check_QS";
            this.Pull_Check_QS.Size = new System.Drawing.Size(51, 22);
            this.Pull_Check_QS.TabIndex = 48;
            this.Pull_Check_QS.Text = "Pull";
            this.Tips.SetToolTip(this.Pull_Check_QS, "Check if sensor is pushed when engaging next gear (text above sensor output shows" +
        " \"Pull\").");
            this.Pull_Check_QS.UseVisualStyleBackColor = false;
            this.Pull_Check_QS.CheckedChanged += new System.EventHandler(this.Pull_Check_QS_CheckedChanged);
            // 
            // DSPage
            // 
            this.DSPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DSPage.Controls.Add(this.LabelDS13);
            this.DSPage.Controls.Add(this.PostDelayDS);
            this.DSPage.Controls.Add(this.Pull_Check_DS);
            this.DSPage.Controls.Add(this.Push_Check_DS);
            this.DSPage.Controls.Add(this.MaxRPMDS);
            this.DSPage.Controls.Add(this.LabelDS12);
            this.DSPage.Controls.Add(this.LabelDS2);
            this.DSPage.Controls.Add(this.LabelDS10);
            this.DSPage.Controls.Add(this.LabelDS11);
            this.DSPage.Controls.Add(this.BlipTime7);
            this.DSPage.Controls.Add(this.MinRPMDS);
            this.DSPage.Controls.Add(this.LabelDS1);
            this.DSPage.Controls.Add(this.BlipTime8);
            this.DSPage.Controls.Add(this.DSEnable_Check);
            this.DSPage.Controls.Add(this.BlipTime6);
            this.DSPage.Controls.Add(this.BlipTest_BTN);
            this.DSPage.Controls.Add(this.BlipTime5);
            this.DSPage.Controls.Add(this.LabelDS3);
            this.DSPage.Controls.Add(this.BlipTime4);
            this.DSPage.Controls.Add(this.DSForce);
            this.DSPage.Controls.Add(this.LabelDS4);
            this.DSPage.Controls.Add(this.BlipTime3);
            this.DSPage.Controls.Add(this.LabelDS5);
            this.DSPage.Controls.Add(this.BlipTime2);
            this.DSPage.Controls.Add(this.LabelDS6);
            this.DSPage.Controls.Add(this.BlipTime1);
            this.DSPage.Controls.Add(this.LabelDS7);
            this.DSPage.Controls.Add(this.PreDelayDS);
            this.DSPage.Controls.Add(this.LabelDS8);
            this.DSPage.Controls.Add(this.LabelDS9);
            this.DSPage.Location = new System.Drawing.Point(4, 27);
            this.DSPage.Name = "DSPage";
            this.DSPage.Padding = new System.Windows.Forms.Padding(3);
            this.DSPage.Size = new System.Drawing.Size(517, 437);
            this.DSPage.TabIndex = 2;
            this.DSPage.Text = "DownShifter";
            this.DSPage.UseVisualStyleBackColor = true;
            // 
            // LabelDS13
            // 
            this.LabelDS13.AutoSize = true;
            this.LabelDS13.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS13.Location = new System.Drawing.Point(275, 225);
            this.LabelDS13.Name = "LabelDS13";
            this.LabelDS13.Size = new System.Drawing.Size(78, 18);
            this.LabelDS13.TabIndex = 84;
            this.LabelDS13.Text = "Post-delay";
            this.LabelDS13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS13, "Time after blipping - before next allowed blip.");
            // 
            // PostDelayDS
            // 
            this.PostDelayDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PostDelayDS.Location = new System.Drawing.Point(390, 222);
            this.PostDelayDS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PostDelayDS.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PostDelayDS.Name = "PostDelayDS";
            this.PostDelayDS.Size = new System.Drawing.Size(60, 24);
            this.PostDelayDS.TabIndex = 85;
            this.PostDelayDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostDelayDS.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Pull_Check_DS
            // 
            this.Pull_Check_DS.AutoSize = true;
            this.Pull_Check_DS.Checked = true;
            this.Pull_Check_DS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Pull_Check_DS.Location = new System.Drawing.Point(390, 25);
            this.Pull_Check_DS.Name = "Pull_Check_DS";
            this.Pull_Check_DS.Size = new System.Drawing.Size(51, 22);
            this.Pull_Check_DS.TabIndex = 83;
            this.Pull_Check_DS.Text = "Pull";
            this.Tips.SetToolTip(this.Pull_Check_DS, "Check if sensor is pushed when engaging lower gear (text above sensor output show" +
        "s \"Pull\").");
            this.Pull_Check_DS.UseVisualStyleBackColor = true;
            this.Pull_Check_DS.CheckedChanged += new System.EventHandler(this.Pull_Check_DS_CheckedChanged);
            // 
            // Push_Check_DS
            // 
            this.Push_Check_DS.AutoSize = true;
            this.Push_Check_DS.Location = new System.Drawing.Point(290, 25);
            this.Push_Check_DS.Name = "Push_Check_DS";
            this.Push_Check_DS.Size = new System.Drawing.Size(61, 22);
            this.Push_Check_DS.TabIndex = 82;
            this.Push_Check_DS.Text = "Push";
            this.Tips.SetToolTip(this.Push_Check_DS, "Check if sensor is pulled when engaging lower gear (text above sensor output show" +
        "s \"Push\").");
            this.Push_Check_DS.UseVisualStyleBackColor = true;
            this.Push_Check_DS.CheckedChanged += new System.EventHandler(this.Push_Check_DS_CheckedChanged);
            // 
            // MaxRPMDS
            // 
            this.MaxRPMDS.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MaxRPMDS.Location = new System.Drawing.Point(390, 142);
            this.MaxRPMDS.Maximum = new decimal(new int[] {
            20500,
            0,
            0,
            0});
            this.MaxRPMDS.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MaxRPMDS.Name = "MaxRPMDS";
            this.MaxRPMDS.Size = new System.Drawing.Size(60, 24);
            this.MaxRPMDS.TabIndex = 81;
            this.MaxRPMDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxRPMDS.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.MaxRPMDS.ValueChanged += new System.EventHandler(this.MaxRPMDS_ValueChanged);
            // 
            // LabelDS12
            // 
            this.LabelDS12.AutoSize = true;
            this.LabelDS12.Location = new System.Drawing.Point(265, 145);
            this.LabelDS12.Name = "LabelDS12";
            this.LabelDS12.Size = new System.Drawing.Size(103, 18);
            this.LabelDS12.TabIndex = 80;
            this.LabelDS12.Text = "Max. RPM DS";
            this.Tips.SetToolTip(this.LabelDS12, "Maximum RPM for DS to work.");
            // 
            // LabelDS2
            // 
            this.LabelDS2.AutoSize = true;
            this.LabelDS2.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS2.Location = new System.Drawing.Point(44, 68);
            this.LabelDS2.Name = "LabelDS2";
            this.LabelDS2.Size = new System.Drawing.Size(40, 18);
            this.LabelDS2.TabIndex = 32;
            this.LabelDS2.Text = "2000";
            this.LabelDS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS2, "Blip time at 2000RPM.");
            // 
            // LabelDS10
            // 
            this.LabelDS10.AutoSize = true;
            this.LabelDS10.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS10.Location = new System.Drawing.Point(255, 65);
            this.LabelDS10.Name = "LabelDS10";
            this.LabelDS10.Size = new System.Drawing.Size(121, 18);
            this.LabelDS10.TabIndex = 18;
            this.LabelDS10.Text = "Sensor threshold";
            this.Tips.SetToolTip(this.LabelDS10, "Downshifter activation threshold - check value at sensor output.");
            // 
            // LabelDS11
            // 
            this.LabelDS11.AutoSize = true;
            this.LabelDS11.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS11.Location = new System.Drawing.Point(265, 105);
            this.LabelDS11.Name = "LabelDS11";
            this.LabelDS11.Size = new System.Drawing.Size(99, 18);
            this.LabelDS11.TabIndex = 50;
            this.LabelDS11.Text = "Min. RPM DS";
            this.Tips.SetToolTip(this.LabelDS11, "Minimum RPM for DS to work.");
            // 
            // BlipTime7
            // 
            this.BlipTime7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime7.Location = new System.Drawing.Point(142, 305);
            this.BlipTime7.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime7.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime7.Name = "BlipTime7";
            this.BlipTime7.Size = new System.Drawing.Size(60, 24);
            this.BlipTime7.TabIndex = 79;
            this.BlipTime7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime7.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // MinRPMDS
            // 
            this.MinRPMDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinRPMDS.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MinRPMDS.Location = new System.Drawing.Point(390, 102);
            this.MinRPMDS.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MinRPMDS.Name = "MinRPMDS";
            this.MinRPMDS.Size = new System.Drawing.Size(60, 24);
            this.MinRPMDS.TabIndex = 52;
            this.MinRPMDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinRPMDS.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MinRPMDS.ValueChanged += new System.EventHandler(this.MinRPMDS_ValueChanged);
            // 
            // LabelDS1
            // 
            this.LabelDS1.AutoSize = true;
            this.LabelDS1.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS1.Location = new System.Drawing.Point(278, 185);
            this.LabelDS1.Name = "LabelDS1";
            this.LabelDS1.Size = new System.Drawing.Size(70, 18);
            this.LabelDS1.TabIndex = 33;
            this.LabelDS1.Text = "Pre-delay";
            this.LabelDS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS1, "Time after action on sensor - before cutting.");
            // 
            // BlipTime8
            // 
            this.BlipTime8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime8.Location = new System.Drawing.Point(142, 345);
            this.BlipTime8.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime8.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime8.Name = "BlipTime8";
            this.BlipTime8.Size = new System.Drawing.Size(60, 24);
            this.BlipTime8.TabIndex = 78;
            this.BlipTime8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime8.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // DSEnable_Check
            // 
            this.DSEnable_Check.AutoSize = true;
            this.DSEnable_Check.BackColor = System.Drawing.Color.Transparent;
            this.DSEnable_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DSEnable_Check.Location = new System.Drawing.Point(18, 17);
            this.DSEnable_Check.Name = "DSEnable_Check";
            this.DSEnable_Check.Size = new System.Drawing.Size(72, 22);
            this.DSEnable_Check.TabIndex = 35;
            this.DSEnable_Check.Text = "Enable";
            this.Tips.SetToolTip(this.DSEnable_Check, "Check to enable DS.");
            this.DSEnable_Check.UseVisualStyleBackColor = false;
            // 
            // BlipTime6
            // 
            this.BlipTime6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime6.Location = new System.Drawing.Point(142, 265);
            this.BlipTime6.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime6.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime6.Name = "BlipTime6";
            this.BlipTime6.Size = new System.Drawing.Size(60, 24);
            this.BlipTime6.TabIndex = 74;
            this.BlipTime6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime6.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // BlipTest_BTN
            // 
            this.BlipTest_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlipTest_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTest_BTN.Location = new System.Drawing.Point(118, 12);
            this.BlipTest_BTN.Name = "BlipTest_BTN";
            this.BlipTest_BTN.Size = new System.Drawing.Size(101, 33);
            this.BlipTest_BTN.TabIndex = 36;
            this.BlipTest_BTN.Text = "Blip TEST";
            this.Tips.SetToolTip(this.BlipTest_BTN, "Press to check blipping.");
            this.BlipTest_BTN.UseVisualStyleBackColor = true;
            this.BlipTest_BTN.Click += new System.EventHandler(this.BlipTest_BTN_Click);
            // 
            // BlipTime5
            // 
            this.BlipTime5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime5.Location = new System.Drawing.Point(142, 225);
            this.BlipTime5.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime5.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime5.Name = "BlipTime5";
            this.BlipTime5.Size = new System.Drawing.Size(60, 24);
            this.BlipTime5.TabIndex = 72;
            this.BlipTime5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime5.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelDS3
            // 
            this.LabelDS3.AutoSize = true;
            this.LabelDS3.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS3.Location = new System.Drawing.Point(44, 108);
            this.LabelDS3.Name = "LabelDS3";
            this.LabelDS3.Size = new System.Drawing.Size(40, 18);
            this.LabelDS3.TabIndex = 37;
            this.LabelDS3.Text = "4000";
            this.LabelDS3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS3, "Blip time at 4000RPM.");
            // 
            // BlipTime4
            // 
            this.BlipTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime4.Location = new System.Drawing.Point(142, 185);
            this.BlipTime4.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime4.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime4.Name = "BlipTime4";
            this.BlipTime4.Size = new System.Drawing.Size(60, 24);
            this.BlipTime4.TabIndex = 71;
            this.BlipTime4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime4.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // DSForce
            // 
            this.DSForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DSForce.Location = new System.Drawing.Point(390, 62);
            this.DSForce.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.DSForce.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DSForce.Name = "DSForce";
            this.DSForce.Size = new System.Drawing.Size(60, 24);
            this.DSForce.TabIndex = 54;
            this.DSForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DSForce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelDS4
            // 
            this.LabelDS4.AutoSize = true;
            this.LabelDS4.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS4.Location = new System.Drawing.Point(44, 148);
            this.LabelDS4.Name = "LabelDS4";
            this.LabelDS4.Size = new System.Drawing.Size(40, 18);
            this.LabelDS4.TabIndex = 38;
            this.LabelDS4.Text = "6000";
            this.LabelDS4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS4, "Blip time at 6000RPM.");
            // 
            // BlipTime3
            // 
            this.BlipTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime3.Location = new System.Drawing.Point(142, 145);
            this.BlipTime3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime3.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime3.Name = "BlipTime3";
            this.BlipTime3.Size = new System.Drawing.Size(60, 24);
            this.BlipTime3.TabIndex = 70;
            this.BlipTime3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelDS5
            // 
            this.LabelDS5.AutoSize = true;
            this.LabelDS5.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS5.Location = new System.Drawing.Point(44, 188);
            this.LabelDS5.Name = "LabelDS5";
            this.LabelDS5.Size = new System.Drawing.Size(40, 18);
            this.LabelDS5.TabIndex = 39;
            this.LabelDS5.Text = "8000";
            this.LabelDS5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS5, "Blip time at 8000RPM.");
            // 
            // BlipTime2
            // 
            this.BlipTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime2.Location = new System.Drawing.Point(142, 105);
            this.BlipTime2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime2.Name = "BlipTime2";
            this.BlipTime2.Size = new System.Drawing.Size(60, 24);
            this.BlipTime2.TabIndex = 69;
            this.BlipTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelDS6
            // 
            this.LabelDS6.AutoSize = true;
            this.LabelDS6.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS6.Location = new System.Drawing.Point(39, 228);
            this.LabelDS6.Name = "LabelDS6";
            this.LabelDS6.Size = new System.Drawing.Size(48, 18);
            this.LabelDS6.TabIndex = 40;
            this.LabelDS6.Text = "10000";
            this.LabelDS6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS6, "Blip time at 10000RPM.");
            // 
            // BlipTime1
            // 
            this.BlipTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlipTime1.Location = new System.Drawing.Point(142, 65);
            this.BlipTime1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlipTime1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BlipTime1.Name = "BlipTime1";
            this.BlipTime1.Size = new System.Drawing.Size(60, 24);
            this.BlipTime1.TabIndex = 68;
            this.BlipTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlipTime1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LabelDS7
            // 
            this.LabelDS7.AutoSize = true;
            this.LabelDS7.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS7.Location = new System.Drawing.Point(39, 268);
            this.LabelDS7.Name = "LabelDS7";
            this.LabelDS7.Size = new System.Drawing.Size(48, 18);
            this.LabelDS7.TabIndex = 41;
            this.LabelDS7.Text = "12000";
            this.LabelDS7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS7, "Blip time at 12000RPM.");
            // 
            // PreDelayDS
            // 
            this.PreDelayDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreDelayDS.Location = new System.Drawing.Point(390, 182);
            this.PreDelayDS.Name = "PreDelayDS";
            this.PreDelayDS.Size = new System.Drawing.Size(60, 24);
            this.PreDelayDS.TabIndex = 67;
            this.PreDelayDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelDS8
            // 
            this.LabelDS8.AutoSize = true;
            this.LabelDS8.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS8.Location = new System.Drawing.Point(39, 308);
            this.LabelDS8.Name = "LabelDS8";
            this.LabelDS8.Size = new System.Drawing.Size(48, 18);
            this.LabelDS8.TabIndex = 42;
            this.LabelDS8.Text = "14000";
            this.LabelDS8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS8, "Blip time at 14000RPM.");
            // 
            // LabelDS9
            // 
            this.LabelDS9.AutoSize = true;
            this.LabelDS9.BackColor = System.Drawing.Color.Transparent;
            this.LabelDS9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelDS9.Location = new System.Drawing.Point(34, 348);
            this.LabelDS9.Name = "LabelDS9";
            this.LabelDS9.Size = new System.Drawing.Size(61, 18);
            this.LabelDS9.TabIndex = 43;
            this.LabelDS9.Text = "> 16000";
            this.LabelDS9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tips.SetToolTip(this.LabelDS9, "Blip time above 16000RPM.");
            // 
            // LabelSensorReading
            // 
            this.LabelSensorReading.AutoSize = true;
            this.LabelSensorReading.BackColor = System.Drawing.Color.Transparent;
            this.LabelSensorReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSensorReading.Location = new System.Drawing.Point(710, 510);
            this.LabelSensorReading.Name = "LabelSensorReading";
            this.LabelSensorReading.Size = new System.Drawing.Size(16, 18);
            this.LabelSensorReading.TabIndex = 108;
            this.LabelSensorReading.Text = "0";
            this.Tips.SetToolTip(this.LabelSensorReading, "Shift sensor output value.");
            // 
            // ProgressBarSensor
            // 
            this.ProgressBarSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBarSensor.Cursor = System.Windows.Forms.Cursors.No;
            this.ProgressBarSensor.ForeColor = System.Drawing.Color.Red;
            this.ProgressBarSensor.Location = new System.Drawing.Point(24, 539);
            this.ProgressBarSensor.Maximum = 4000;
            this.ProgressBarSensor.Name = "ProgressBarSensor";
            this.ProgressBarSensor.Size = new System.Drawing.Size(736, 16);
            this.ProgressBarSensor.Step = 1;
            this.ProgressBarSensor.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarSensor.TabIndex = 107;
            this.Tips.SetToolTip(this.ProgressBarSensor, "Sensor values on stripe.");
            this.ProgressBarSensor.Value = 2000;
            // 
            // LabelSensorOutput
            // 
            this.LabelSensorOutput.AutoSize = true;
            this.LabelSensorOutput.BackColor = System.Drawing.Color.Transparent;
            this.LabelSensorOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSensorOutput.Location = new System.Drawing.Point(570, 510);
            this.LabelSensorOutput.Name = "LabelSensorOutput";
            this.LabelSensorOutput.Size = new System.Drawing.Size(101, 18);
            this.LabelSensorOutput.TabIndex = 104;
            this.LabelSensorOutput.Text = "Sensor output";
            this.Tips.SetToolTip(this.LabelSensorOutput, "Shift sensor output values. Shows if sensor is pulled or pushed.");
            // 
            // Tips
            // 
            this.Tips.ShowAlways = true;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Location = new System.Drawing.Point(704, 7);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(68, 13);
            this.LabelVersion.TabIndex = 109;
            this.LabelVersion.Text = "LabelVersion";
            this.Tips.SetToolTip(this.LabelVersion, "Version of module.");
            this.LabelVersion.Click += new System.EventHandler(this.LabelVersion_Click);
            // 
            // LabelSensorDirection
            // 
            this.LabelSensorDirection.AutoSize = true;
            this.LabelSensorDirection.BackColor = System.Drawing.Color.Transparent;
            this.LabelSensorDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSensorDirection.Location = new System.Drawing.Point(700, 480);
            this.LabelSensorDirection.Name = "LabelSensorDirection";
            this.LabelSensorDirection.Size = new System.Drawing.Size(13, 18);
            this.LabelSensorDirection.TabIndex = 110;
            this.LabelSensorDirection.Text = "-";
            this.Tips.SetToolTip(this.LabelSensorDirection, "Shows if sensor is pushed or pulled.");
            // 
            // Refresh_BTN
            // 
            this.Refresh_BTN.BackgroundImage = global::QS_DS_Program.Properties.Resources.refresh;
            this.Refresh_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_BTN.Location = new System.Drawing.Point(170, 30);
            this.Refresh_BTN.Name = "Refresh_BTN";
            this.Refresh_BTN.Size = new System.Drawing.Size(25, 25);
            this.Refresh_BTN.TabIndex = 105;
            this.Tips.SetToolTip(this.Refresh_BTN, "Press to refresh available COM ports list.");
            this.Refresh_BTN.UseVisualStyleBackColor = true;
            this.Refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            // 
            // QS_DS_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LabelSensorDirection);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelSensorReading);
            this.Controls.Add(this.ProgressBarSensor);
            this.Controls.Add(this.Refresh_BTN);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.RPMRead);
            this.Controls.Add(this.Reset_BTN);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.Read_BTN);
            this.Controls.Add(this.LabelSensorOutput);
            this.Controls.Add(this.LabelRPMCur);
            this.Controls.Add(this.Connect_BTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tabs_All);
            this.DoubleBuffered = true;
            this.Name = "QS_DS_Program";
            this.ShowIcon = false;
            this.Text = "QS_DS_Program";
            this.Load += new System.EventHandler(this.QS_DS_Program_Load);
            this.Tabs_All.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pulses)).EndInit();
            this.QSPage.ResumeLayout(false);
            this.QSPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDelayQS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRPMQS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QSForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayQS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CutTime1)).EndInit();
            this.DSPage.ResumeLayout(false);
            this.DSPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDelayDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRPMDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRPMDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlipTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreDelayDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refresh_BTN;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label RPMRead;
        private System.Windows.Forms.Button Reset_BTN;
        private System.Windows.Forms.Button Save_BTN;
        private System.Windows.Forms.Button Read_BTN;
        private System.Windows.Forms.Label LabelRPMCur;
        private System.Windows.Forms.Button Connect_BTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl Tabs_All;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.NumericUpDown Pulses;
        private System.Windows.Forms.Label LabelGeneral1;
        private System.Windows.Forms.TabPage QSPage;
        private System.Windows.Forms.CheckBox Push_Check_QS;
        private System.Windows.Forms.Button CutTest_BTN;
        private System.Windows.Forms.Label LabelQS1;
        private System.Windows.Forms.Label LabelQS2;
        private System.Windows.Forms.Label LabelQS3;
        private System.Windows.Forms.Label LabelQS4;
        private System.Windows.Forms.Label LabelQS11;
        private System.Windows.Forms.Label LabelQS10;
        private System.Windows.Forms.Label LabelQS5;
        private System.Windows.Forms.NumericUpDown MinRPMQS;
        private System.Windows.Forms.NumericUpDown CutTime8;
        private System.Windows.Forms.Label LabelQS6;
        private System.Windows.Forms.NumericUpDown CutTime7;
        private System.Windows.Forms.Label LabelQS7;
        private System.Windows.Forms.NumericUpDown CutTime6;
        private System.Windows.Forms.Label LabelQS8;
        private System.Windows.Forms.NumericUpDown QSForce;
        private System.Windows.Forms.NumericUpDown CutTime5;
        private System.Windows.Forms.Label LabelQS9;
        private System.Windows.Forms.NumericUpDown CutTime4;
        private System.Windows.Forms.CheckBox QSEnable_Check;
        private System.Windows.Forms.NumericUpDown CutTime3;
        private System.Windows.Forms.NumericUpDown PreDelayQS;
        private System.Windows.Forms.NumericUpDown CutTime2;
        private System.Windows.Forms.NumericUpDown CutTime1;
        private System.Windows.Forms.CheckBox Pull_Check_QS;
        private System.Windows.Forms.TabPage DSPage;
        private System.Windows.Forms.CheckBox Pull_Check_DS;
        private System.Windows.Forms.CheckBox Push_Check_DS;
        private System.Windows.Forms.NumericUpDown MaxRPMDS;
        private System.Windows.Forms.Label LabelDS12;
        private System.Windows.Forms.Label LabelDS2;
        private System.Windows.Forms.Label LabelDS10;
        private System.Windows.Forms.Label LabelDS11;
        private System.Windows.Forms.NumericUpDown BlipTime7;
        private System.Windows.Forms.NumericUpDown MinRPMDS;
        private System.Windows.Forms.Label LabelDS1;
        private System.Windows.Forms.NumericUpDown BlipTime8;
        private System.Windows.Forms.CheckBox DSEnable_Check;
        private System.Windows.Forms.NumericUpDown BlipTime6;
        private System.Windows.Forms.Button BlipTest_BTN;
        private System.Windows.Forms.NumericUpDown BlipTime5;
        private System.Windows.Forms.Label LabelDS3;
        private System.Windows.Forms.NumericUpDown BlipTime4;
        private System.Windows.Forms.NumericUpDown DSForce;
        private System.Windows.Forms.Label LabelDS4;
        private System.Windows.Forms.NumericUpDown BlipTime3;
        private System.Windows.Forms.Label LabelDS5;
        private System.Windows.Forms.NumericUpDown BlipTime2;
        private System.Windows.Forms.Label LabelDS6;
        private System.Windows.Forms.NumericUpDown BlipTime1;
        private System.Windows.Forms.Label LabelDS7;
        private System.Windows.Forms.NumericUpDown PreDelayDS;
        private System.Windows.Forms.Label LabelDS8;
        private System.Windows.Forms.Label LabelDS9;
        private System.Windows.Forms.Label LabelCutTime;
        private System.Windows.Forms.Label LabelSensorReading;
        private System.Windows.Forms.ProgressBar ProgressBarSensor;
        private System.Windows.Forms.Label LabelSensorOutput;
        private System.Windows.Forms.ToolTip Tips;
        private System.IO.Ports.SerialPort MainSerialPort;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelSensorDirection;
        private System.Windows.Forms.NumericUpDown PostDelayQS;
        private System.Windows.Forms.Label LabelQS12;
        private System.Windows.Forms.Label LabelDS13;
        private System.Windows.Forms.NumericUpDown PostDelayDS;
    }
}