using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "036cfb163f87835dcae679c64a91adc6")]
public class GeneralMeterSimulator : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public float MeterSpeed
    {
        get
        {
            return (float)Refs.GetVariable("MeterSpeed").Value.Value;
        }
        set
        {
            Refs.GetVariable("MeterSpeed").SetValue(value);
        }
    }
    public IUAVariable MeterSpeedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MeterSpeed");
        }
    }
    public int SpeedSetting
    {
        get
        {
            return (int)Refs.GetVariable("SpeedSetting").Value.Value;
        }
        set
        {
            Refs.GetVariable("SpeedSetting").SetValue(value);
        }
    }
    public IUAVariable SpeedSettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("SpeedSetting");
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
    public float MeterTotal
    {
        get
        {
            return (float)Refs.GetVariable("MeterTotal").Value.Value;
        }
        set
        {
            Refs.GetVariable("MeterTotal").SetValue(value);
        }
    }
    public IUAVariable MeterTotalVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MeterTotal");
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
    public FTOptix.NetLogic.NetLogicObject RunGeneralMeter
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("RunGeneralMeter");
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
