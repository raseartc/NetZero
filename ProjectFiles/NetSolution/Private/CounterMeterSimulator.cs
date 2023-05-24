using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "d84707cde289ac0fa8249bfd4a0279ee")]
public class CounterMeterSimulator : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public ulong Counter
    {
        get
        {
            return (ulong)Refs.GetVariable("Counter").Value.Value;
        }
        set
        {
            Refs.GetVariable("Counter").SetValue(value);
        }
    }
    public IUAVariable CounterVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Counter");
        }
    }
    public int CounterPerTenSecond
    {
        get
        {
            return (int)Refs.GetVariable("CounterPerTenSecond").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterPerTenSecond").SetValue(value);
        }
    }
    public IUAVariable CounterPerTenSecondVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CounterPerTenSecond");
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
    public FTOptix.NetLogic.NetLogicObject RunCounterMeter
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("RunCounterMeter");
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
    public int CounterSetting
    {
        get
        {
            return (int)Refs.GetVariable("CounterSetting").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterSetting").SetValue(value);
        }
    }
    public IUAVariable CounterSettingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CounterSetting");
        }
    }
#endregion
}
