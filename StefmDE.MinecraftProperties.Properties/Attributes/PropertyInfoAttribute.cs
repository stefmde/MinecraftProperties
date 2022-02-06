namespace StefmDE.MinecraftProperties.Properties.Attributes;

[AttributeUsage(AttributeTargets.Property)] 
public class PropertyInfoAttribute : Attribute
{
    public string IniName { get; }
    
    public object DefaultValue { get; }

    public string? AddedInVersion { get; }

    public PropertyInfoAttribute(string iniName, object defaultValue, string? addedInVersion = null)
    {
        IniName = iniName;
        DefaultValue = defaultValue;
        AddedInVersion = addedInVersion;
    }
}