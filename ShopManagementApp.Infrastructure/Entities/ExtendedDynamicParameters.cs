using Dapper;
using System.Reflection;
using System.Collections;
using System.Collections.Concurrent;
using ShopManagementApp.Domain.Attributes;

namespace ShopManagementApp.Infrastructure.Entities;

public class ExtendedDynamicParameters : DynamicParameters
{
    private static readonly ConcurrentDictionary<Type, PropertyInfo[]> _propertiesCache = new();

    public ExtendedDynamicParameters(object template)
    {
        ArgumentNullException.ThrowIfNull(template);

        var properties = GetCachedProperties(template.GetType());

        foreach (var prop in properties)
        {
            if (Attribute.IsDefined(prop, typeof(SQLIgnoreAttribute)))
            {
                continue;
            }

            var value = prop.GetValue(template);

            if (value is IEnumerable enumerable and not string)
            {
                string joined = string.Join(",", enumerable.Cast<object>());
                Add(prop.Name, joined);
            }
            else
            {
                Add(prop.Name, value);
            }
        }
    }
    private static PropertyInfo[] GetCachedProperties(Type i_Type)
    {
        if (!_propertiesCache.TryGetValue(i_Type, out PropertyInfo[] value))
        {
            value = i_Type.GetProperties().Where(oPropertyInfo => oPropertyInfo.CanRead).ToArray();
            _propertiesCache[i_Type] = value;
        }

        return value;
    }
}
