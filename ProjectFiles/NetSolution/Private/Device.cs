using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "f7f6eaecb9c87ca11c1f3e074321fe2a")]
public class Device : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public UAManagedCore.NodeId PowerMeter1
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("PowerMeter1").Value.Value;
        }
        set
        {
            Refs.GetVariable("PowerMeter1").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer PowerMeter1Variable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("PowerMeter1");
        }
    }
    public UAManagedCore.NodeId GeneralMeter1
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("GeneralMeter1").Value.Value;
        }
        set
        {
            Refs.GetVariable("GeneralMeter1").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer GeneralMeter1Variable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("GeneralMeter1");
        }
    }
    public UAManagedCore.NodeId CounterMeter1
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("CounterMeter1").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterMeter1").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer CounterMeter1Variable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("CounterMeter1");
        }
    }
    public float TotalCostRate
    {
        get
        {
            return (float)Refs.GetVariable("TotalCostRate").Value.Value;
        }
        set
        {
            Refs.GetVariable("TotalCostRate").SetValue(value);
        }
    }
    public IUAVariable TotalCostRateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TotalCostRate");
        }
    }
    public float ProductOutputRate
    {
        get
        {
            return (float)Refs.GetVariable("ProductOutputRate").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductOutputRate").SetValue(value);
        }
    }
    public IUAVariable ProductOutputRateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductOutputRate");
        }
    }
    public float TotalCarbonRate
    {
        get
        {
            return (float)Refs.GetVariable("TotalCarbonRate").Value.Value;
        }
        set
        {
            Refs.GetVariable("TotalCarbonRate").SetValue(value);
        }
    }
    public IUAVariable TotalCarbonRateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TotalCarbonRate");
        }
    }
    public float Energyefficiency
    {
        get
        {
            return (float)Refs.GetVariable("Energyefficiency").Value.Value;
        }
        set
        {
            Refs.GetVariable("Energyefficiency").SetValue(value);
        }
    }
    public IUAVariable EnergyefficiencyVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Energyefficiency");
        }
    }
    public UAManagedCore.NodeId PowerMeter1Trend
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("PowerMeter1Trend").Value.Value;
        }
        set
        {
            Refs.GetVariable("PowerMeter1Trend").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer PowerMeter1TrendVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("PowerMeter1Trend");
        }
    }
    public UAManagedCore.NodeId GeneralMeter1Trend
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("GeneralMeter1Trend").Value.Value;
        }
        set
        {
            Refs.GetVariable("GeneralMeter1Trend").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer GeneralMeter1TrendVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("GeneralMeter1Trend");
        }
    }
    public UAManagedCore.NodeId CounterMeter1Trend
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("CounterMeter1Trend").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterMeter1Trend").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer CounterMeter1TrendVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("CounterMeter1Trend");
        }
    }
    public UAManagedCore.NodeId DeviceTrend
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("DeviceTrend").Value.Value;
        }
        set
        {
            Refs.GetVariable("DeviceTrend").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer DeviceTrendVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("DeviceTrend");
        }
    }
#endregion
}
