namespace StefmDE.MinecraftProperties.Properties.Attributes;

[AttributeUsage(AttributeTargets.Property)] 
public class PropertyMinMaxAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public PropertyMinMaxAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}