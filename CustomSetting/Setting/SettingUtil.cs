using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomSetting.Setting
{
    public static class SettingUtil
    {
        private static Dictionary<string, Prefer.PlayerPrefsInt> intDic = new Dictionary<string, Prefer.PlayerPrefsInt>();
        private static Dictionary<string, Prefer.PlayerPrefsFloat> floatDic = new Dictionary<string, Prefer.PlayerPrefsFloat>();
        private static Dictionary<string, Prefer.PlayerPrefsString> stringDic = new Dictionary<string, Prefer.PlayerPrefsString>();

        public static Prefer.PlayerPrefsString GetPreferString(string key)
        {
            if (!stringDic.ContainsKey(key) || stringDic[key] == null)
            {
                stringDic[key] = new Prefer.PlayerPrefsString(key);
            }
            return stringDic[key];
        }
        public static Prefer.PlayerPrefsInt GetPreferInt(string key)
        {
            if (!intDic.ContainsKey(key) || intDic[key] == null)
            {
                intDic[key] = new Prefer.PlayerPrefsInt(key);
            }
            return intDic[key];
        }

        public static Prefer.PlayerPrefsFloat GetPreferFloat(string key)
        {
            if (!floatDic.ContainsKey(key) || floatDic[key] == null){
                floatDic[key] = new Prefer.PlayerPrefsFloat(key);
            }
            return floatDic[key];
        }
    }

}