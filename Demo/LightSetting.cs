using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomSetting.Setting;

[RequireComponent(typeof(Light))]
public class LightSetting : SettingBase
{
    [SerializeField]
    private Light m_light;
    public override string preferKey
    {
        get
        {
            return "light";
        }
    }

    private void Awake()
    {
        if(m_light == null)
        {
            m_light = gameObject.GetComponent<Light>();
        }
    }

    private void OnEnable()
    {
        prefer_float.onValueChanged += OnLightSettingDataChanged;
        OnLightSettingDataChanged(prefer_float.value);
    }

    private void OnDisable()
    {
        prefer_float.onValueChanged -= OnLightSettingDataChanged;
       
    }
    private void Update()
    {
        prefer_float.value = m_light.intensity;
    }

    private void OnLightSettingDataChanged(float arg0)
    {
        m_light.intensity = arg0;
    }

}
