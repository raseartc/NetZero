using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "84c007a918d12cfcdc7c1d8a03026a6d")]
public class CounterMeter : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public bool Enable
    {
        get
        {
            return (bool)Refs.GetVariable("Enable").Value.Value;
        }
        set
        {
            Refs.GetVariable("Enable").SetValue(value);
        }
    }
    public IUAVariable EnableVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Enable");
        }
    }
    public string DeviceName
    {
        get
        {
            return (string)Refs.GetVariable("DeviceName").Value.Value;
        }
        set
        {
            Refs.GetVariable("DeviceName").SetValue(value);
        }
    }
    public IUAVariable DeviceNameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("DeviceName");
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
    public float CounterRate
    {
        get
        {
            return (float)Refs.GetVariable("CounterRate").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterRate").SetValue(value);
        }
    }
    public IUAVariable CounterRateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CounterRate");
        }
    }
    public ulong CounterTotal
    {
        get
        {
            return (ulong)Refs.GetVariable("CounterTotal").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterTotal").SetValue(value);
        }
    }
    public IUAVariable CounterTotalVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CounterTotal");
        }
    }
    public string[] Unit
    {
        get
        {
            return (string[])Refs.GetVariable("Unit").Value.Value;
        }
        set
        {
            Refs.GetVariable("Unit").SetValue(value);
        }
    }
    public IUAVariable UnitVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Unit");
        }
    }
    public float RateToCost
    {
        get
        {
            return (float)Refs.GetVariable("RateToCost").Value.Value;
        }
        set
        {
            Refs.GetVariable("RateToCost").SetValue(value);
        }
    }
    public IUAVariable RateToCostVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("RateToCost");
        }
    }
    public float RateToCarbon
    {
        get
        {
            return (float)Refs.GetVariable("RateToCarbon").Value.Value;
        }
        set
        {
            Refs.GetVariable("RateToCarbon").SetValue(value);
        }
    }
    public IUAVariable RateToCarbonVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("RateToCarbon");
        }
    }
    public float ProductRateThreshold_Low
    {
        get
        {
            return (float)Refs.GetVariable("ProductRateThreshold_Low").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductRateThreshold_Low").SetValue(value);
        }
    }
    public IUAVariable ProductRateThreshold_LowVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductRateThreshold_Low");
        }
    }
    public float ProductRateThreshold_LowLow
    {
        get
        {
            return (float)Refs.GetVariable("ProductRateThreshold_LowLow").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductRateThreshold_LowLow").SetValue(value);
        }
    }
    public IUAVariable ProductRateThreshold_LowLowVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductRateThreshold_LowLow");
        }
    }
    public bool[] Alarms
    {
        get
        {
            return (bool[])Refs.GetVariable("Alarms").Value.Value;
        }
        set
        {
            Refs.GetVariable("Alarms").SetValue(value);
        }
    }
    public IUAVariable AlarmsVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Alarms");
        }
    }
    public string MeterType
    {
        get
        {
            return (string)Refs.GetVariable("MeterType").Value.Value;
        }
        set
        {
            Refs.GetVariable("MeterType").SetValue(value);
        }
    }
    public IUAVariable MeterTypeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MeterType");
        }
    }
    public float ProductOutputTotal
    {
        get
        {
            return (float)Refs.GetVariable("ProductOutputTotal").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductOutputTotal").SetValue(value);
        }
    }
    public IUAVariable ProductOutputTotalVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductOutputTotal");
        }
    }
    public double CounterRateWindows
    {
        get
        {
            return (double)Refs.GetVariable("CounterRateWindows").Value.Value;
        }
        set
        {
            Refs.GetVariable("CounterRateWindows").SetValue(value);
        }
    }
    public IUAVariable CounterRateWindowsVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("CounterRateWindows");
        }
    }
    public float RatePerCounter
    {
        get
        {
            return (float)Refs.GetVariable("RatePerCounter").Value.Value;
        }
        set
        {
            Refs.GetVariable("RatePerCounter").SetValue(value);
        }
    }
    public IUAVariable RatePerCounterVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("RatePerCounter");
        }
    }
    public string ProductID
    {
        get
        {
            return (string)Refs.GetVariable("ProductID").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductID").SetValue(value);
        }
    }
    public IUAVariable ProductIDVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductID");
        }
    }
    public string ShiftConsumptionTableName
    {
        get
        {
            return (string)Refs.GetVariable("ShiftConsumptionTableName").Value.Value;
        }
        set
        {
            Refs.GetVariable("ShiftConsumptionTableName").SetValue(value);
        }
    }
    public IUAVariable ShiftConsumptionTableNameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ShiftConsumptionTableName");
        }
    }
    public string MultiRateConsumptionTableName
    {
        get
        {
            return (string)Refs.GetVariable("MultiRateConsumptionTableName").Value.Value;
        }
        set
        {
            Refs.GetVariable("MultiRateConsumptionTableName").SetValue(value);
        }
    }
    public IUAVariable MultiRateConsumptionTableNameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MultiRateConsumptionTableName");
        }
    }
    public string ProductConsumptionTableName
    {
        get
        {
            return (string)Refs.GetVariable("ProductConsumptionTableName").Value.Value;
        }
        set
        {
            Refs.GetVariable("ProductConsumptionTableName").SetValue(value);
        }
    }
    public IUAVariable ProductConsumptionTableNameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ProductConsumptionTableName");
        }
    }
    public string Group
    {
        get
        {
            return (string)Refs.GetVariable("Group").Value.Value;
        }
        set
        {
            Refs.GetVariable("Group").SetValue(value);
        }
    }
    public IUAVariable GroupVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Group");
        }
    }
    public FTOptix.NetLogic.NetLogicObject RecordCounter
    {
        get
        {
            return (FTOptix.NetLogic.NetLogicObject)Refs.GetObject("RecordCounter");
        }
    }
    public UAManagedCore.NodeId Logger
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("Logger").Value.Value;
        }
        set
        {
            Refs.GetVariable("Logger").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer LoggerVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("Logger");
        }
    }
    public UAManagedCore.NodeId ShiftStatistics
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("ShiftStatistics").Value.Value;
        }
        set
        {
            Refs.GetVariable("ShiftStatistics").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer ShiftStatisticsVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("ShiftStatistics");
        }
    }
    public UAManagedCore.NodeId RateStatistics
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("RateStatistics").Value.Value;
        }
        set
        {
            Refs.GetVariable("RateStatistics").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer RateStatisticsVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("RateStatistics");
        }
    }
    public FTOptix.CoreBase.VariableChangedEventDispatcher ProductIDChanged
    {
        get
        {
            return (FTOptix.CoreBase.VariableChangedEventDispatcher)Refs.GetObject("ProductIDChanged");
        }
    }
    public double Efficency
    {
        get
        {
            return (double)Refs.GetVariable("Efficency").Value.Value;
        }
        set
        {
            Refs.GetVariable("Efficency").SetValue(value);
        }
    }
    public IUAVariable EfficencyVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Efficency");
        }
    }
#endregion
}
