using System.Text.Encodings.Web;
using System.Text.Json;

namespace Client.Persistence;

public class Storage<T>
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public void Write(List<T> list, string path)
    {
        try
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
            }
            var json = JsonSerializer.Serialize(list, _options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }

    }

    public List<T> Read(string path)
    {
        try
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
            }
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[ ]");
            }
            var json = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<List<T>>(json, _options);

            return data ?? [];
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }

    }
}
