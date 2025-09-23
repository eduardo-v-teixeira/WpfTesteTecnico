using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;

namespace WpfTesteTecnico.Services
{
    public class DataService<T>
    {
        private readonly string _filePath;
        private readonly JsonSerializerSettings _settings;

        public DataService(string filePath)
        {
            _filePath = filePath;
            _settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter> { new StringEnumConverter() }
            };
        }

        public List<T> Load()
        {
            if (!File.Exists(_filePath)) return new List<T>();
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<T>>(json, _settings) ?? new List<T>();
        }

        public void Save(List<T> items)
        {
            var dir = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);

            var json = JsonConvert.SerializeObject(items, _settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
