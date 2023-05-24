using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace OpenCC.NET
{
    internal class Setting
    {
        //构造方法
        private Setting()
        {
            //默认设置
            SourceType = "s";
            TargetType = "tw";
            EnableWordChange = true;
            EnableCopyToClip = true;
            PositionX = 100;
            PositionY = 100;
            SizeX = 773;
            SizeY = 535;
        }
        private Setting(
            string sourceType, string targetType,
            bool enableWordChange, bool enableCopyToClip,
            int positionX, int positionY,
            int sizeX, int sizeY)
        {
            SourceType = sourceType; TargetType = targetType;
            EnableWordChange = enableWordChange; EnableCopyToClip = enableCopyToClip;
            PositionX = positionX; PositionY = positionY;
            SizeX = sizeX; SizeY = sizeY;
        }

        //单例
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
        public static Setting GetInstance(
            string sourceType, string targetType,
            bool enableWordChange, bool enableCopyToClip,
            int positionX, int positionY,
            int sizeX, int sizeY)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Setting(
                            sourceType, targetType,
                            enableWordChange, enableCopyToClip,
                            positionX, positionY, sizeX, sizeY);
                    }
                }
            }
            else
            {
                _instance.SourceType = sourceType;
                _instance.TargetType = targetType;
                _instance.EnableWordChange = enableWordChange;
                _instance.EnableCopyToClip = enableCopyToClip;
                _instance.PositionX = positionX;
                _instance.PositionY = positionY;
                _instance.SizeX = sizeX;
                _instance.SizeY = sizeY;
            }
            return _instance;
        }

        //属性
        public string SourceType { get; set; }
        public string TargetType { get; set; }
        public bool EnableWordChange { get; set; }
        public bool EnableCopyToClip { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        //方法
        //instance to file
        public async Task SaveAsync()
        {
            string fileName = "setting.json";
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, GetInstance());
            await createStream.DisposeAsync();
        }
        //file to instance
        public Setting Load()
        {
            string fileName = "setting.json";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(GetInstance()));
            }
            string jsonString = File.ReadAllText(fileName);
            JObject jo = JObject.Parse(jsonString);
            return GetInstance(
                  jo[nameof(SourceType)]!.ToString(), jo[nameof(TargetType)]!.ToString(),
                  (bool)jo[nameof(EnableWordChange)]!, (bool)jo[nameof(EnableCopyToClip)]!,
                  (int)jo[nameof(PositionX)]!, (int)jo[nameof(PositionY)]!,
                  (int)jo[nameof(SizeX)]!, (int)jo[nameof(SizeY)]!);
        }
    }
}
