using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace OpenCC.NET
{
    internal class Setting
    {
        //Constructor
        private Setting()
        {
            //default setting
            this.SourceType = "s";
            this.TargetType = "tw";
            this.EnableWordChange = true;
            this.EnableCopyToClip = true;
        }
        private Setting(string sourceType, string targetType, bool enableWordChange, bool enableCopyToClip)
        {
            this.SourceType = sourceType;
            this.TargetType = targetType;
            this.EnableWordChange = enableWordChange;
            this.EnableCopyToClip = enableCopyToClip;
        }

        //Singleton
        private static Setting? _instance;
        private static readonly object _lock = new();
        public static Setting GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Setting();
                    }
                }
            }
            return _instance;
        }
        public static Setting GetInstance(string sourceType, string targetType, bool enableWordChange, bool enableCopyToClip)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Setting(sourceType, targetType, enableWordChange, enableCopyToClip);
                    }
                }
            }
            else
            {
                _instance.SourceType = sourceType;
                _instance.TargetType = targetType;
                _instance.EnableWordChange = enableWordChange;
                _instance.EnableCopyToClip = enableCopyToClip;
            }
            return _instance;
        }

        //Attribute
        public string SourceType { get; set; }
        public string TargetType { get; set; }
        public bool EnableWordChange { get; set; }
        public bool EnableCopyToClip { get; set; }

        //Method
        //instance to file
        public async Task SaveAsync()
        {
            string fileName = "setting.json";
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, GetInstance());
            await createStream.DisposeAsync();
        }
        //file to instance
        public void Load()
        {
            string fileName = "setting.json";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(GetInstance()));
            }
            string jsonString = File.ReadAllText(fileName);
            JObject jo = JObject.Parse(jsonString);
            GetInstance(jo[nameof(SourceType)]!.ToString(), jo[nameof(TargetType)]!.ToString(),
                (bool)jo[nameof(EnableWordChange)]!, (bool)jo[nameof(EnableCopyToClip)]!);
        }
    }
}
