using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopManagementApp.Common.Utilities;

public static partial class JsonUtilities
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static string Serialize<T>(this T obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        try
        {
            return JsonSerializer.Serialize(obj, JsonSerializerOptions);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Serialization failed.", ex);
        }
    }

    public static T Deserialize<T>(this string jsonString)
    {
        if (string.IsNullOrWhiteSpace(jsonString))
        {
            throw new ArgumentNullException(nameof(jsonString));
        }

        try
        {
            return JsonSerializer.Deserialize<T>(jsonString, JsonSerializerOptions) ?? throw new InvalidOperationException("Deserialization resulted in null.");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Deserialization failed.", ex);
        }
    }

    public static async Task<string> SerializeAsync<T>(this T obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        try
        {
            using var memoryStream = new MemoryStream();

            await JsonSerializer.SerializeAsync(memoryStream, obj, JsonSerializerOptions).ConfigureAwait(false);

            memoryStream.Position = 0;

            using var reader = new StreamReader(memoryStream);
            return await reader.ReadToEndAsync().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Async serialization failed.", ex);
        }
    }

    public static async Task<T> DeserializeAsync<T>(this string jsonString)
    {
        if (string.IsNullOrWhiteSpace(jsonString))
        {
            throw new ArgumentNullException(nameof(jsonString));
        }

        try
        {
            using var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            var result = await JsonSerializer.DeserializeAsync<T>(memoryStream, JsonSerializerOptions).ConfigureAwait(false);
            return result ?? throw new InvalidOperationException("Async deserialization resulted in null.");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Async deserialization failed.", ex);
        }
    }
}
