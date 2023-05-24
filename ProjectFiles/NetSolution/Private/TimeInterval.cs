using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "ccb5a908f976bf60f62e2066074a5f0c")]
public class TimeInterval : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public bool Beused
    {
        get
        {
            return (bool)Refs.GetVariable("Beused").Value.Value;
        }
        set
        {
            Refs.GetVariable("Beused").SetValue(value);
        }
    }
    public IUAVariable BeusedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Beused");
        }
    }
    public DateTime StartTime
    {
        get
        {
            return (DateTime)Refs.GetVariable("StartTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("StartTime").SetValue(value);
        }
    }
    public IUAVariable StartTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StartTime");
        }
    }
    public DateTime EndTime
    {
        get
        {
            return (DateTime)Refs.GetVariable("EndTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("EndTime").SetValue(value);
        }
    }
    public IUAVariable EndTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("EndTime");
        }
    }
    public bool Working
    {
        get
        {
            return (bool)Refs.GetVariable("Working").Value.Value;
        }
        set
        {
            Refs.GetVariable("Working").SetValue(value);
        }
    }
    public IUAVariable WorkingVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Working");
        }
    }
    public FTOptix.CoreBase.VariableConditionEventDispatcher WorkingTransitioned
    {
        get
        {
            return (FTOptix.CoreBase.VariableConditionEventDispatcher)Refs.GetObject("WorkingTransitioned");
        }
    }
    public FTOptix.CoreBase.VariableConditionEventDispatcher WorkingTransitioned1
    {
        get
        {
            return (FTOptix.CoreBase.VariableConditionEventDispatcher)Refs.GetObject("WorkingTransitioned1");
        }
    }
    public double RateToCost
    {
        get
        {
            return (double)Refs.GetVariable("RateToCost").Value.Value;
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
    public string ID
    {
        get
        {
            return (string)Refs.GetVariable("ID").Value.Value;
        }
        set
        {
            Refs.GetVariable("ID").SetValue(value);
        }
    }
    public IUAVariable IDVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("ID");
        }
    }
#endregion
}
