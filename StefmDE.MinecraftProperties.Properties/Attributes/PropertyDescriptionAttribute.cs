namespace StefmDE.MinecraftProperties.Properties.Attributes;

[AttributeUsage(AttributeTargets.Property)] 
public class PropertyDescriptionAttribute : Attribute
{
    public string Description { get; }

    public PropertyDescriptionAttribute(string description)
    {
        Description = description;
    }
}