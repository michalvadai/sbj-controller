﻿
using System.Collections.Generic;
using System.Text;
using System;
namespace SBJController
{
    /// <summary>
    /// This class represents all the required data memebers of the UI
    /// </summary>
    public class SBJControllerSettings
    {
        public GeneralSBJControllerSettings GeneralSettings { get; set; }
        public LaserSBJControllerSettings LaserSettings { get; set; }
        public LockInSBJControllerSettings LockInSettings { get; set; }
        public ElectroMagnetSBJControllerSettings ElectromagnetSettings { get; set; }
        public ChannelsSettings ChannelsSettings { get; set; }
        public IVCurvesSBJControllerSettings IVCurvesSettings { get; set; }
        
        public SBJControllerSettings(GeneralSBJControllerSettings generalSettings,
                                     LaserSBJControllerSettings laserSettings,
                                     LockInSBJControllerSettings lockInSettings,
                                     ElectroMagnetSBJControllerSettings electromagnetSettings,
                                     ChannelsSettings channelsSettings,
                                     IVCurvesSBJControllerSettings ivCurvesSettings)
        {
            GeneralSettings = generalSettings;
            LaserSettings = laserSettings;
            LockInSettings = lockInSettings;
            ElectromagnetSettings = electromagnetSettings;                        
            ChannelsSettings = channelsSettings;
            IVCurvesSettings = ivCurvesSettings;
        }
    }

    /// <summary>
    /// This class represents the general settinngs in the UI
    /// </summary>
    public class GeneralSBJControllerSettings 
    {
        public double Bias { get; set; }
        public double BiasError { get; set; }
        public string Gain { get; set; }
        public double TriggerVoltage { get; set; }
        public double TriggerConductance { get; set; }
        public int SampleRate { get; set; }
        public int TotalSamples { get; set; }
        public int PretriggerSamples { get; set; }
        public int StepperWaitTime1 { get; set; }
        public int StepperWaitTime2 { get; set; }
        public bool IsFileSavingRequired { get; set; }
        public string Path { get; set; }
        public int CurrentFileNumber { get; set; }
        public int TotalNumberOfCycles { get; set; }
        public double ShortCircuitVoltage { get; set; }
        public Sample Bottom { get; set; }
        public Sample Top { get; set; }

        public GeneralSBJControllerSettings (double bias, double biasError, string gain, double triggerVoltage,
                                     double triggerConductance, int sampleRate,
                                     int totalSamples, int pretriggerSamples,
                                     int stepperWaitTime1, int stepperWaitTime2, bool isFileSavingRequired, 
                                     string path, int currentFileNumber, int totalNUmberOfCycles, 
                                     double shourtCircuitVoltage,Sample bottom, Sample top)
        {
            Bias = bias;
            BiasError = biasError;
            Gain = gain;
            TriggerConductance = triggerConductance;
            TriggerVoltage = triggerVoltage;
            SampleRate = sampleRate;
            TotalSamples = totalSamples;
            PretriggerSamples = pretriggerSamples;
            StepperWaitTime1 = stepperWaitTime1;
            StepperWaitTime2 = stepperWaitTime2;
            IsFileSavingRequired = isFileSavingRequired;
            Path = path;
            CurrentFileNumber = currentFileNumber;
            TotalNumberOfCycles = totalNUmberOfCycles;
            ShortCircuitVoltage = shourtCircuitVoltage;
            Bottom = bottom;
            Top = top;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("General Settings:" + Environment.NewLine);
            foreach (var property in this.GetType().GetProperties())
            {
                toStringResult.Append(property.Name + ":\t" + property.GetValue(this, null).ToString() + Environment.NewLine);
            }
            return toStringResult.ToString();
        }
    }

    /// <summary>
    /// This class represents the laser settinngs in the UI
    /// </summary>
    public class LaserSBJControllerSettings
    {
        public bool IsLaserOn { get; set; }
        public string LaserMode { get; set; }
        public double LaserAmplitude { get; set; }
        public int LaserFrequency { get; set; }

        public LaserSBJControllerSettings(bool isLaserOn, string laserMode, double laserAmplitude, int laserFrequency)
        {
            IsLaserOn = isLaserOn;
            LaserMode = laserMode;
            LaserAmplitude = laserAmplitude;
            LaserFrequency = laserFrequency;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("Laser Settings:" + Environment.NewLine);
            foreach (var property in this.GetType().GetProperties())
            {
                toStringResult.Append(property.Name + ":\t" + property.GetValue(this, null).ToString() + Environment.NewLine);
            }
            return toStringResult.ToString();
        }
    }

    /// <summary>
    /// This class represents the general lockin in the UI
    /// </summary>
    public class LockInSBJControllerSettings
    {
        public bool IsLockInSignalEnable { get; set; }
        public bool IsLockInInternalEnable { get; set; }
        public double LockInSensitivity { get; set; }
        public double LockInTimeConstant { get; set; }
        public double LockInRollOff { get; set; }
        public double LockInAcVoltage { get; set; }
        public int LockInMixerReductionFactor { get; set; }


