﻿using DS4Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4WinWPF.DS4Library.InputDevices
{
    public enum InputDeviceType : uint
    {
        DS4,
        SwitchPro,
        JoyConL,
        JoyConR,
    }

    public abstract class InputDeviceFactory
    {
        public static DS4Device CreateDevice(InputDeviceType tempType,
            HidDevice hidDevice, string disName, VidPidFeatureSet featureSet = VidPidFeatureSet.DefaultDS4)
        {
            DS4Device temp = null;

            switch(tempType)
            {
                case InputDeviceType.DS4:
                    temp = new DS4Device(hidDevice, disName, featureSet);
                    break;
                case InputDeviceType.SwitchPro:
                    temp = new SwitchProDevice(hidDevice, disName, featureSet);
                    break;
            }

            return temp;
        }
    }
}