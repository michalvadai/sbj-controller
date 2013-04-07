﻿namespace SBJController
{
    partial class SBJControllerMainForm
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
            this.obtainShortCircuitBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.controllerTabControl = new System.Windows.Forms.TabControl();
            this.dataAquisitionTabPage = new System.Windows.Forms.TabPage();
            this.plotGroupBox = new System.Windows.Forms.GroupBox();
            this.channelsListView = new System.Windows.Forms.ListView();
            this.operateGroupBox = new System.Windows.Forms.GroupBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.fixBiasCheckBoxButton = new System.Windows.Forms.CheckBox();
            this.ivStartCyclesCheckBox = new System.Windows.Forms.CheckBox();
            this.moveUpCheckBoxButton = new System.Windows.Forms.CheckBox();
            this.startStopCheckBoxButton = new System.Windows.Forms.CheckBox();
            this.shortCircuitCheckBoxButton = new System.Windows.Forms.CheckBox();
            this.numberOfCyclesnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfCyclesLabel1 = new System.Windows.Forms.Label();
            this.shortCircuitVoltageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.shortCircuitVoltageLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileSavingCheckBox = new System.Windows.Forms.CheckBox();
            this.fileNumberLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.fileNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.traceWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.samplePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.openLogBookButton = new System.Windows.Forms.Button();
            this.saveSamplesParamsButton = new System.Windows.Forms.Button();
            this.samplePropertiesTabControl = new System.Windows.Forms.TabControl();
            this.bottomTabPage = new System.Windows.Forms.TabPage();
            this.bottomPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.TopTabPage = new System.Windows.Forms.TabPage();
            this.topPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.generalSettingsTabPage = new System.Windows.Forms.TabPage();
            this.generalSettingsPanel = new System.Windows.Forms.Panel();
            this.useKeithleyCheckBox = new System.Windows.Forms.CheckBox();
            this.biasErrorNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.biasErrorLabel = new System.Windows.Forms.Label();
            this.gainComboBox = new System.Windows.Forms.ComboBox();
            this.stepperWaitTime2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepperWaitTime2Label = new System.Windows.Forms.Label();
            this.pretriggerSamplesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pretriggerSamplesLabel = new System.Windows.Forms.Label();
            this.sampleRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalSamplesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalSamplesLabel = new System.Windows.Forms.Label();
            this.triggerVoltageNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.triggerVoltageLabel = new System.Windows.Forms.Label();
            this.triggerConductanceNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.triggerConductanceLabel = new System.Windows.Forms.Label();
            this.sampleRateLabel = new System.Windows.Forms.Label();
            this.stepperWaitTime1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepperWaitTime1Label = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.biasNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.biasLabel = new System.Windows.Forms.Label();
            this.laserSettingsTabPage = new System.Windows.Forms.TabPage();
            this.laserSettingsPanel = new System.Windows.Forms.Panel();
            this.laserModeComboBox = new System.Windows.Forms.ComboBox();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enableLaserCheckBox = new System.Windows.Forms.CheckBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.amplitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.laserAmplitudeLabel = new System.Windows.Forms.Label();
            this.LockInSettingsTabPage = new System.Windows.Forms.TabPage();
            this.lockInPanel = new System.Windows.Forms.Panel();
            this.rollOffComboBox = new System.Windows.Forms.ComboBox();
            this.rollOffLabel = new System.Windows.Forms.Label();
            this.enableLockInCheckBox = new System.Windows.Forms.CheckBox();
            this.timeConstantComboBox = new System.Windows.Forms.ComboBox();
            this.timeConstantLabel = new System.Windows.Forms.Label();
            this.sensitivityComboBox = new System.Windows.Forms.ComboBox();
            this.internalSourceLockInGroupBox = new System.Windows.Forms.GroupBox();
            this.mixerReductionFactorNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.acVoltageReductionFactorLabel = new System.Windows.Forms.Label();
            this.internalSourceLockInCheckBoxcheckBox = new System.Windows.Forms.CheckBox();
            this.lockInAcVoltageNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.lockInAcVoltageLabel = new System.Windows.Forms.Label();
            this.lockInSensitivityLabel = new System.Windows.Forms.Label();
            this.ElectroMagnetTabPage = new System.Windows.Forms.TabPage();
            this.electroMagnetSettingsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emHoldOnMinVoltageNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.emHoldOnMinVoltageLabel = new System.Windows.Forms.Label();
            this.emHoldOnMinConductanceLabel = new System.Windows.Forms.Label();
            this.emHoldOnMinConductanceNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.emHoldOnMaxVoltageNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.emHoldOnMaxVoltageLabel = new System.Windows.Forms.Label();
            this.emHoldOnMaxConductanceLabel = new System.Windows.Forms.Label();
            this.emHoldOnMaxConductanceNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.emHoldOnToConductanceRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.emSkipFirstCycleByStepperMotorCheckBox = new System.Windows.Forms.CheckBox();
            this.emShortCircuitDelayTimeLabel = new System.Windows.Forms.Label();
            this.emShortCircuitDelayTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.emSlowDelayTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.emSlowDelayTimeLabel = new System.Windows.Forms.Label();
            this.emFastDelayTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enableElectroMagnetCheckBox = new System.Windows.Forms.CheckBox();
            this.emFastDelayTimeLabel = new System.Windows.Forms.Label();
            this.channelsConfigurationTabPage = new System.Windows.Forms.TabPage();
            this.channelsSettingsPanel = new System.Windows.Forms.Panel();
            this.channel1ComboBox = new System.Windows.Forms.ComboBox();
            this.channel3ComboBox = new System.Windows.Forms.ComboBox();
            this.channel0CheckBox = new System.Windows.Forms.CheckBox();
            this.channel3CheckBox = new System.Windows.Forms.CheckBox();
            this.channel0ComboBox = new System.Windows.Forms.ComboBox();
            this.channel2ComboBox = new System.Windows.Forms.ComboBox();
            this.channel1CheckBox = new System.Windows.Forms.CheckBox();
            this.channel2CheckBox = new System.Windows.Forms.CheckBox();
            this.ivCurvesTabPage = new System.Windows.Forms.TabPage();
            this.ivCurvesPanel = new System.Windows.Forms.Panel();
            this.ivTimeOfOneCycleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.ivVoltageForTheDisplayedTraceNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ivSampleRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ivAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.ivSampleDelayNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.ivSamplesPerCycleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.controlPanelsTabPage = new System.Windows.Forms.TabPage();
            this.electroMagnetGroupBox = new System.Windows.Forms.GroupBox();
            this.electroMagnetUserControl2 = new ElectroMagnetUserControl();
            this.stepperMotorGroupBox = new System.Windows.Forms.GroupBox();
            this.stepperMotorUserControl1 = new StepperMotorUserControl();
            this.aquireDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.stepperUpBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.fixBiasBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ivCyclesBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.controllerTabControl.SuspendLayout();
            this.dataAquisitionTabPage.SuspendLayout();
            this.plotGroupBox.SuspendLayout();
            this.operateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCyclesnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortCircuitVoltageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceWaveformGraph)).BeginInit();
            this.samplePropertiesGroupBox.SuspendLayout();
            this.samplePropertiesTabControl.SuspendLayout();
            this.bottomTabPage.SuspendLayout();
            this.TopTabPage.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.SettingsTabControl.SuspendLayout();
            this.generalSettingsTabPage.SuspendLayout();
            this.generalSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biasErrorNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepperWaitTime2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretriggerSamplesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSamplesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerVoltageNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerConductanceNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepperWaitTime1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biasNumericEdit)).BeginInit();
            this.laserSettingsTabPage.SuspendLayout();
            this.laserSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).BeginInit();
            this.LockInSettingsTabPage.SuspendLayout();
            this.lockInPanel.SuspendLayout();
            this.internalSourceLockInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mixerReductionFactorNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockInAcVoltageNumericEdit)).BeginInit();
            this.ElectroMagnetTabPage.SuspendLayout();
            this.electroMagnetSettingsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMinVoltageNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMinConductanceNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMaxVoltageNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMaxConductanceNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emShortCircuitDelayTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emSlowDelayTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emFastDelayTimeNumericUpDown)).BeginInit();
            this.channelsConfigurationTabPage.SuspendLayout();
            this.channelsSettingsPanel.SuspendLayout();
            this.ivCurvesTabPage.SuspendLayout();
            this.ivCurvesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ivTimeOfOneCycleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivVoltageForTheDisplayedTraceNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSampleRateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSampleDelayNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSamplesPerCycleNumericEdit)).BeginInit();
            this.controlPanelsTabPage.SuspendLayout();
            this.electroMagnetGroupBox.SuspendLayout();
            this.stepperMotorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // obtainShortCircuitBackgroundWorker
            // 
            this.obtainShortCircuitBackgroundWorker.WorkerReportsProgress = true;
            this.obtainShortCircuitBackgroundWorker.WorkerSupportsCancellation = true;
            this.obtainShortCircuitBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.obtainShortCircuitBackgroundWorker_DoWork);
            this.obtainShortCircuitBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.obtainSHortCircuitBackgroundWorker_RunWorkerCompleted);
            // 
            // controllerTabControl
            // 
            this.controllerTabControl.Controls.Add(this.dataAquisitionTabPage);
            this.controllerTabControl.Controls.Add(this.controlPanelsTabPage);
            this.controllerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerTabControl.Location = new System.Drawing.Point(0, 0);
            this.controllerTabControl.Name = "controllerTabControl";
            this.controllerTabControl.SelectedIndex = 0;
            this.controllerTabControl.Size = new System.Drawing.Size(749, 824);
            this.controllerTabControl.TabIndex = 2;
            this.controllerTabControl.Tag = "";
            this.controllerTabControl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.controllerTabControl_Deselected);
            // 
            // dataAquisitionTabPage
            // 
            this.dataAquisitionTabPage.AutoScroll = true;
            this.dataAquisitionTabPage.Controls.Add(this.plotGroupBox);
            this.dataAquisitionTabPage.Controls.Add(this.operateGroupBox);
            this.dataAquisitionTabPage.Controls.Add(this.traceWaveformGraph);
            this.dataAquisitionTabPage.Controls.Add(this.samplePropertiesGroupBox);
            this.dataAquisitionTabPage.Controls.Add(this.settingsGroupBox);
            this.dataAquisitionTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataAquisitionTabPage.Name = "dataAquisitionTabPage";
            this.dataAquisitionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataAquisitionTabPage.Size = new System.Drawing.Size(741, 798);
            this.dataAquisitionTabPage.TabIndex = 0;
            this.dataAquisitionTabPage.Text = "DAQ";
            this.dataAquisitionTabPage.UseVisualStyleBackColor = true;
            // 
            // plotGroupBox
            // 
            this.plotGroupBox.Controls.Add(this.channelsListView);
            this.plotGroupBox.ForeColor = System.Drawing.Color.Red;
            this.plotGroupBox.Location = new System.Drawing.Point(494, 16);
            this.plotGroupBox.Name = "plotGroupBox";
            this.plotGroupBox.Size = new System.Drawing.Size(235, 339);
            this.plotGroupBox.TabIndex = 25;
            this.plotGroupBox.TabStop = false;
            this.plotGroupBox.Text = "Plots";
            // 
            // channelsListView
            // 
            this.channelsListView.CheckBoxes = true;
            this.channelsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelsListView.Location = new System.Drawing.Point(3, 16);
            this.channelsListView.Name = "channelsListView";
            this.channelsListView.Size = new System.Drawing.Size(229, 320);
            this.channelsListView.TabIndex = 25;
            this.channelsListView.UseCompatibleStateImageBehavior = false;
            this.channelsListView.View = System.Windows.Forms.View.List;
            this.channelsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.channelsListView_ItemChecked);
            this.channelsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.channelsListView_ItemSelectionChanged);
            // 
            // operateGroupBox
            // 
            this.operateGroupBox.AutoSize = true;
            this.operateGroupBox.Controls.Add(this.openFolderButton);
            this.operateGroupBox.Controls.Add(this.fixBiasCheckBoxButton);
            this.operateGroupBox.Controls.Add(this.ivStartCyclesCheckBox);
            this.operateGroupBox.Controls.Add(this.moveUpCheckBoxButton);
            this.operateGroupBox.Controls.Add(this.startStopCheckBoxButton);
            this.operateGroupBox.Controls.Add(this.shortCircuitCheckBoxButton);
            this.operateGroupBox.Controls.Add(this.numberOfCyclesnumericUpDown);
            this.operateGroupBox.Controls.Add(this.numberOfCyclesLabel1);
            this.operateGroupBox.Controls.Add(this.shortCircuitVoltageNumericUpDown);
            this.operateGroupBox.Controls.Add(this.shortCircuitVoltageLabel);
            this.operateGroupBox.Controls.Add(this.pathTextBox);
            this.operateGroupBox.Controls.Add(this.browseButton);
            this.operateGroupBox.Controls.Add(this.fileSavingCheckBox);
            this.operateGroupBox.Controls.Add(this.fileNumberLabel);
            this.operateGroupBox.Controls.Add(this.pathLabel);
            this.operateGroupBox.Controls.Add(this.fileNumberNumericUpDown);
            this.operateGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operateGroupBox.ForeColor = System.Drawing.Color.Red;
            this.operateGroupBox.Location = new System.Drawing.Point(3, 611);
            this.operateGroupBox.MinimumSize = new System.Drawing.Size(478, 176);
            this.operateGroupBox.Name = "operateGroupBox";
            this.operateGroupBox.Size = new System.Drawing.Size(735, 184);
            this.operateGroupBox.TabIndex = 23;
            this.operateGroupBox.TabStop = false;
            this.operateGroupBox.Text = "Operate";
            // 
            // openFolderButton
            // 
            this.openFolderButton.ForeColor = System.Drawing.Color.Black;
            this.openFolderButton.Location = new System.Drawing.Point(530, 44);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(74, 23);
            this.openFolderButton.TabIndex = 29;
            this.openFolderButton.Text = "Open Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // fixBiasCheckBoxButton
            // 
            this.fixBiasCheckBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fixBiasCheckBoxButton.AutoSize = true;
            this.fixBiasCheckBoxButton.ForeColor = System.Drawing.Color.Black;
            this.fixBiasCheckBoxButton.Location = new System.Drawing.Point(365, 108);
            this.fixBiasCheckBoxButton.MinimumSize = new System.Drawing.Size(74, 23);
            this.fixBiasCheckBoxButton.Name = "fixBiasCheckBoxButton";
            this.fixBiasCheckBoxButton.Size = new System.Drawing.Size(74, 23);
            this.fixBiasCheckBoxButton.TabIndex = 18;
            this.fixBiasCheckBoxButton.Text = "Fix Bias";
            this.fixBiasCheckBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fixBiasCheckBoxButton.UseVisualStyleBackColor = true;
            this.fixBiasCheckBoxButton.CheckedChanged += new System.EventHandler(this.fixBiasCheckBoxButton_CheckedChanged);
            // 
            // ivStartCyclesCheckBox
            // 
            this.ivStartCyclesCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ivStartCyclesCheckBox.AutoSize = true;
            this.ivStartCyclesCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ivStartCyclesCheckBox.Location = new System.Drawing.Point(456, 142);
            this.ivStartCyclesCheckBox.MinimumSize = new System.Drawing.Size(74, 23);
            this.ivStartCyclesCheckBox.Name = "ivStartCyclesCheckBox";
            this.ivStartCyclesCheckBox.Size = new System.Drawing.Size(86, 23);
            this.ivStartCyclesCheckBox.TabIndex = 28;
            this.ivStartCyclesCheckBox.Text = "Start IV Cycles";
            this.ivStartCyclesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ivStartCyclesCheckBox.UseVisualStyleBackColor = true;
            this.ivStartCyclesCheckBox.CheckedChanged += new System.EventHandler(this.ivStartCyclesCheckBox_CheckedChanged);
            // 
            // moveUpCheckBoxButton
            // 
            this.moveUpCheckBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.moveUpCheckBoxButton.AutoSize = true;
            this.moveUpCheckBoxButton.ForeColor = System.Drawing.Color.Black;
            this.moveUpCheckBoxButton.Location = new System.Drawing.Point(365, 142);
            this.moveUpCheckBoxButton.MinimumSize = new System.Drawing.Size(74, 23);
            this.moveUpCheckBoxButton.Name = "moveUpCheckBoxButton";
            this.moveUpCheckBoxButton.Size = new System.Drawing.Size(74, 23);
            this.moveUpCheckBoxButton.TabIndex = 17;
            this.moveUpCheckBoxButton.Text = "Stepper Up";
            this.moveUpCheckBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveUpCheckBoxButton.UseVisualStyleBackColor = true;
            this.moveUpCheckBoxButton.Click += new System.EventHandler(this.moveUpCheckBox_CheckedChanged);
            // 
            // startStopCheckBoxButton
            // 
            this.startStopCheckBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.startStopCheckBoxButton.AutoSize = true;
            this.startStopCheckBoxButton.ForeColor = System.Drawing.Color.Black;
            this.startStopCheckBoxButton.Location = new System.Drawing.Point(273, 108);
            this.startStopCheckBoxButton.MinimumSize = new System.Drawing.Size(74, 23);
            this.startStopCheckBoxButton.Name = "startStopCheckBoxButton";
            this.startStopCheckBoxButton.Size = new System.Drawing.Size(74, 23);
            this.startStopCheckBoxButton.TabIndex = 16;
            this.startStopCheckBoxButton.Text = "Start";
            this.startStopCheckBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startStopCheckBoxButton.UseVisualStyleBackColor = true;
            this.startStopCheckBoxButton.Click += new System.EventHandler(this.startStopButton_CheckedChanged);
            // 
            // shortCircuitCheckBoxButton
            // 
            this.shortCircuitCheckBoxButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.shortCircuitCheckBoxButton.AutoSize = true;
            this.shortCircuitCheckBoxButton.ForeColor = System.Drawing.Color.Black;
            this.shortCircuitCheckBoxButton.Location = new System.Drawing.Point(273, 142);
            this.shortCircuitCheckBoxButton.MinimumSize = new System.Drawing.Size(74, 23);
            this.shortCircuitCheckBoxButton.Name = "shortCircuitCheckBoxButton";
            this.shortCircuitCheckBoxButton.Size = new System.Drawing.Size(74, 23);
            this.shortCircuitCheckBoxButton.TabIndex = 15;
            this.shortCircuitCheckBoxButton.Text = "Short Circuit";
            this.shortCircuitCheckBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shortCircuitCheckBoxButton.UseVisualStyleBackColor = true;
            this.shortCircuitCheckBoxButton.Click += new System.EventHandler(this.shortCircuitButton_CheckedChanged);
            // 
            // numberOfCyclesnumericUpDown
            // 
            this.numberOfCyclesnumericUpDown.Location = new System.Drawing.Point(150, 111);
            this.numberOfCyclesnumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfCyclesnumericUpDown.Name = "numberOfCyclesnumericUpDown";
            this.numberOfCyclesnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.numberOfCyclesnumericUpDown.TabIndex = 14;
            this.numberOfCyclesnumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numberOfCyclesLabel1
            // 
            this.numberOfCyclesLabel1.AutoSize = true;
            this.numberOfCyclesLabel1.ForeColor = System.Drawing.Color.Black;
            this.numberOfCyclesLabel1.Location = new System.Drawing.Point(7, 113);
            this.numberOfCyclesLabel1.Name = "numberOfCyclesLabel1";
            this.numberOfCyclesLabel1.Size = new System.Drawing.Size(90, 13);
            this.numberOfCyclesLabel1.TabIndex = 13;
            this.numberOfCyclesLabel1.Text = "Number of Cycles";
            // 
            // shortCircuitVoltageNumericUpDown
            // 
            this.shortCircuitVoltageNumericUpDown.DecimalPlaces = 1;
            this.shortCircuitVoltageNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.shortCircuitVoltageNumericUpDown.Location = new System.Drawing.Point(150, 145);
            this.shortCircuitVoltageNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.shortCircuitVoltageNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.shortCircuitVoltageNumericUpDown.Name = "shortCircuitVoltageNumericUpDown";
            this.shortCircuitVoltageNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.shortCircuitVoltageNumericUpDown.TabIndex = 12;
            this.shortCircuitVoltageNumericUpDown.Value = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            // 
            // shortCircuitVoltageLabel
            // 
            this.shortCircuitVoltageLabel.AutoSize = true;
            this.shortCircuitVoltageLabel.ForeColor = System.Drawing.Color.Black;
            this.shortCircuitVoltageLabel.Location = new System.Drawing.Point(7, 147);
            this.shortCircuitVoltageLabel.Name = "shortCircuitVoltageLabel";
            this.shortCircuitVoltageLabel.Size = new System.Drawing.Size(119, 13);
            this.shortCircuitVoltageLabel.TabIndex = 11;
            this.shortCircuitVoltageLabel.Text = "Short Circuit Voltage [V]";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(39, 46);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(400, 20);
            this.pathTextBox.TabIndex = 9;
            this.pathTextBox.Text = "C:\\sbj\\Measurements";
            this.pathTextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(450, 44);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(74, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileSavingCheckBox
            // 
            this.fileSavingCheckBox.AutoSize = true;
            this.fileSavingCheckBox.ForeColor = System.Drawing.Color.Black;
            this.fileSavingCheckBox.Location = new System.Drawing.Point(10, 23);
            this.fileSavingCheckBox.Name = "fileSavingCheckBox";
            this.fileSavingCheckBox.Size = new System.Drawing.Size(78, 17);
            this.fileSavingCheckBox.TabIndex = 5;
            this.fileSavingCheckBox.Text = "File Saving";
            this.fileSavingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileNumberLabel
            // 
            this.fileNumberLabel.AutoSize = true;
            this.fileNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.fileNumberLabel.Location = new System.Drawing.Point(7, 79);
            this.fileNumberLabel.Name = "fileNumberLabel";
            this.fileNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.fileNumberLabel.TabIndex = 6;
            this.fileNumberLabel.Text = "File Number";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.ForeColor = System.Drawing.Color.Black;
            this.pathLabel.Location = new System.Drawing.Point(7, 49);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 8;
            this.pathLabel.Text = "Path";
            // 
            // fileNumberNumericUpDown
            // 
            this.fileNumberNumericUpDown.Location = new System.Drawing.Point(150, 77);
            this.fileNumberNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fileNumberNumericUpDown.Name = "fileNumberNumericUpDown";
            this.fileNumberNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.fileNumberNumericUpDown.TabIndex = 7;
            // 
            // traceWaveformGraph
            // 
            this.traceWaveformGraph.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.traceWaveformGraph.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traceWaveformGraph.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.traceWaveformGraph.InteractionMode = ((NationalInstruments.UI.GraphInteractionModes)((((((((NationalInstruments.UI.GraphInteractionModes.ZoomX | NationalInstruments.UI.GraphInteractionModes.ZoomY) 
            | NationalInstruments.UI.GraphInteractionModes.ZoomAroundPoint) 
            | NationalInstruments.UI.GraphInteractionModes.PanX) 
            | NationalInstruments.UI.GraphInteractionModes.PanY) 
            | NationalInstruments.UI.GraphInteractionModes.DragCursor) 
            | NationalInstruments.UI.GraphInteractionModes.DragAnnotationCaption) 
            | NationalInstruments.UI.GraphInteractionModes.EditRange)));
            this.traceWaveformGraph.Location = new System.Drawing.Point(21, 16);
            this.traceWaveformGraph.Name = "traceWaveformGraph";
            this.traceWaveformGraph.PlotAreaColor = System.Drawing.Color.LightGray;
            this.traceWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.traceWaveformGraph.Size = new System.Drawing.Size(467, 339);
            this.traceWaveformGraph.TabIndex = 21;
            this.traceWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.traceWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1,
            this.yAxis2});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.LineColor = System.Drawing.Color.Red;
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.ToolTipsEnabled = true;
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Time [sec E-4]";
            this.xAxis1.Range = new NationalInstruments.UI.Range(0D, 10000D);
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Conductance [G0]";
            // 
            // yAxis2
            // 
            this.yAxis2.Caption = "LockIn Signal";
            this.yAxis2.CaptionPosition = NationalInstruments.UI.YAxisPosition.Right;
            this.yAxis2.Position = NationalInstruments.UI.YAxisPosition.Right;
            this.yAxis2.Range = new NationalInstruments.UI.Range(-10D, 10D);
            // 
            // samplePropertiesGroupBox
            // 
            this.samplePropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.samplePropertiesGroupBox.AutoSize = true;
            this.samplePropertiesGroupBox.Controls.Add(this.openLogBookButton);
            this.samplePropertiesGroupBox.Controls.Add(this.saveSamplesParamsButton);
            this.samplePropertiesGroupBox.Controls.Add(this.samplePropertiesTabControl);
            this.samplePropertiesGroupBox.ForeColor = System.Drawing.Color.Red;
            this.samplePropertiesGroupBox.Location = new System.Drawing.Point(546, 364);
            this.samplePropertiesGroupBox.Name = "samplePropertiesGroupBox";
            this.samplePropertiesGroupBox.Size = new System.Drawing.Size(178, 247);
            this.samplePropertiesGroupBox.TabIndex = 20;
            this.samplePropertiesGroupBox.TabStop = false;
            this.samplePropertiesGroupBox.Text = "Sample Properties";
            // 
            // openLogBookButton
            // 
            this.openLogBookButton.ForeColor = System.Drawing.Color.Black;
            this.openLogBookButton.Location = new System.Drawing.Point(86, 205);
            this.openLogBookButton.Name = "openLogBookButton";
            this.openLogBookButton.Size = new System.Drawing.Size(74, 23);
            this.openLogBookButton.TabIndex = 19;
            this.openLogBookButton.Text = "Open";
            this.openLogBookButton.UseVisualStyleBackColor = true;
            this.openLogBookButton.Click += new System.EventHandler(this.openLogBookButton_Click);
            // 
            // saveSamplesParamsButton
            // 
            this.saveSamplesParamsButton.ForeColor = System.Drawing.Color.Black;
            this.saveSamplesParamsButton.Location = new System.Drawing.Point(6, 205);
            this.saveSamplesParamsButton.Name = "saveSamplesParamsButton";
            this.saveSamplesParamsButton.Size = new System.Drawing.Size(74, 23);
            this.saveSamplesParamsButton.TabIndex = 18;
            this.saveSamplesParamsButton.Text = "Save";
            this.saveSamplesParamsButton.UseVisualStyleBackColor = true;
            this.saveSamplesParamsButton.Click += new System.EventHandler(this.saveSamplesParamsButton_Click);
            // 
            // samplePropertiesTabControl
            // 
            this.samplePropertiesTabControl.Controls.Add(this.bottomTabPage);
            this.samplePropertiesTabControl.Controls.Add(this.TopTabPage);
            this.samplePropertiesTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.samplePropertiesTabControl.Location = new System.Drawing.Point(3, 16);
            this.samplePropertiesTabControl.MinimumSize = new System.Drawing.Size(150, 0);
            this.samplePropertiesTabControl.Name = "samplePropertiesTabControl";
            this.samplePropertiesTabControl.SelectedIndex = 0;
            this.samplePropertiesTabControl.Size = new System.Drawing.Size(172, 183);
            this.samplePropertiesTabControl.TabIndex = 0;
            // 
            // bottomTabPage
            // 
            this.bottomTabPage.Controls.Add(this.bottomPropertyGrid);
            this.bottomTabPage.Location = new System.Drawing.Point(4, 22);
            this.bottomTabPage.Name = "bottomTabPage";
            this.bottomTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bottomTabPage.Size = new System.Drawing.Size(164, 157);
            this.bottomTabPage.TabIndex = 0;
            this.bottomTabPage.Text = "Bottom";
            this.bottomTabPage.UseVisualStyleBackColor = true;
            // 
            // bottomPropertyGrid
            // 
            this.bottomPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPropertyGrid.HelpVisible = false;
            this.bottomPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.bottomPropertyGrid.MinimumSize = new System.Drawing.Size(150, 0);
            this.bottomPropertyGrid.Name = "bottomPropertyGrid";
            this.bottomPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.bottomPropertyGrid.Size = new System.Drawing.Size(158, 151);
            this.bottomPropertyGrid.TabIndex = 1;
            // 
            // TopTabPage
            // 
            this.TopTabPage.Controls.Add(this.topPropertyGrid);
            this.TopTabPage.Location = new System.Drawing.Point(4, 22);
            this.TopTabPage.Name = "TopTabPage";
            this.TopTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TopTabPage.Size = new System.Drawing.Size(164, 157);
            this.TopTabPage.TabIndex = 1;
            this.TopTabPage.Text = "Top";
            this.TopTabPage.UseVisualStyleBackColor = true;
            // 
            // topPropertyGrid
            // 
            this.topPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPropertyGrid.HelpVisible = false;
            this.topPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.topPropertyGrid.Name = "topPropertyGrid";
            this.topPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.topPropertyGrid.Size = new System.Drawing.Size(158, 151);
            this.topPropertyGrid.TabIndex = 0;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.AutoSize = true;
            this.settingsGroupBox.Controls.Add(this.SettingsTabControl);
            this.settingsGroupBox.ForeColor = System.Drawing.Color.Red;
            this.settingsGroupBox.Location = new System.Drawing.Point(13, 364);
            this.settingsGroupBox.MinimumSize = new System.Drawing.Size(521, 200);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(534, 247);
            this.settingsGroupBox.TabIndex = 22;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.generalSettingsTabPage);
            this.SettingsTabControl.Controls.Add(this.laserSettingsTabPage);
            this.SettingsTabControl.Controls.Add(this.LockInSettingsTabPage);
            this.SettingsTabControl.Controls.Add(this.ElectroMagnetTabPage);
            this.SettingsTabControl.Controls.Add(this.ivCurvesTabPage);
            this.SettingsTabControl.Controls.Add(this.channelsConfigurationTabPage);
            this.SettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTabControl.Location = new System.Drawing.Point(3, 16);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(528, 228);
            this.SettingsTabControl.TabIndex = 17;
            // 
            // generalSettingsTabPage
            // 
            this.generalSettingsTabPage.Controls.Add(this.generalSettingsPanel);
            this.generalSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalSettingsTabPage.Name = "generalSettingsTabPage";
            this.generalSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalSettingsTabPage.Size = new System.Drawing.Size(520, 202);
            this.generalSettingsTabPage.TabIndex = 0;
            this.generalSettingsTabPage.Text = "General";
            this.generalSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // generalSettingsPanel
            // 
            this.generalSettingsPanel.Controls.Add(this.useKeithleyCheckBox);
            this.generalSettingsPanel.Controls.Add(this.biasErrorNumericEdit);
            this.generalSettingsPanel.Controls.Add(this.biasErrorLabel);
            this.generalSettingsPanel.Controls.Add(this.gainComboBox);
            this.generalSettingsPanel.Controls.Add(this.stepperWaitTime2NumericUpDown);
            this.generalSettingsPanel.Controls.Add(this.stepperWaitTime2Label);
            this.generalSettingsPanel.Controls.Add(this.pretriggerSamplesNumericUpDown);
            this.generalSettingsPanel.Controls.Add(this.pretriggerSamplesLabel);
            this.generalSettingsPanel.Controls.Add(this.sampleRateNumericUpDown);
            this.generalSettingsPanel.Controls.Add(this.totalSamplesNumericUpDown);
            this.generalSettingsPanel.Controls.Add(this.totalSamplesLabel);
            this.generalSettingsPanel.Controls.Add(this.triggerVoltageNumericEdit);
            this.generalSettingsPanel.Controls.Add(this.triggerVoltageLabel);
            this.generalSettingsPanel.Controls.Add(this.triggerConductanceNumericEdit);
            this.generalSettingsPanel.Controls.Add(this.triggerConductanceLabel);
            this.generalSettingsPanel.Controls.Add(this.sampleRateLabel);
            this.generalSettingsPanel.Controls.Add(this.stepperWaitTime1NumericUpDown);
            this.generalSettingsPanel.Controls.Add(this.stepperWaitTime1Label);
            this.generalSettingsPanel.Controls.Add(this.gainLabel);
            this.generalSettingsPanel.Controls.Add(this.biasNumericEdit);
            this.generalSettingsPanel.Controls.Add(this.biasLabel);
            this.generalSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalSettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.generalSettingsPanel.MinimumSize = new System.Drawing.Size(0, 151);
            this.generalSettingsPanel.Name = "generalSettingsPanel";
            this.generalSettingsPanel.Size = new System.Drawing.Size(514, 196);
            this.generalSettingsPanel.TabIndex = 16;
            // 
            // useKeithleyCheckBox
            // 
            this.useKeithleyCheckBox.AutoSize = true;
            this.useKeithleyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.useKeithleyCheckBox.Location = new System.Drawing.Point(7, 6);
            this.useKeithleyCheckBox.Name = "useKeithleyCheckBox";
            this.useKeithleyCheckBox.Size = new System.Drawing.Size(159, 17);
            this.useKeithleyCheckBox.TabIndex = 21;
            this.useKeithleyCheckBox.Text = "Use Keithley as Bias Source";
            this.useKeithleyCheckBox.UseVisualStyleBackColor = true;
            this.useKeithleyCheckBox.CheckedChanged += new System.EventHandler(this.useKeithleyCheckBox_CheckedChanged);
            // 
            // biasErrorNumericEdit
            // 
            this.biasErrorNumericEdit.CoercionInterval = 0.01D;
            this.biasErrorNumericEdit.Enabled = false;
            this.biasErrorNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.biasErrorNumericEdit.Location = new System.Drawing.Point(147, 59);
            this.biasErrorNumericEdit.Name = "biasErrorNumericEdit";
            this.biasErrorNumericEdit.Range = new NationalInstruments.UI.Range(-2D, 2D);
            this.biasErrorNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.biasErrorNumericEdit.TabIndex = 20;
            // 
            // biasErrorLabel
            // 
            this.biasErrorLabel.AutoSize = true;
            this.biasErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.biasErrorLabel.Location = new System.Drawing.Point(4, 61);
            this.biasErrorLabel.Name = "biasErrorLabel";
            this.biasErrorLabel.Size = new System.Drawing.Size(68, 13);
            this.biasErrorLabel.TabIndex = 19;
            this.biasErrorLabel.Text = "Bias Error [V]";
            // 
            // gainComboBox
            // 
            this.gainComboBox.DisplayMember = "3";
            this.gainComboBox.FormattingEnabled = true;
            this.gainComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.gainComboBox.Location = new System.Drawing.Point(147, 87);
            this.gainComboBox.Name = "gainComboBox";
            this.gainComboBox.Size = new System.Drawing.Size(75, 21);
            this.gainComboBox.TabIndex = 18;
            this.gainComboBox.Text = "5";
            this.gainComboBox.SelectedIndexChanged += new System.EventHandler(this.gainComboBox_ValueChanged);
            // 
            // stepperWaitTime2NumericUpDown
            // 
            this.stepperWaitTime2NumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepperWaitTime2NumericUpDown.Location = new System.Drawing.Point(423, 149);
            this.stepperWaitTime2NumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.stepperWaitTime2NumericUpDown.Name = "stepperWaitTime2NumericUpDown";
            this.stepperWaitTime2NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.stepperWaitTime2NumericUpDown.TabIndex = 17;
            this.stepperWaitTime2NumericUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // stepperWaitTime2Label
            // 
            this.stepperWaitTime2Label.AutoSize = true;
            this.stepperWaitTime2Label.ForeColor = System.Drawing.Color.Black;
            this.stepperWaitTime2Label.Location = new System.Drawing.Point(246, 151);
            this.stepperWaitTime2Label.Name = "stepperWaitTime2Label";
            this.stepperWaitTime2Label.Size = new System.Drawing.Size(138, 13);
            this.stepperWaitTime2Label.TabIndex = 16;
            this.stepperWaitTime2Label.Text = "Stepper Wait Time 2 [msec]";
            // 
            // pretriggerSamplesNumericUpDown
            // 
            this.pretriggerSamplesNumericUpDown.Location = new System.Drawing.Point(423, 59);
            this.pretriggerSamplesNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pretriggerSamplesNumericUpDown.Name = "pretriggerSamplesNumericUpDown";
            this.pretriggerSamplesNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.pretriggerSamplesNumericUpDown.TabIndex = 15;
            this.pretriggerSamplesNumericUpDown.Value = new decimal(new int[] {
            8500,
            0,
            0,
            0});
            // 
            // pretriggerSamplesLabel
            // 
            this.pretriggerSamplesLabel.AutoSize = true;
            this.pretriggerSamplesLabel.ForeColor = System.Drawing.Color.Black;
            this.pretriggerSamplesLabel.Location = new System.Drawing.Point(246, 61);
            this.pretriggerSamplesLabel.Name = "pretriggerSamplesLabel";
            this.pretriggerSamplesLabel.Size = new System.Drawing.Size(98, 13);
            this.pretriggerSamplesLabel.TabIndex = 14;
            this.pretriggerSamplesLabel.Text = "Pre-trigger Samples";
            // 
            // sampleRateNumericUpDown
            // 
            this.sampleRateNumericUpDown.Location = new System.Drawing.Point(423, 29);
            this.sampleRateNumericUpDown.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.sampleRateNumericUpDown.Name = "sampleRateNumericUpDown";
            this.sampleRateNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.sampleRateNumericUpDown.TabIndex = 7;
            this.sampleRateNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // totalSamplesNumericUpDown
            // 
            this.totalSamplesNumericUpDown.Location = new System.Drawing.Point(423, 88);
            this.totalSamplesNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.totalSamplesNumericUpDown.Name = "totalSamplesNumericUpDown";
            this.totalSamplesNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.totalSamplesNumericUpDown.TabIndex = 13;
            this.totalSamplesNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalSamplesNumericUpDown.ValueChanged += new System.EventHandler(this.totalSamplesNumericUpDown_ValueChanged);
            // 
            // totalSamplesLabel
            // 
            this.totalSamplesLabel.AutoSize = true;
            this.totalSamplesLabel.ForeColor = System.Drawing.Color.Black;
            this.totalSamplesLabel.Location = new System.Drawing.Point(246, 91);
            this.totalSamplesLabel.Name = "totalSamplesLabel";
            this.totalSamplesLabel.Size = new System.Drawing.Size(74, 13);
            this.totalSamplesLabel.TabIndex = 12;
            this.totalSamplesLabel.Text = "Total Samples";
            // 
            // triggerVoltageNumericEdit
            // 
            this.triggerVoltageNumericEdit.Enabled = false;
            this.triggerVoltageNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2, true);
            this.triggerVoltageNumericEdit.Location = new System.Drawing.Point(147, 117);
            this.triggerVoltageNumericEdit.Name = "triggerVoltageNumericEdit";
            this.triggerVoltageNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.triggerVoltageNumericEdit.TabIndex = 11;
            this.triggerVoltageNumericEdit.Value = -0.01D;
            // 
            // triggerVoltageLabel
            // 
            this.triggerVoltageLabel.AutoSize = true;
            this.triggerVoltageLabel.ForeColor = System.Drawing.Color.Black;
            this.triggerVoltageLabel.Location = new System.Drawing.Point(4, 121);
            this.triggerVoltageLabel.Name = "triggerVoltageLabel";
            this.triggerVoltageLabel.Size = new System.Drawing.Size(95, 13);
            this.triggerVoltageLabel.TabIndex = 10;
            this.triggerVoltageLabel.Text = "Trigger Voltage [V]";
            // 
            // triggerConductanceNumericEdit
            // 
            this.triggerConductanceNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2, true);
            this.triggerConductanceNumericEdit.Location = new System.Drawing.Point(147, 146);
            this.triggerConductanceNumericEdit.Name = "triggerConductanceNumericEdit";
            this.triggerConductanceNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.triggerConductanceNumericEdit.TabIndex = 9;
            this.triggerConductanceNumericEdit.Value = 0.0129D;
            this.triggerConductanceNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.triggerConductanceNumericEdit_AfterChangeValue_1);
            // 
            // triggerConductanceLabel
            // 
            this.triggerConductanceLabel.AutoSize = true;
            this.triggerConductanceLabel.ForeColor = System.Drawing.Color.Black;
            this.triggerConductanceLabel.Location = new System.Drawing.Point(4, 151);
            this.triggerConductanceLabel.Name = "triggerConductanceLabel";
            this.triggerConductanceLabel.Size = new System.Drawing.Size(130, 13);
            this.triggerConductanceLabel.TabIndex = 8;
            this.triggerConductanceLabel.Text = "Trigger Conductance [G0]";
            // 
            // sampleRateLabel
            // 
            this.sampleRateLabel.AutoSize = true;
            this.sampleRateLabel.ForeColor = System.Drawing.Color.Black;
            this.sampleRateLabel.Location = new System.Drawing.Point(246, 31);
            this.sampleRateLabel.Name = "sampleRateLabel";
            this.sampleRateLabel.Size = new System.Drawing.Size(90, 13);
            this.sampleRateLabel.TabIndex = 6;
            this.sampleRateLabel.Text = "Sample Rate [Hz]";
            // 
            // stepperWaitTime1NumericUpDown
            // 
            this.stepperWaitTime1NumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepperWaitTime1NumericUpDown.Location = new System.Drawing.Point(423, 119);
            this.stepperWaitTime1NumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.stepperWaitTime1NumericUpDown.Name = "stepperWaitTime1NumericUpDown";
            this.stepperWaitTime1NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.stepperWaitTime1NumericUpDown.TabIndex = 5;
            this.stepperWaitTime1NumericUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // stepperWaitTime1Label
            // 
            this.stepperWaitTime1Label.AutoSize = true;
            this.stepperWaitTime1Label.ForeColor = System.Drawing.Color.Black;
            this.stepperWaitTime1Label.Location = new System.Drawing.Point(246, 121);
            this.stepperWaitTime1Label.Name = "stepperWaitTime1Label";
            this.stepperWaitTime1Label.Size = new System.Drawing.Size(138, 13);
            this.stepperWaitTime1Label.TabIndex = 4;
            this.stepperWaitTime1Label.Text = "Stepper Wait Time 1 [msec]";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.ForeColor = System.Drawing.Color.Black;
            this.gainLabel.Location = new System.Drawing.Point(4, 91);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(62, 13);
            this.gainLabel.TabIndex = 2;
            this.gainLabel.Text = "Gain Power";
            // 
            // biasNumericEdit
            // 
            this.biasNumericEdit.CoercionInterval = 0.01D;
            this.biasNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.biasNumericEdit.Location = new System.Drawing.Point(147, 29);
            this.biasNumericEdit.Name = "biasNumericEdit";
            this.biasNumericEdit.Range = new NationalInstruments.UI.Range(-4D, 4D);
            this.biasNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.biasNumericEdit.TabIndex = 1;
            this.biasNumericEdit.Value = 0.1D;
            this.biasNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.biasNumericEdit_AfterChangeValue);
            // 
            // biasLabel
            // 
            this.biasLabel.AutoSize = true;
            this.biasLabel.ForeColor = System.Drawing.Color.Black;
            this.biasLabel.Location = new System.Drawing.Point(4, 31);
            this.biasLabel.Name = "biasLabel";
            this.biasLabel.Size = new System.Drawing.Size(43, 13);
            this.biasLabel.TabIndex = 0;
            this.biasLabel.Text = "Bias [V]";
            // 
            // laserSettingsTabPage
            // 
            this.laserSettingsTabPage.Controls.Add(this.laserSettingsPanel);
            this.laserSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.laserSettingsTabPage.Name = "laserSettingsTabPage";
            this.laserSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.laserSettingsTabPage.Size = new System.Drawing.Size(520, 202);
            this.laserSettingsTabPage.TabIndex = 1;
            this.laserSettingsTabPage.Text = "Laser";
            this.laserSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // laserSettingsPanel
            // 
            this.laserSettingsPanel.Controls.Add(this.laserModeComboBox);
            this.laserSettingsPanel.Controls.Add(this.frequencyNumericUpDown);
            this.laserSettingsPanel.Controls.Add(this.enableLaserCheckBox);
            this.laserSettingsPanel.Controls.Add(this.frequencyLabel);
            this.laserSettingsPanel.Controls.Add(this.amplitudeNumericUpDown);
            this.laserSettingsPanel.Controls.Add(this.laserAmplitudeLabel);
            this.laserSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laserSettingsPanel.ForeColor = System.Drawing.Color.Black;
            this.laserSettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.laserSettingsPanel.MinimumSize = new System.Drawing.Size(0, 89);
            this.laserSettingsPanel.Name = "laserSettingsPanel";
            this.laserSettingsPanel.Size = new System.Drawing.Size(514, 196);
            this.laserSettingsPanel.TabIndex = 5;
            // 
            // laserModeComboBox
            // 
            this.laserModeComboBox.Enabled = false;
            this.laserModeComboBox.FormattingEnabled = true;
            this.laserModeComboBox.Items.AddRange(new object[] {
            "DC",
            "Square"});
            this.laserModeComboBox.Location = new System.Drawing.Point(147, 4);
            this.laserModeComboBox.Name = "laserModeComboBox";
            this.laserModeComboBox.Size = new System.Drawing.Size(75, 21);
            this.laserModeComboBox.TabIndex = 3;
            this.laserModeComboBox.Text = "DC";
            this.laserModeComboBox.SelectedValueChanged += new System.EventHandler(this.laserModeComboBox_SelectedValueChanged);
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.Enabled = false;
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(147, 72);
            this.frequencyNumericUpDown.Name = "frequencyNumericUpDown";
            this.frequencyNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.frequencyNumericUpDown.TabIndex = 5;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // enableLaserCheckBox
            // 
            this.enableLaserCheckBox.AutoSize = true;
            this.enableLaserCheckBox.ForeColor = System.Drawing.Color.Black;
            this.enableLaserCheckBox.Location = new System.Drawing.Point(7, 6);
            this.enableLaserCheckBox.Name = "enableLaserCheckBox";
            this.enableLaserCheckBox.Size = new System.Drawing.Size(88, 17);
            this.enableLaserCheckBox.TabIndex = 2;
            this.enableLaserCheckBox.Text = "Enable Laser";
            this.enableLaserCheckBox.UseVisualStyleBackColor = true;
            this.enableLaserCheckBox.CheckedChanged += new System.EventHandler(this.enableLaserCheckBox_CheckedChanged);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Enabled = false;
            this.frequencyLabel.Location = new System.Drawing.Point(4, 74);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(79, 13);
            this.frequencyLabel.TabIndex = 4;
            this.frequencyLabel.Text = "Frequency [Hz]";
            // 
            // amplitudeNumericUpDown
            // 
            this.amplitudeNumericUpDown.DecimalPlaces = 3;
            this.amplitudeNumericUpDown.Enabled = false;
            this.amplitudeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amplitudeNumericUpDown.Location = new System.Drawing.Point(147, 40);
            this.amplitudeNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amplitudeNumericUpDown.Name = "amplitudeNumericUpDown";
            this.amplitudeNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.amplitudeNumericUpDown.TabIndex = 3;
            this.amplitudeNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.amplitudeNumericUpDown.ValueChanged += new System.EventHandler(this.amplitudeNumericUpDown_ValueChanged);
            // 
            // laserAmplitudeLabel
            // 
            this.laserAmplitudeLabel.AutoSize = true;
            this.laserAmplitudeLabel.Enabled = false;
            this.laserAmplitudeLabel.ForeColor = System.Drawing.Color.Black;
            this.laserAmplitudeLabel.Location = new System.Drawing.Point(4, 42);
            this.laserAmplitudeLabel.Name = "laserAmplitudeLabel";
            this.laserAmplitudeLabel.Size = new System.Drawing.Size(69, 13);
            this.laserAmplitudeLabel.TabIndex = 2;
            this.laserAmplitudeLabel.Text = "Amplitude [V]";
            // 
            // LockInSettingsTabPage
            // 
            this.LockInSettingsTabPage.Controls.Add(this.lockInPanel);
            this.LockInSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.LockInSettingsTabPage.Name = "LockInSettingsTabPage";
            this.LockInSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LockInSettingsTabPage.Size = new System.Drawing.Size(520, 202);
            this.LockInSettingsTabPage.TabIndex = 2;
            this.LockInSettingsTabPage.Text = "LockIn";
            this.LockInSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // lockInPanel
            // 
            this.lockInPanel.Controls.Add(this.rollOffComboBox);
            this.lockInPanel.Controls.Add(this.rollOffLabel);
            this.lockInPanel.Controls.Add(this.enableLockInCheckBox);
            this.lockInPanel.Controls.Add(this.timeConstantComboBox);
            this.lockInPanel.Controls.Add(this.timeConstantLabel);
            this.lockInPanel.Controls.Add(this.sensitivityComboBox);
            this.lockInPanel.Controls.Add(this.internalSourceLockInGroupBox);
            this.lockInPanel.Controls.Add(this.lockInSensitivityLabel);
            this.lockInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockInPanel.Location = new System.Drawing.Point(3, 3);
            this.lockInPanel.Name = "lockInPanel";
            this.lockInPanel.Size = new System.Drawing.Size(514, 196);
            this.lockInPanel.TabIndex = 0;
            // 
            // rollOffComboBox
            // 
            this.rollOffComboBox.FormattingEnabled = true;
            this.rollOffComboBox.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24"});
            this.rollOffComboBox.Location = new System.Drawing.Point(137, 124);
            this.rollOffComboBox.Name = "rollOffComboBox";
            this.rollOffComboBox.Size = new System.Drawing.Size(89, 21);
            this.rollOffComboBox.TabIndex = 14;
            this.rollOffComboBox.Text = "18";
            this.rollOffComboBox.SelectedValueChanged += new System.EventHandler(this.rollOffComboBox_SelectedValueChanged);
            // 
            // rollOffLabel
            // 
            this.rollOffLabel.AutoSize = true;
            this.rollOffLabel.ForeColor = System.Drawing.Color.Black;
            this.rollOffLabel.Location = new System.Drawing.Point(9, 127);
            this.rollOffLabel.Name = "rollOffLabel";
            this.rollOffLabel.Size = new System.Drawing.Size(64, 13);
            this.rollOffLabel.TabIndex = 13;
            this.rollOffLabel.Text = "Roll Off [dB]";
            // 
            // enableLockInCheckBox
            // 
            this.enableLockInCheckBox.AutoSize = true;
            this.enableLockInCheckBox.ForeColor = System.Drawing.Color.Black;
            this.enableLockInCheckBox.Location = new System.Drawing.Point(12, 16);
            this.enableLockInCheckBox.Name = "enableLockInCheckBox";
            this.enableLockInCheckBox.Size = new System.Drawing.Size(95, 17);
            this.enableLockInCheckBox.TabIndex = 12;
            this.enableLockInCheckBox.Text = "Enable LockIn";
            this.enableLockInCheckBox.UseVisualStyleBackColor = true;
            this.enableLockInCheckBox.CheckedChanged += new System.EventHandler(this.enableLockInCheckBox_CheckedChanged);
            // 
            // timeConstantComboBox
            // 
            this.timeConstantComboBox.FormattingEnabled = true;
            this.timeConstantComboBox.Items.AddRange(new object[] {
            "10E-6",
            "30E-6",
            "100E-6",
            "300E-6",
            "1E-3",
            "3E-3",
            "10E-3",
            "30E-3",
            "100E-3",
            "300E-3",
            "1",
            "3",
            "10",
            "30",
            "100",
            "300",
            "1E+3",
            "3E+3",
            "10E+3",
            "30E+3"});
            this.timeConstantComboBox.Location = new System.Drawing.Point(137, 86);
            this.timeConstantComboBox.Name = "timeConstantComboBox";
            this.timeConstantComboBox.Size = new System.Drawing.Size(89, 21);
            this.timeConstantComboBox.TabIndex = 11;
            this.timeConstantComboBox.Text = "30E-3";
            this.timeConstantComboBox.SelectedValueChanged += new System.EventHandler(this.timeConstantComboBox_SelectedValueChanged);
            // 
            // timeConstantLabel
            // 
            this.timeConstantLabel.AutoSize = true;
            this.timeConstantLabel.ForeColor = System.Drawing.Color.Black;
            this.timeConstantLabel.Location = new System.Drawing.Point(9, 89);
            this.timeConstantLabel.Name = "timeConstantLabel";
            this.timeConstantLabel.Size = new System.Drawing.Size(101, 13);
            this.timeConstantLabel.TabIndex = 10;
            this.timeConstantLabel.Text = "Time Constant [sec]";
            // 
            // sensitivityComboBox
            // 
            this.sensitivityComboBox.FormattingEnabled = true;
            this.sensitivityComboBox.Items.AddRange(new object[] {
            "2E-9",
            "5E-9",
            "10E-9",
            "20E-9",
            "50E-9",
            "100E-9",
            "200E-9",
            "500E-9",
            "1E-6",
            "2E-6",
            "5E-6",
            "10E-6",
            "20E-6",
            "50E-6",
            "100E-6",
            "200E-6",
            "500E-6",
            "1E-3",
            "2E-3",
            "5E-3",
            "10E-3",
            "20E-3",
            "50E-3",
            "100E-3",
            "200E-3",
            "500E-3",
            "1"});
            this.sensitivityComboBox.Location = new System.Drawing.Point(137, 50);
            this.sensitivityComboBox.Name = "sensitivityComboBox";
            this.sensitivityComboBox.Size = new System.Drawing.Size(89, 21);
            this.sensitivityComboBox.TabIndex = 9;
            this.sensitivityComboBox.Text = "500E-3";
            this.sensitivityComboBox.SelectedValueChanged += new System.EventHandler(this.sensitivityComboBox_SelectedValueChanged);
            // 
            // internalSourceLockInGroupBox
            // 
            this.internalSourceLockInGroupBox.Controls.Add(this.mixerReductionFactorNumericEdit);
            this.internalSourceLockInGroupBox.Controls.Add(this.acVoltageReductionFactorLabel);
            this.internalSourceLockInGroupBox.Controls.Add(this.internalSourceLockInCheckBoxcheckBox);
            this.internalSourceLockInGroupBox.Controls.Add(this.lockInAcVoltageNumericEdit);
            this.internalSourceLockInGroupBox.Controls.Add(this.lockInAcVoltageLabel);
            this.internalSourceLockInGroupBox.ForeColor = System.Drawing.Color.Red;
            this.internalSourceLockInGroupBox.Location = new System.Drawing.Point(260, 3);
            this.internalSourceLockInGroupBox.Name = "internalSourceLockInGroupBox";
            this.internalSourceLockInGroupBox.Size = new System.Drawing.Size(251, 184);
            this.internalSourceLockInGroupBox.TabIndex = 8;
            this.internalSourceLockInGroupBox.TabStop = false;
            // 
            // mixerReductionFactorNumericEdit
            // 
            this.mixerReductionFactorNumericEdit.CoercionInterval = 0.01D;
            this.mixerReductionFactorNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.mixerReductionFactorNumericEdit.Location = new System.Drawing.Point(152, 83);
            this.mixerReductionFactorNumericEdit.Name = "mixerReductionFactorNumericEdit";
            this.mixerReductionFactorNumericEdit.Range = new NationalInstruments.UI.Range(0D, 100D);
            this.mixerReductionFactorNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.mixerReductionFactorNumericEdit.TabIndex = 10;
            this.mixerReductionFactorNumericEdit.Value = 100D;
            // 
            // acVoltageReductionFactorLabel
            // 
            this.acVoltageReductionFactorLabel.AutoSize = true;
            this.acVoltageReductionFactorLabel.ForeColor = System.Drawing.Color.Black;
            this.acVoltageReductionFactorLabel.Location = new System.Drawing.Point(10, 83);
            this.acVoltageReductionFactorLabel.Name = "acVoltageReductionFactorLabel";
            this.acVoltageReductionFactorLabel.Size = new System.Drawing.Size(117, 13);
            this.acVoltageReductionFactorLabel.TabIndex = 9;
            this.acVoltageReductionFactorLabel.Text = "Mixer Reduction Factor";
            // 
            // internalSourceLockInCheckBoxcheckBox
            // 
            this.internalSourceLockInCheckBoxcheckBox.AutoSize = true;
            this.internalSourceLockInCheckBoxcheckBox.ForeColor = System.Drawing.Color.Black;
            this.internalSourceLockInCheckBoxcheckBox.Location = new System.Drawing.Point(11, 13);
            this.internalSourceLockInCheckBoxcheckBox.Name = "internalSourceLockInCheckBoxcheckBox";
            this.internalSourceLockInCheckBoxcheckBox.Size = new System.Drawing.Size(61, 17);
            this.internalSourceLockInCheckBoxcheckBox.TabIndex = 8;
            this.internalSourceLockInCheckBoxcheckBox.Text = "Internal";
            this.internalSourceLockInCheckBoxcheckBox.UseVisualStyleBackColor = true;
            // 
            // lockInAcVoltageNumericEdit
            // 
            this.lockInAcVoltageNumericEdit.CoercionInterval = 0.01D;
            this.lockInAcVoltageNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2, true);
            this.lockInAcVoltageNumericEdit.Location = new System.Drawing.Point(152, 50);
            this.lockInAcVoltageNumericEdit.Name = "lockInAcVoltageNumericEdit";
            this.lockInAcVoltageNumericEdit.Range = new NationalInstruments.UI.Range(1E-05D, 1D);
            this.lockInAcVoltageNumericEdit.Size = new System.Drawing.Size(75, 20);
            this.lockInAcVoltageNumericEdit.TabIndex = 7;
            this.lockInAcVoltageNumericEdit.Value = 0.01D;
            // 
            // lockInAcVoltageLabel
            // 
            this.lockInAcVoltageLabel.AutoSize = true;
            this.lockInAcVoltageLabel.ForeColor = System.Drawing.Color.Black;
            this.lockInAcVoltageLabel.Location = new System.Drawing.Point(10, 50);
            this.lockInAcVoltageLabel.Name = "lockInAcVoltageLabel";
            this.lockInAcVoltageLabel.Size = new System.Drawing.Size(76, 13);
            this.lockInAcVoltageLabel.TabIndex = 6;
            this.lockInAcVoltageLabel.Text = "AC Voltage [V]";
            // 
            // lockInSensitivityLabel
            // 
            this.lockInSensitivityLabel.AutoSize = true;
            this.lockInSensitivityLabel.ForeColor = System.Drawing.Color.Black;
            this.lockInSensitivityLabel.Location = new System.Drawing.Point(9, 53);
            this.lockInSensitivityLabel.Name = "lockInSensitivityLabel";
            this.lockInSensitivityLabel.Size = new System.Drawing.Size(70, 13);
            this.lockInSensitivityLabel.TabIndex = 2;
            this.lockInSensitivityLabel.Text = "Sensitivity [V]";
            // 
            // ElectroMagnetTabPage
            // 
            this.ElectroMagnetTabPage.Controls.Add(this.electroMagnetSettingsPanel);
            this.ElectroMagnetTabPage.Location = new System.Drawing.Point(4, 22);
            this.ElectroMagnetTabPage.Name = "ElectroMagnetTabPage";
            this.ElectroMagnetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ElectroMagnetTabPage.Size = new System.Drawing.Size(520, 202);
            this.ElectroMagnetTabPage.TabIndex = 3;
            this.ElectroMagnetTabPage.Text = "ElectroMagnet";
            this.ElectroMagnetTabPage.UseVisualStyleBackColor = true;
            // 
            // electroMagnetSettingsPanel
            // 
            this.electroMagnetSettingsPanel.Controls.Add(this.groupBox1);
            this.electroMagnetSettingsPanel.Controls.Add(this.emSkipFirstCycleByStepperMotorCheckBox);
            this.electroMagnetSettingsPanel.Controls.Add(this.emShortCircuitDelayTimeLabel);
            this.electroMagnetSettingsPanel.Controls.Add(this.emShortCircuitDelayTimeNumericUpDown);
            this.electroMagnetSettingsPanel.Controls.Add(this.emSlowDelayTimeNumericUpDown);
            this.electroMagnetSettingsPanel.Controls.Add(this.emSlowDelayTimeLabel);
            this.electroMagnetSettingsPanel.Controls.Add(this.emFastDelayTimeNumericUpDown);
            this.electroMagnetSettingsPanel.Controls.Add(this.enableElectroMagnetCheckBox);
            this.electroMagnetSettingsPanel.Controls.Add(this.emFastDelayTimeLabel);
            this.electroMagnetSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electroMagnetSettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.electroMagnetSettingsPanel.Name = "electroMagnetSettingsPanel";
            this.electroMagnetSettingsPanel.Size = new System.Drawing.Size(514, 196);
            this.electroMagnetSettingsPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emHoldOnMinVoltageNumericEdit);
            this.groupBox1.Controls.Add(this.emHoldOnMinVoltageLabel);
            this.groupBox1.Controls.Add(this.emHoldOnMinConductanceLabel);
            this.groupBox1.Controls.Add(this.emHoldOnMinConductanceNumericEdit);
            this.groupBox1.Controls.Add(this.emHoldOnMaxVoltageNumericEdit);
            this.groupBox1.Controls.Add(this.emHoldOnMaxVoltageLabel);
            this.groupBox1.Controls.Add(this.emHoldOnMaxConductanceLabel);
            this.groupBox1.Controls.Add(this.emHoldOnMaxConductanceNumericEdit);
            this.groupBox1.Controls.Add(this.emHoldOnToConductanceRangeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(269, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // emHoldOnMinVoltageNumericEdit
            // 
            this.emHoldOnMinVoltageNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.emHoldOnMinVoltageNumericEdit.CoercionInterval = 0.001D;
            this.emHoldOnMinVoltageNumericEdit.Enabled = false;
            this.emHoldOnMinVoltageNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2);
            this.emHoldOnMinVoltageNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.emHoldOnMinVoltageNumericEdit.Location = new System.Drawing.Point(145, 138);
            this.emHoldOnMinVoltageNumericEdit.Name = "emHoldOnMinVoltageNumericEdit";
            this.emHoldOnMinVoltageNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.emHoldOnMinVoltageNumericEdit.TabIndex = 17;
            // 
            // emHoldOnMinVoltageLabel
            // 
            this.emHoldOnMinVoltageLabel.AutoSize = true;
            this.emHoldOnMinVoltageLabel.Enabled = false;
            this.emHoldOnMinVoltageLabel.ForeColor = System.Drawing.Color.Black;
            this.emHoldOnMinVoltageLabel.Location = new System.Drawing.Point(9, 141);
            this.emHoldOnMinVoltageLabel.Name = "emHoldOnMinVoltageLabel";
            this.emHoldOnMinVoltageLabel.Size = new System.Drawing.Size(79, 13);
            this.emHoldOnMinVoltageLabel.TabIndex = 16;
            this.emHoldOnMinVoltageLabel.Text = "Min Voltage [V]";
            // 
            // emHoldOnMinConductanceLabel
            // 
            this.emHoldOnMinConductanceLabel.AutoSize = true;
            this.emHoldOnMinConductanceLabel.Enabled = false;
            this.emHoldOnMinConductanceLabel.ForeColor = System.Drawing.Color.Black;
            this.emHoldOnMinConductanceLabel.Location = new System.Drawing.Point(9, 111);
            this.emHoldOnMinConductanceLabel.Name = "emHoldOnMinConductanceLabel";
            this.emHoldOnMinConductanceLabel.Size = new System.Drawing.Size(114, 13);
            this.emHoldOnMinConductanceLabel.TabIndex = 15;
            this.emHoldOnMinConductanceLabel.Text = "Min Conductance [G0]";
            // 
            // emHoldOnMinConductanceNumericEdit
            // 
            this.emHoldOnMinConductanceNumericEdit.CoercionInterval = 0.1D;
            this.emHoldOnMinConductanceNumericEdit.Enabled = false;
            this.emHoldOnMinConductanceNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2);
            this.emHoldOnMinConductanceNumericEdit.Location = new System.Drawing.Point(145, 109);
            this.emHoldOnMinConductanceNumericEdit.Name = "emHoldOnMinConductanceNumericEdit";
            this.emHoldOnMinConductanceNumericEdit.Range = new NationalInstruments.UI.Range(0D, 20D);
            this.emHoldOnMinConductanceNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.emHoldOnMinConductanceNumericEdit.TabIndex = 14;
            this.emHoldOnMinConductanceNumericEdit.Value = 0.7D;
            this.emHoldOnMinConductanceNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.emHoldOnMinConductanceNumericEdit_AfterChangeValue);
            // 
            // emHoldOnMaxVoltageNumericEdit
            // 
            this.emHoldOnMaxVoltageNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.emHoldOnMaxVoltageNumericEdit.CoercionInterval = 0.001D;
            this.emHoldOnMaxVoltageNumericEdit.Enabled = false;
            this.emHoldOnMaxVoltageNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2);
            this.emHoldOnMaxVoltageNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.emHoldOnMaxVoltageNumericEdit.Location = new System.Drawing.Point(145, 78);
            this.emHoldOnMaxVoltageNumericEdit.Name = "emHoldOnMaxVoltageNumericEdit";
            this.emHoldOnMaxVoltageNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.emHoldOnMaxVoltageNumericEdit.TabIndex = 12;
            // 
            // emHoldOnMaxVoltageLabel
            // 
            this.emHoldOnMaxVoltageLabel.AutoSize = true;
            this.emHoldOnMaxVoltageLabel.Enabled = false;
            this.emHoldOnMaxVoltageLabel.ForeColor = System.Drawing.Color.Black;
            this.emHoldOnMaxVoltageLabel.Location = new System.Drawing.Point(9, 81);
            this.emHoldOnMaxVoltageLabel.Name = "emHoldOnMaxVoltageLabel";
            this.emHoldOnMaxVoltageLabel.Size = new System.Drawing.Size(82, 13);
            this.emHoldOnMaxVoltageLabel.TabIndex = 11;
            this.emHoldOnMaxVoltageLabel.Text = "Max Voltage [V]";
            // 
            // emHoldOnMaxConductanceLabel
            // 
            this.emHoldOnMaxConductanceLabel.AutoSize = true;
            this.emHoldOnMaxConductanceLabel.Enabled = false;
            this.emHoldOnMaxConductanceLabel.ForeColor = System.Drawing.Color.Black;
            this.emHoldOnMaxConductanceLabel.Location = new System.Drawing.Point(9, 51);
            this.emHoldOnMaxConductanceLabel.Name = "emHoldOnMaxConductanceLabel";
            this.emHoldOnMaxConductanceLabel.Size = new System.Drawing.Size(117, 13);
            this.emHoldOnMaxConductanceLabel.TabIndex = 10;
            this.emHoldOnMaxConductanceLabel.Text = "Max Conductance [G0]";
            // 
            // emHoldOnMaxConductanceNumericEdit
            // 
            this.emHoldOnMaxConductanceNumericEdit.CoercionInterval = 0.1D;
            this.emHoldOnMaxConductanceNumericEdit.Enabled = false;
            this.emHoldOnMaxConductanceNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(2);
            this.emHoldOnMaxConductanceNumericEdit.Location = new System.Drawing.Point(145, 49);
            this.emHoldOnMaxConductanceNumericEdit.Name = "emHoldOnMaxConductanceNumericEdit";
            this.emHoldOnMaxConductanceNumericEdit.Range = new NationalInstruments.UI.Range(0D, 20D);
            this.emHoldOnMaxConductanceNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.emHoldOnMaxConductanceNumericEdit.TabIndex = 9;
            this.emHoldOnMaxConductanceNumericEdit.Value = 1.3D;
            this.emHoldOnMaxConductanceNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.emHoldOnMaxConductanceNumericEdit_AfterChangeValue);
            // 
            // emHoldOnToConductanceRangeCheckBox
            // 
            this.emHoldOnToConductanceRangeCheckBox.AutoSize = true;
            this.emHoldOnToConductanceRangeCheckBox.Enabled = false;
            this.emHoldOnToConductanceRangeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.emHoldOnToConductanceRangeCheckBox.Location = new System.Drawing.Point(12, 19);
            this.emHoldOnToConductanceRangeCheckBox.Name = "emHoldOnToConductanceRangeCheckBox";
            this.emHoldOnToConductanceRangeCheckBox.Size = new System.Drawing.Size(179, 17);
            this.emHoldOnToConductanceRangeCheckBox.TabIndex = 8;
            this.emHoldOnToConductanceRangeCheckBox.Text = "Hold On to Conductance Range";
            this.emHoldOnToConductanceRangeCheckBox.UseVisualStyleBackColor = true;
            this.emHoldOnToConductanceRangeCheckBox.CheckedChanged += new System.EventHandler(this.holdOnToConductanceRangeCheckBox_CheckedChanged);
            // 
            // emSkipFirstCycleByStepperMotorCheckBox
            // 
            this.emSkipFirstCycleByStepperMotorCheckBox.AutoSize = true;
            this.emSkipFirstCycleByStepperMotorCheckBox.Enabled = false;
            this.emSkipFirstCycleByStepperMotorCheckBox.ForeColor = System.Drawing.Color.Black;
            this.emSkipFirstCycleByStepperMotorCheckBox.Location = new System.Drawing.Point(8, 164);
            this.emSkipFirstCycleByStepperMotorCheckBox.Name = "emSkipFirstCycleByStepperMotorCheckBox";
            this.emSkipFirstCycleByStepperMotorCheckBox.Size = new System.Drawing.Size(182, 17);
            this.emSkipFirstCycleByStepperMotorCheckBox.TabIndex = 13;
            this.emSkipFirstCycleByStepperMotorCheckBox.Text = "Skip First Cycle by Stepper Motor";
            this.emSkipFirstCycleByStepperMotorCheckBox.UseVisualStyleBackColor = true;
            // 
            // emShortCircuitDelayTimeLabel
            // 
            this.emShortCircuitDelayTimeLabel.AutoSize = true;
            this.emShortCircuitDelayTimeLabel.Enabled = false;
            this.emShortCircuitDelayTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.emShortCircuitDelayTimeLabel.Location = new System.Drawing.Point(11, 41);
            this.emShortCircuitDelayTimeLabel.Name = "emShortCircuitDelayTimeLabel";
            this.emShortCircuitDelayTimeLabel.Size = new System.Drawing.Size(142, 13);
            this.emShortCircuitDelayTimeLabel.TabIndex = 7;
            this.emShortCircuitDelayTimeLabel.Text = "Short Circuit Delay Time [ms]";
            // 
            // emShortCircuitDelayTimeNumericUpDown
            // 
            this.emShortCircuitDelayTimeNumericUpDown.Enabled = false;
            this.emShortCircuitDelayTimeNumericUpDown.Location = new System.Drawing.Point(162, 38);
            this.emShortCircuitDelayTimeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.emShortCircuitDelayTimeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.emShortCircuitDelayTimeNumericUpDown.Name = "emShortCircuitDelayTimeNumericUpDown";
            this.emShortCircuitDelayTimeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.emShortCircuitDelayTimeNumericUpDown.TabIndex = 6;
            this.emShortCircuitDelayTimeNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // emSlowDelayTimeNumericUpDown
            // 
            this.emSlowDelayTimeNumericUpDown.Enabled = false;
            this.emSlowDelayTimeNumericUpDown.Location = new System.Drawing.Point(162, 101);
            this.emSlowDelayTimeNumericUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.emSlowDelayTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.emSlowDelayTimeNumericUpDown.Name = "emSlowDelayTimeNumericUpDown";
            this.emSlowDelayTimeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.emSlowDelayTimeNumericUpDown.TabIndex = 5;
            this.emSlowDelayTimeNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // emSlowDelayTimeLabel
            // 
            this.emSlowDelayTimeLabel.AutoSize = true;
            this.emSlowDelayTimeLabel.Enabled = false;
            this.emSlowDelayTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.emSlowDelayTimeLabel.Location = new System.Drawing.Point(11, 103);
            this.emSlowDelayTimeLabel.Name = "emSlowDelayTimeLabel";
            this.emSlowDelayTimeLabel.Size = new System.Drawing.Size(108, 13);
            this.emSlowDelayTimeLabel.TabIndex = 4;
            this.emSlowDelayTimeLabel.Text = "Slow Delay Time [ms]";
            // 
            // emFastDelayTimeNumericUpDown
            // 
            this.emFastDelayTimeNumericUpDown.Enabled = false;
            this.emFastDelayTimeNumericUpDown.Location = new System.Drawing.Point(162, 70);
            this.emFastDelayTimeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.emFastDelayTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.emFastDelayTimeNumericUpDown.Name = "emFastDelayTimeNumericUpDown";
            this.emFastDelayTimeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.emFastDelayTimeNumericUpDown.TabIndex = 3;
            this.emFastDelayTimeNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // enableElectroMagnetCheckBox
            // 
            this.enableElectroMagnetCheckBox.AutoSize = true;
            this.enableElectroMagnetCheckBox.ForeColor = System.Drawing.Color.Black;
            this.enableElectroMagnetCheckBox.Location = new System.Drawing.Point(7, 6);
            this.enableElectroMagnetCheckBox.Name = "enableElectroMagnetCheckBox";
            this.enableElectroMagnetCheckBox.Size = new System.Drawing.Size(131, 17);
            this.enableElectroMagnetCheckBox.TabIndex = 0;
            this.enableElectroMagnetCheckBox.Text = "Enable ElectroMagnet";
            this.enableElectroMagnetCheckBox.UseVisualStyleBackColor = true;
            this.enableElectroMagnetCheckBox.CheckedChanged += new System.EventHandler(this.enableElectroMagnetCheckBox_CheckedChanged);
            // 
            // emFastDelayTimeLabel
            // 
            this.emFastDelayTimeLabel.AutoSize = true;
            this.emFastDelayTimeLabel.Enabled = false;
            this.emFastDelayTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.emFastDelayTimeLabel.Location = new System.Drawing.Point(11, 72);
            this.emFastDelayTimeLabel.Name = "emFastDelayTimeLabel";
            this.emFastDelayTimeLabel.Size = new System.Drawing.Size(105, 13);
            this.emFastDelayTimeLabel.TabIndex = 2;
            this.emFastDelayTimeLabel.Text = "Fast Delay Time [ms]";
            // 
            // channelsConfigurationTabPage
            // 
            this.channelsConfigurationTabPage.Controls.Add(this.channelsSettingsPanel);
            this.channelsConfigurationTabPage.Location = new System.Drawing.Point(4, 22);
            this.channelsConfigurationTabPage.Name = "channelsConfigurationTabPage";
            this.channelsConfigurationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.channelsConfigurationTabPage.Size = new System.Drawing.Size(520, 202);
            this.channelsConfigurationTabPage.TabIndex = 4;
            this.channelsConfigurationTabPage.Text = "Channels";
            this.channelsConfigurationTabPage.UseVisualStyleBackColor = true;
            // 
            // channelsSettingsPanel
            // 
            this.channelsSettingsPanel.Controls.Add(this.channel1ComboBox);
            this.channelsSettingsPanel.Controls.Add(this.channel3ComboBox);
            this.channelsSettingsPanel.Controls.Add(this.channel0CheckBox);
            this.channelsSettingsPanel.Controls.Add(this.channel3CheckBox);
            this.channelsSettingsPanel.Controls.Add(this.channel0ComboBox);
            this.channelsSettingsPanel.Controls.Add(this.channel2ComboBox);
            this.channelsSettingsPanel.Controls.Add(this.channel1CheckBox);
            this.channelsSettingsPanel.Controls.Add(this.channel2CheckBox);
            this.channelsSettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelsSettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.channelsSettingsPanel.Name = "channelsSettingsPanel";
            this.channelsSettingsPanel.Size = new System.Drawing.Size(514, 196);
            this.channelsSettingsPanel.TabIndex = 8;
            // 
            // channel1ComboBox
            // 
            this.channel1ComboBox.FormattingEnabled = true;
            this.channel1ComboBox.Location = new System.Drawing.Point(107, 33);
            this.channel1ComboBox.Name = "channel1ComboBox";
            this.channel1ComboBox.Size = new System.Drawing.Size(202, 21);
            this.channel1ComboBox.TabIndex = 3;
            this.channel1ComboBox.SelectedValueChanged += new System.EventHandler(this.channel1ComboBox_SelectedValueChanged);
            // 
            // channel3ComboBox
            // 
            this.channel3ComboBox.FormattingEnabled = true;
            this.channel3ComboBox.Location = new System.Drawing.Point(107, 87);
            this.channel3ComboBox.Name = "channel3ComboBox";
            this.channel3ComboBox.Size = new System.Drawing.Size(202, 21);
            this.channel3ComboBox.TabIndex = 7;
            this.channel3ComboBox.SelectedValueChanged += new System.EventHandler(this.channel3ComboBox_SelectedValueChanged);
            // 
            // channel0CheckBox
            // 
            this.channel0CheckBox.AutoSize = true;
            this.channel0CheckBox.Checked = true;
            this.channel0CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.channel0CheckBox.ForeColor = System.Drawing.Color.Black;
            this.channel0CheckBox.Location = new System.Drawing.Point(7, 8);
            this.channel0CheckBox.Name = "channel0CheckBox";
            this.channel0CheckBox.Size = new System.Drawing.Size(71, 17);
            this.channel0CheckBox.TabIndex = 0;
            this.channel0CheckBox.Text = "Dev1/ai0";
            this.channel0CheckBox.UseVisualStyleBackColor = true;
            this.channel0CheckBox.CheckedChanged += new System.EventHandler(this.channel0CheckBox_CheckedChanged);
            // 
            // channel3CheckBox
            // 
            this.channel3CheckBox.AutoSize = true;
            this.channel3CheckBox.ForeColor = System.Drawing.Color.Black;
            this.channel3CheckBox.Location = new System.Drawing.Point(7, 89);
            this.channel3CheckBox.Name = "channel3CheckBox";
            this.channel3CheckBox.Size = new System.Drawing.Size(71, 17);
            this.channel3CheckBox.TabIndex = 6;
            this.channel3CheckBox.Text = "Dev1/ai3";
            this.channel3CheckBox.UseVisualStyleBackColor = true;
            this.channel3CheckBox.CheckedChanged += new System.EventHandler(this.channel3CheckBox_CheckedChanged);
            // 
            // channel0ComboBox
            // 
            this.channel0ComboBox.FormattingEnabled = true;
            this.channel0ComboBox.Location = new System.Drawing.Point(107, 6);
            this.channel0ComboBox.Name = "channel0ComboBox";
            this.channel0ComboBox.Size = new System.Drawing.Size(202, 21);
            this.channel0ComboBox.TabIndex = 1;
            this.channel0ComboBox.SelectedValueChanged += new System.EventHandler(this.channel0ComboBox_SelectedValueChanged);
            // 
            // channel2ComboBox
            // 
            this.channel2ComboBox.FormattingEnabled = true;
            this.channel2ComboBox.Location = new System.Drawing.Point(107, 60);
            this.channel2ComboBox.Name = "channel2ComboBox";
            this.channel2ComboBox.Size = new System.Drawing.Size(202, 21);
            this.channel2ComboBox.TabIndex = 5;
            this.channel2ComboBox.SelectedValueChanged += new System.EventHandler(this.channel2ComboBox_SelectedValueChanged);
            // 
            // channel1CheckBox
            // 
            this.channel1CheckBox.AutoSize = true;
            this.channel1CheckBox.ForeColor = System.Drawing.Color.Black;
            this.channel1CheckBox.Location = new System.Drawing.Point(7, 35);
            this.channel1CheckBox.Name = "channel1CheckBox";
            this.channel1CheckBox.Size = new System.Drawing.Size(71, 17);
            this.channel1CheckBox.TabIndex = 2;
            this.channel1CheckBox.Text = "Dev1/ai1";
            this.channel1CheckBox.UseVisualStyleBackColor = true;
            this.channel1CheckBox.CheckedChanged += new System.EventHandler(this.channel1CheckBox_CheckedChanged);
            // 
            // channel2CheckBox
            // 
            this.channel2CheckBox.AutoSize = true;
            this.channel2CheckBox.ForeColor = System.Drawing.Color.Black;
            this.channel2CheckBox.Location = new System.Drawing.Point(7, 62);
            this.channel2CheckBox.Name = "channel2CheckBox";
            this.channel2CheckBox.Size = new System.Drawing.Size(71, 17);
            this.channel2CheckBox.TabIndex = 4;
            this.channel2CheckBox.Text = "Dev1/ai2";
            this.channel2CheckBox.UseVisualStyleBackColor = true;
            this.channel2CheckBox.CheckedChanged += new System.EventHandler(this.channel2CheckBox_CheckedChanged);
            // 
            // ivCurvesTabPage
            // 
            this.ivCurvesTabPage.Controls.Add(this.ivCurvesPanel);
            this.ivCurvesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ivCurvesTabPage.Name = "ivCurvesTabPage";
            this.ivCurvesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ivCurvesTabPage.Size = new System.Drawing.Size(520, 202);
            this.ivCurvesTabPage.TabIndex = 4;
            this.ivCurvesTabPage.Text = "IV Curves";
            this.ivCurvesTabPage.UseVisualStyleBackColor = true;
            // 
            // ivCurvesPanel
            // 
            this.ivCurvesPanel.Controls.Add(this.ivTimeOfOneCycleNumericEdit);
            this.ivCurvesPanel.Controls.Add(this.label8);
            this.ivCurvesPanel.Controls.Add(this.ivVoltageForTheDisplayedTraceNumericEdit);
            this.ivCurvesPanel.Controls.Add(this.label7);
            this.ivCurvesPanel.Controls.Add(this.label6);
            this.ivCurvesPanel.Controls.Add(this.label5);
            this.ivCurvesPanel.Controls.Add(this.label4);
            this.ivCurvesPanel.Controls.Add(this.ivSampleRateNumericEdit);
            this.ivCurvesPanel.Controls.Add(this.label3);
            this.ivCurvesPanel.Controls.Add(this.label2);
            this.ivCurvesPanel.Controls.Add(this.label1);
            this.ivCurvesPanel.Controls.Add(this.ivAmplitudeNumericEdit);
            this.ivCurvesPanel.Controls.Add(this.ivSampleDelayNumericEdit);
            this.ivCurvesPanel.Controls.Add(this.ivSamplesPerCycleNumericEdit);
            this.ivCurvesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ivCurvesPanel.Location = new System.Drawing.Point(3, 3);
            this.ivCurvesPanel.Name = "ivCurvesPanel";
            this.ivCurvesPanel.Size = new System.Drawing.Size(514, 196);
            this.ivCurvesPanel.TabIndex = 24;
            // 
            // ivTimeOfOneCycleNumericEdit
            // 
            this.ivTimeOfOneCycleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.ivTimeOfOneCycleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ivTimeOfOneCycleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.ivTimeOfOneCycleNumericEdit.Location = new System.Drawing.Point(152, 128);
            this.ivTimeOfOneCycleNumericEdit.Name = "ivTimeOfOneCycleNumericEdit";
            this.ivTimeOfOneCycleNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivTimeOfOneCycleNumericEdit.TabIndex = 33;
            this.ivTimeOfOneCycleNumericEdit.Value = 500D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Time of One IV Cycle [ms]";
            // 
            // ivVoltageForTheDisplayedTraceNumericEdit
            // 
            this.ivVoltageForTheDisplayedTraceNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.ivVoltageForTheDisplayedTraceNumericEdit.Location = new System.Drawing.Point(425, 20);
            this.ivVoltageForTheDisplayedTraceNumericEdit.Name = "ivVoltageForTheDisplayedTraceNumericEdit";
            this.ivVoltageForTheDisplayedTraceNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivVoltageForTheDisplayedTraceNumericEdit.TabIndex = 31;
            this.ivVoltageForTheDisplayedTraceNumericEdit.Value = 0.08D;
            this.ivVoltageForTheDisplayedTraceNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ivVoltageForTheDisplayedTraceNumericEdit_AfterChangeValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(246, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Voltage for the  displayed Trace [V]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(11, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "* Please Note:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(99, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "IV curves will be obtained only by pressing the \"Start IV Cycles\" Button.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sample Delay [ms]";
            // 
            // ivSampleRateNumericEdit
            // 
            this.ivSampleRateNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.ivSampleRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ivSampleRateNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.ivSampleRateNumericEdit.Location = new System.Drawing.Point(134, 99);
            this.ivSampleRateNumericEdit.Name = "ivSampleRateNumericEdit";
            this.ivSampleRateNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivSampleRateNumericEdit.TabIndex = 26;
            this.ivSampleRateNumericEdit.Value = 2500D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Samples Per Cycle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amplitude [V]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sample Rate [Hz]";
            // 
            // ivAmplitudeNumericEdit
            // 
            this.ivAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.ivAmplitudeNumericEdit.Location = new System.Drawing.Point(134, 15);
            this.ivAmplitudeNumericEdit.Name = "ivAmplitudeNumericEdit";
            this.ivAmplitudeNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivAmplitudeNumericEdit.TabIndex = 20;
            this.ivAmplitudeNumericEdit.Value = 0.1D;
            this.ivAmplitudeNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ivAmplitudeNumericEdit_AfterChangeValue);
            // 
            // ivSampleDelayNumericEdit
            // 
            this.ivSampleDelayNumericEdit.Location = new System.Drawing.Point(134, 71);
            this.ivSampleDelayNumericEdit.Name = "ivSampleDelayNumericEdit";
            this.ivSampleDelayNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivSampleDelayNumericEdit.TabIndex = 22;
            this.ivSampleDelayNumericEdit.Value = 0.4D;
            this.ivSampleDelayNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ivSampleDelayNumericEdit_AfterChangeValue);
            // 
            // ivSamplesPerCycleNumericEdit
            // 
            this.ivSamplesPerCycleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ivSamplesPerCycleNumericEdit.Location = new System.Drawing.Point(134, 43);
            this.ivSamplesPerCycleNumericEdit.Name = "ivSamplesPerCycleNumericEdit";
            this.ivSamplesPerCycleNumericEdit.Size = new System.Drawing.Size(78, 20);
            this.ivSamplesPerCycleNumericEdit.TabIndex = 21;
            this.ivSamplesPerCycleNumericEdit.Value = 1250D;
            this.ivSamplesPerCycleNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ivSamplesPerCycleNumericEdit_AfterChangeValue);
            // 
            // controlPanelsTabPage
            // 
            this.controlPanelsTabPage.AutoScroll = true;
            this.controlPanelsTabPage.Controls.Add(this.electroMagnetGroupBox);
            this.controlPanelsTabPage.Controls.Add(this.stepperMotorGroupBox);
            this.controlPanelsTabPage.Location = new System.Drawing.Point(4, 22);
            this.controlPanelsTabPage.Name = "controlPanelsTabPage";
            this.controlPanelsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.controlPanelsTabPage.Size = new System.Drawing.Size(741, 798);
            this.controlPanelsTabPage.TabIndex = 1;
            this.controlPanelsTabPage.Text = "Control Panels";
            this.controlPanelsTabPage.UseVisualStyleBackColor = true;
            // 
            // electroMagnetGroupBox
            // 
            this.electroMagnetGroupBox.Controls.Add(this.electroMagnetUserControl2);
            this.electroMagnetGroupBox.Location = new System.Drawing.Point(13, 183);
            this.electroMagnetGroupBox.Name = "electroMagnetGroupBox";
            this.electroMagnetGroupBox.Size = new System.Drawing.Size(281, 278);
            this.electroMagnetGroupBox.TabIndex = 2;
            this.electroMagnetGroupBox.TabStop = false;
            this.electroMagnetGroupBox.Text = "ElectroMagnet";
            // 
            // electroMagnetUserControl2
            // 
            this.electroMagnetUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electroMagnetUserControl2.Location = new System.Drawing.Point(3, 16);
            this.electroMagnetUserControl2.Name = "electroMagnetUserControl2";
            this.electroMagnetUserControl2.Size = new System.Drawing.Size(275, 259);
            this.electroMagnetUserControl2.TabIndex = 0;
            // 
            // stepperMotorGroupBox
            // 
            this.stepperMotorGroupBox.Controls.Add(this.stepperMotorUserControl1);
            this.stepperMotorGroupBox.Location = new System.Drawing.Point(12, 6);
            this.stepperMotorGroupBox.Name = "stepperMotorGroupBox";
            this.stepperMotorGroupBox.Size = new System.Drawing.Size(282, 170);
            this.stepperMotorGroupBox.TabIndex = 1;
            this.stepperMotorGroupBox.TabStop = false;
            this.stepperMotorGroupBox.Text = "Stepper Motor";
            // 
            // stepperMotorUserControl1
            // 
            this.stepperMotorUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepperMotorUserControl1.Location = new System.Drawing.Point(3, 16);
            this.stepperMotorUserControl1.Name = "stepperMotorUserControl1";
            this.stepperMotorUserControl1.Size = new System.Drawing.Size(276, 151);
            this.stepperMotorUserControl1.TabIndex = 0;
            // 
            // aquireDataBackgroundWorker
            // 
            this.aquireDataBackgroundWorker.WorkerReportsProgress = true;
            this.aquireDataBackgroundWorker.WorkerSupportsCancellation = true;
            this.aquireDataBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.aquireDataBackgroundWorker_DoWork);
            this.aquireDataBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.aquireDataBackgroundWorker_RunWorkerCompleted);
            // 
            // stepperUpBackgroundWorker
            // 
            this.stepperUpBackgroundWorker.WorkerReportsProgress = true;
            this.stepperUpBackgroundWorker.WorkerSupportsCancellation = true;
            this.stepperUpBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.stepperUpBackgroundWorker_DoWork);
            this.stepperUpBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.stepperUpBackgroundWorker_RunWorkerCompleted);
            // 
            // fixBiasBackgroundWorker
            // 
            this.fixBiasBackgroundWorker.WorkerSupportsCancellation = true;
            this.fixBiasBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fixBiasBackgroundWorker_DoWork);
            this.fixBiasBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fixBiasBackgroundWorker_RunWorkerCompleted);
            // 
            // ivCyclesBackgroundWorker
            // 
            this.ivCyclesBackgroundWorker.WorkerReportsProgress = true;
            this.ivCyclesBackgroundWorker.WorkerSupportsCancellation = true;
            this.ivCyclesBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ivCyclesBackgroundWorker_DoWork);
            this.ivCyclesBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ivCyclesBackgroundWorker_RunWorkerCompleted);
            // 
            // SBJControllerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(749, 824);
            this.Controls.Add(this.controllerTabControl);
            this.Name = "SBJControllerMainForm";
            this.Text = "SBJControllerMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SBJControllerMainForm_FormClosed);
            this.Shown += new System.EventHandler(this.SBJControllerMainForm_Shown);
            this.controllerTabControl.ResumeLayout(false);
            this.dataAquisitionTabPage.ResumeLayout(false);
            this.dataAquisitionTabPage.PerformLayout();
            this.plotGroupBox.ResumeLayout(false);
            this.operateGroupBox.ResumeLayout(false);
            this.operateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCyclesnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortCircuitVoltageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traceWaveformGraph)).EndInit();
            this.samplePropertiesGroupBox.ResumeLayout(false);
            this.samplePropertiesTabControl.ResumeLayout(false);
            this.bottomTabPage.ResumeLayout(false);
            this.TopTabPage.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.SettingsTabControl.ResumeLayout(false);
            this.generalSettingsTabPage.ResumeLayout(false);
            this.generalSettingsPanel.ResumeLayout(false);
            this.generalSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biasErrorNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepperWaitTime2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretriggerSamplesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSamplesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerVoltageNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerConductanceNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepperWaitTime1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biasNumericEdit)).EndInit();
            this.laserSettingsTabPage.ResumeLayout(false);
            this.laserSettingsPanel.ResumeLayout(false);
            this.laserSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).EndInit();
            this.LockInSettingsTabPage.ResumeLayout(false);
            this.lockInPanel.ResumeLayout(false);
            this.lockInPanel.PerformLayout();
            this.internalSourceLockInGroupBox.ResumeLayout(false);
            this.internalSourceLockInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mixerReductionFactorNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockInAcVoltageNumericEdit)).EndInit();
            this.ElectroMagnetTabPage.ResumeLayout(false);
            this.electroMagnetSettingsPanel.ResumeLayout(false);
            this.electroMagnetSettingsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMinVoltageNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMinConductanceNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMaxVoltageNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emHoldOnMaxConductanceNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emShortCircuitDelayTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emSlowDelayTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emFastDelayTimeNumericUpDown)).EndInit();
            this.channelsConfigurationTabPage.ResumeLayout(false);
            this.channelsSettingsPanel.ResumeLayout(false);
            this.channelsSettingsPanel.PerformLayout();
            this.ivCurvesTabPage.ResumeLayout(false);
            this.ivCurvesPanel.ResumeLayout(false);
            this.ivCurvesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ivTimeOfOneCycleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivVoltageForTheDisplayedTraceNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSampleRateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSampleDelayNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSamplesPerCycleNumericEdit)).EndInit();
            this.controlPanelsTabPage.ResumeLayout(false);
            this.electroMagnetGroupBox.ResumeLayout(false);
            this.stepperMotorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker obtainShortCircuitBackgroundWorker;
        private System.Windows.Forms.TabControl controllerTabControl;
        private System.Windows.Forms.TabPage dataAquisitionTabPage;
        private System.Windows.Forms.TabPage controlPanelsTabPage;
        private System.ComponentModel.BackgroundWorker aquireDataBackgroundWorker;
        private System.ComponentModel.BackgroundWorker stepperUpBackgroundWorker;
        private System.Windows.Forms.GroupBox operateGroupBox;
        private System.Windows.Forms.Button saveSamplesParamsButton;
        private System.Windows.Forms.CheckBox moveUpCheckBoxButton;
        private System.Windows.Forms.CheckBox startStopCheckBoxButton;
        private System.Windows.Forms.CheckBox shortCircuitCheckBoxButton;
        private System.Windows.Forms.NumericUpDown numberOfCyclesnumericUpDown;
        private System.Windows.Forms.Label numberOfCyclesLabel1;
        private System.Windows.Forms.NumericUpDown shortCircuitVoltageNumericUpDown;
        private System.Windows.Forms.Label shortCircuitVoltageLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox fileSavingCheckBox;
        private System.Windows.Forms.Label fileNumberLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.NumericUpDown fileNumberNumericUpDown;
        private NationalInstruments.UI.WindowsForms.WaveformGraph traceWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.GroupBox samplePropertiesGroupBox;
        private System.Windows.Forms.TabControl samplePropertiesTabControl;
        private System.Windows.Forms.TabPage bottomTabPage;
        private System.Windows.Forms.PropertyGrid bottomPropertyGrid;
        private System.Windows.Forms.TabPage TopTabPage;
        private System.Windows.Forms.PropertyGrid topPropertyGrid;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Panel laserSettingsPanel;
        private System.Windows.Forms.ComboBox laserModeComboBox;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.CheckBox enableLaserCheckBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.NumericUpDown amplitudeNumericUpDown;
        private System.Windows.Forms.Label laserAmplitudeLabel;
        private System.Windows.Forms.Panel generalSettingsPanel;
        private System.Windows.Forms.NumericUpDown stepperWaitTime2NumericUpDown;
        private System.Windows.Forms.Label stepperWaitTime2Label;
        private System.Windows.Forms.NumericUpDown pretriggerSamplesNumericUpDown;
        private System.Windows.Forms.Label pretriggerSamplesLabel;
        private System.Windows.Forms.NumericUpDown sampleRateNumericUpDown;
        private System.Windows.Forms.NumericUpDown totalSamplesNumericUpDown;
        private System.Windows.Forms.Label totalSamplesLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit triggerVoltageNumericEdit;
        private System.Windows.Forms.Label triggerVoltageLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit triggerConductanceNumericEdit;
        private System.Windows.Forms.Label triggerConductanceLabel;
        private System.Windows.Forms.Label sampleRateLabel;
        private System.Windows.Forms.NumericUpDown stepperWaitTime1NumericUpDown;
        private System.Windows.Forms.Label stepperWaitTime1Label;
        private System.Windows.Forms.Label gainLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit biasNumericEdit;
        private System.Windows.Forms.Label biasLabel;
        private System.Windows.Forms.Button openLogBookButton;
        private System.Windows.Forms.ComboBox gainComboBox;
        private NationalInstruments.UI.YAxis yAxis2;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage generalSettingsTabPage;
        private System.Windows.Forms.TabPage laserSettingsTabPage;
        private System.Windows.Forms.TabPage LockInSettingsTabPage;
        private System.Windows.Forms.Panel lockInPanel;
        private System.Windows.Forms.Label lockInSensitivityLabel;
        private System.Windows.Forms.TabPage ElectroMagnetTabPage;
        private System.Windows.Forms.CheckBox enableElectroMagnetCheckBox;
        private System.Windows.Forms.GroupBox stepperMotorGroupBox;
        private System.Windows.Forms.GroupBox electroMagnetGroupBox;
        private System.Windows.Forms.Panel electroMagnetSettingsPanel;
        private System.Windows.Forms.Label emFastDelayTimeLabel;
        private System.Windows.Forms.NumericUpDown emFastDelayTimeNumericUpDown;
        private System.Windows.Forms.Label emSlowDelayTimeLabel;
        private System.Windows.Forms.NumericUpDown emSlowDelayTimeNumericUpDown;
        private System.Windows.Forms.Label emShortCircuitDelayTimeLabel;
        private System.Windows.Forms.NumericUpDown emShortCircuitDelayTimeNumericUpDown;
        private System.Windows.Forms.Label emHoldOnMaxConductanceLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit emHoldOnMaxConductanceNumericEdit;
        private System.Windows.Forms.CheckBox emHoldOnToConductanceRangeCheckBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit emHoldOnMaxVoltageNumericEdit;
        private System.Windows.Forms.Label emHoldOnMaxVoltageLabel;
        private System.Windows.Forms.CheckBox emSkipFirstCycleByStepperMotorCheckBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit emHoldOnMinVoltageNumericEdit;
        private System.Windows.Forms.Label emHoldOnMinVoltageLabel;
        private System.Windows.Forms.Label emHoldOnMinConductanceLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit emHoldOnMinConductanceNumericEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private ElectroMagnetUserControl electroMagnetUserControl2;
        private StepperMotorUserControl stepperMotorUserControl1;
        private System.Windows.Forms.Label biasErrorLabel;
        private System.Windows.Forms.CheckBox fixBiasCheckBoxButton;
        private System.ComponentModel.BackgroundWorker fixBiasBackgroundWorker;
        private NationalInstruments.UI.WindowsForms.NumericEdit biasErrorNumericEdit;
        private System.Windows.Forms.TabPage channelsConfigurationTabPage;
        private System.Windows.Forms.CheckBox channel0CheckBox;
        private System.Windows.Forms.ComboBox channel3ComboBox;
        private System.Windows.Forms.CheckBox channel3CheckBox;
        private System.Windows.Forms.ComboBox channel2ComboBox;
        private System.Windows.Forms.CheckBox channel2CheckBox;
        private System.Windows.Forms.ComboBox channel1ComboBox;
        private System.Windows.Forms.CheckBox channel1CheckBox;
        private System.Windows.Forms.ComboBox channel0ComboBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit lockInAcVoltageNumericEdit;
        private System.Windows.Forms.Label lockInAcVoltageLabel;
        private System.Windows.Forms.Panel channelsSettingsPanel;
        private System.Windows.Forms.ComboBox sensitivityComboBox;
        private System.Windows.Forms.GroupBox internalSourceLockInGroupBox;
        private System.Windows.Forms.CheckBox internalSourceLockInCheckBoxcheckBox;
        private System.Windows.Forms.Label timeConstantLabel;
        private System.Windows.Forms.ComboBox timeConstantComboBox;
        private System.Windows.Forms.CheckBox enableLockInCheckBox;
        private System.Windows.Forms.ComboBox rollOffComboBox;
        private System.Windows.Forms.Label rollOffLabel;
        private System.Windows.Forms.GroupBox plotGroupBox;
        private System.Windows.Forms.ListView channelsListView;
        private NationalInstruments.UI.WindowsForms.NumericEdit mixerReductionFactorNumericEdit;
        private System.Windows.Forms.Label acVoltageReductionFactorLabel;
        private System.Windows.Forms.TabPage ivCurvesTabPage;
        private System.Windows.Forms.Panel ivCurvesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivAmplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivSampleDelayNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivSamplesPerCycleNumericEdit;
        private System.Windows.Forms.Label label4;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivSampleRateNumericEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ivStartCyclesCheckBox;
        private System.ComponentModel.BackgroundWorker ivCyclesBackgroundWorker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivVoltageForTheDisplayedTraceNumericEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox useKeithleyCheckBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit ivTimeOfOneCycleNumericEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openFolderButton;
                         
    }
}