namespace StefmDE.MinecraftProperties.Properties.Models;

public class PropertyWrapper<T>
{
    internal PropertyWrapper(string iniName, T defaultValue, Version? addedInVersion, string? description, int? minValue, int? maxValue)
    {
        IniName = iniName;
        Value = defaultValue;
        DefaultValue = defaultValue;
        AddedInVersion = addedInVersion;
        Description = description;
        MinValue = minValue;
        MaxValue = maxValue;
    }
    
    public T Value { get; private set; }
    
    public T DefaultValue { get; }
    
    public int? MinValue { get; }
    
    public int? MaxValue { get; }
    
    public Version? AddedInVersion { get; }
    
    public string? Description { get; }
    
    public string IniName { get; }

    public bool IsDefault { get; private set; } = true;

    public void ResetToDefault()
    {
        Value = DefaultValue;
        IsDefault = true;
    }

    public void SetValue(T newValue)
    {
        // Prevent setting default Value
        if (newValue is not null && newValue.Equals(Value))
        {
            return;
        }
        Value = newValue;
        IsDefault = false;
    }
}