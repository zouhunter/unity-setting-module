using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomSetting.Prefer;

public class Demo : MonoBehaviour {
    private PlayerPrefsFloat lightValue
    {
        get
        {
            return CustomSetting.Setting.SettingUtil.GetPreferFloat("light");
        }
    }
    private void OnGUI()
    {
        lightValue.value = GUILayout.VerticalSlider(lightValue.value, 0, 2);
    }
}
