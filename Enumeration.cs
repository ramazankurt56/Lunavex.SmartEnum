using System.Reflection;

public abstract class Enumeration<TValue, TEnum>
    where TValue : notnull
    where TEnum : Enumeration<TValue, TEnum>
{
    private static readonly Dictionary<TValue, TEnum> Enumerations = CreateEnumerations();
    protected Enumeration(TValue value, string displayName)
    {
        Value = value;
        DisplayName = displayName;
    }
    public TValue Value { get; protected init; }
    public string DisplayName { get; protected init; } = string.Empty;

    public static TEnum? FromValue(TValue value)
    {
        return Enumerations.TryGetValue(value, out var enumeration) ? enumeration : default;
    }
    public static TEnum? FromName(string name)
    {
        return Enumerations.Values.SingleOrDefault(e => e.DisplayName == name);
    }
    private static Dictionary<TValue, TEnum> CreateEnumerations()
    {
        var enumerationType = typeof(TEnum);
        var fieldsForType = enumerationType
            .GetFields(
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.FlattenHierarchy)
            .Where(fieldInfo =>
                enumerationType.IsAssignableFrom(fieldInfo.FieldType))
            .Select(fieldInfo =>
                (TEnum)fieldInfo.GetValue(default)!);

        return fieldsForType.ToDictionary(x => x.Value);
    }
}
