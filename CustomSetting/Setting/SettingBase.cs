using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomSetting.Setting
{
    public abstract class SettingBase : MonoBehaviour
    {
        public abstract string preferKey { get; }
        public Prefer.PlayerPrefsFloat prefer_float
        {
            get
            {
                return SettingUtil.GetPreferFloat(preferKey);
            }
        }
        public Prefer.PlayerPrefsInt prefer_int
        {
            get
            {
                return SettingUtil.GetPreferInt(preferKey);
            }
        }
        public Prefer.PlayerPrefsString prefer_string
        {
            get
            {
                return SettingUtil.GetPreferString(preferKey);
            }
        }
    }
}