        public LockInSBJControllerSettings(bool isLockInSignalEnable, bool isLockInInternalEnable, double lockInSensitivity, double lockInTimeConstant, double lockInRollOff, double lockInAcVoltage, int lockInMixerReductionFactor)
        {
            IsLockInSignalEnable = isLockInSignalEnable;
            IsLockInInternalEnable = isLockInInternalEnable;
            LockInSensitivity = lockInSensitivity;
            LockInAcVoltage = lockInAcVoltage;
            LockInTimeConstant = lockInTimeConstant;
            LockInRollOff = lockInRollOff;
            LockInMixerReductionFactor = lockInMixerReductionFactor;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("LockIn Settings:" + Environment.NewLine);
            foreach (var property in this.GetType().GetProperties())
            {
                toStringResult.Append(property.Name + ":\t" + property.GetValue(this, null).ToString() + Environment.NewLine);
            }
            return toStringResult.ToString();
        }
    }

    /// <summary>
    /// This class represents the electromagnet settinngs in the UI
    /// </summary>
    public class ElectroMagnetSBJControllerSettings
    {
        public bool IsEMEnable { get; set; }
        public int EMShortCircuitDelayTime { get; set; }
        public int EMFastDelayTime { get; set; }
        public int EMSlowDelayTime { get; set; }
        public bool IsEMHoldOnEnable { get; set; }
        public double EMHoldOnMaxConductance { get; set; }
        public double EMHoldOnMaxVoltage { get; set; }
        public double EMHoldOnMinConductance { get; set; }
        public double EMHoldOnMinVoltage { get; set; }
        public bool IsEMSkipFirstCycleEnable { get; set; }

        public ElectroMagnetSBJControllerSettings (bool isEMEnable, int emShortCircuitDelayTime, 
                                                   int emFastDelayTime, int emSlowDelayTime, 
                                                   bool isEMHoldOnEnable, double emHoldOnMaxConductance, 
                                                   double emHoldOnMaxVoltage, double emHoldOnMinConductance, 
                                                   double emHoldOnMinVoltage, bool isEMSkipFirstCycleEnable)
        {
            IsEMEnable = isEMEnable;
            EMShortCircuitDelayTime = emShortCircuitDelayTime;
            EMFastDelayTime = emFastDelayTime;
            EMSlowDelayTime = emSlowDelayTime;
            IsEMHoldOnEnable = isEMHoldOnEnable;
            EMHoldOnMaxConductance = emHoldOnMaxConductance;
            EMHoldOnMaxVoltage = emHoldOnMaxVoltage;
            EMHoldOnMinConductance = emHoldOnMinConductance;
            EMHoldOnMinVoltage = emHoldOnMinVoltage;
            IsEMSkipFirstCycleEnable = isEMSkipFirstCycleEnable;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("Electromagnet Settings:" + Environment.NewLine);
            foreach (var property in this.GetType().GetProperties())
            {
                toStringResult.Append(property.Name + ":\t" + property.GetValue(this, null).ToString()+ Environment.NewLine);
            }
            return toStringResult.ToString();
        }
    }
    
    //TODO: add summary here
    public class ChannelsSettings
    {
        private IList<IDataChannel> m_activeChannels;

        public IList<IDataChannel> ActiveChannels
        {
            get { return m_activeChannels; }
        }

        public ChannelsSettings(IList<IDataChannel> channels)
        {
            m_activeChannels = channels;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("Channels Settings:" + Environment.NewLine);
            foreach (var dataChannel in ActiveChannels)
            {
                toStringResult.Append(dataChannel.PhysicalName + ":\t" + dataChannel.Name + Environment.NewLine);                
            }
            return toStringResult.ToString();
        }
    }

    /// <summary>
    /// This class represents the IV settings in the UI
    /// </summary>
    public class IVCurvesSBJControllerSettings
    {
        public double IVAmplitude { get; set; }
        public int IVSamplesPerCycle { get; set; }
        public double IVSamplesDelay { get; set; }
        public int IVSampleRate { get; set; }

        public IVCurvesSBJControllerSettings(double ivAmplitude, int ivSamplesPerCycle, double ivSamplesDelay, int ivSampleRate)
        {
            IVAmplitude = ivAmplitude;
            IVSamplesPerCycle = ivSamplesPerCycle;
            IVSamplesDelay = ivSamplesDelay;
            IVSampleRate = ivSampleRate;
        }

        public override string ToString()
        {
            StringBuilder toStringResult = new StringBuilder("IV Curves Settings:" + Environment.NewLine);
            foreach (var property in this.GetType().GetProperties())
            {
                toStringResult.Append(property.Name + ":\t" + property.GetValue(this, null).ToString() + Environment.NewLine);
            }
            return toStringResult.ToString();
        }
    }
}
