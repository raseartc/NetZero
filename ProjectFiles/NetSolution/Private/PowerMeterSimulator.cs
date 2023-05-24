using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "58e895f5e68db40403f4210304f044b7")]
public class PowerMeterSimulator : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public float[] Power
    {
        get
        {
            return (float[])Refs.GetVariable("Power").Value.Value;
        }
        set
        {
            Refs.GetVariable("Power").SetValue(value);
        }
    }
    public IUAVariable PowerVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Power");
        }
    }
    public int PowerSetting
    {
        get
        {
            return (int)Refs.GetVariable("PowerSetting").Value.Value;
        }
        set
        {
            Refs.GetVariable("PowerSetting").SetValue(value);
        }
    }
    public IUAVariable PowerSettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("PowerSetting");
        }
    }
    public int VoltageSetting
    {
        get
        {
            return (int)Refs.GetVariable("VoltageSetting").Value.Value;
        }
        set
        {
            Refs.GetVariable("VoltageSetting").SetValue(value);
        }
    }
    public IUAVariable VoltageSettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("VoltageSetting");
        }
    }
    public float ProductOutPutRate
    {
        get
        {
            return (float)Refs.GetVariable("ProductOutPutRate").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductOutPutRate").SetValue(value);
        }
    }
    public IUAVariable ProductOutPutRateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductOutPutRate");
        }
    }
    public float[] Energy
    {
        get
        {
            return (float[])Refs.GetVariable("Energy").Value.Value;
        }
        set
        {
            Refs.GetVariable("Energy").SetValue(value);
        }
    }
    public IUAVariable EnergyVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Energy");
        }
    }
    public float[] Voltage
    {
        get
        {
            return (float[])Refs.GetVariable("Voltage").Value.Value;
        }
        set
        {
            Refs.GetVariable("Voltage").SetValue(value);
        }
    }
    public IUAVariable VoltageVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Voltage");
        }
    }
    public float[] Current
    {
        get
        {
            return (float[])Refs.GetVariable("Current").Value.Value;
        }
        set
        {
            Refs.GetVariable("Current").SetValue(value);
        }
    }
    public IUAVariable CurrentVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Current");
        }
    }
    public float ProductOutPutTotal
    {
        get
        {
            return (float)Refs.GetVariable("ProductOutPutTotal").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductOutPutTotal").SetValue(value);
        }
    }
    public IUAVariable ProductOutPutTotalVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductOutPutTotal");
        }
    }
    public bool Alarm1
    {
        get
        {
            return (bool)Refs.GetVariable("Alarm1").Value.Value;
        }
        set
        {
            Refs.GetVariable("Alarm1").SetValue(value);
        }
    }
    public IUAVariable Alarm1Variable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Alarm1");
        }
    }
    public FTOptix.NetLogic.NetLogicObject RunPowerMeter
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("RunPowerMeter");
        }
    }
    public float ProductOutPutRateSetting
    {
        get
        {
            return (float)Refs.GetVariable("ProductOutPutRateSetting").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductOutPutRateSetting").SetValue(value);
        }
    }
    public IUAVariable ProductOutPutRateSettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductOutPutRateSetting");
        }
    }
#endregion
}
