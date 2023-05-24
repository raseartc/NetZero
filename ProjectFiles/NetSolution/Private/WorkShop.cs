using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "NetZero", Guid = "25f53ca38296f5915e5664963fe72eba")]
public class WorkShop : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Energy
    {
        get
        {
            return (string)Refs.GetVariable("Energy").Value.Value;
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
    public string Carbon
    {
        get
        {
            return (string)Refs.GetVariable("Carbon").Value.Value;
        }
        set
        {
            Refs.GetVariable("Carbon").SetValue(value);
        }
    }
    public IUAVariable CarbonVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Carbon");
        }
    }
    public float MonthyEnergyConsumption
    {
        get
        {
            return (float)Refs.GetVariable("MonthyEnergyConsumption").Value.Value;
        }
        set
        {
            Refs.GetVariable("MonthyEnergyConsumption").SetValue(value);
        }
    }
    public IUAVariable MonthyEnergyConsumptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MonthyEnergyConsumption");
        }
    }
    public float MonthyEnergyCost
    {
        get
        {
            return (float)Refs.GetVariable("MonthyEnergyCost").Value.Value;
        }
        set
        {
            Refs.GetVariable("MonthyEnergyCost").SetValue(value);
        }
    }
    public IUAVariable MonthyEnergyCostVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MonthyEnergyCost");
        }
    }
    public short MonthyService
    {
        get
        {
            return (short)Refs.GetVariable("MonthyService").Value.Value;
        }
        set
        {
            Refs.GetVariable("MonthyService").SetValue(value);
        }
    }
    public IUAVariable MonthyServiceVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("MonthyService");
        }
    }
#endregion
}
