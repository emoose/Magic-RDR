using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Magic_RDR
{
	class NativeHashDB
	{
		const string _NativesPath = "natives.json";
		static Dictionary<uint, string> _db = new Dictionary<uint, string>();
		static bool _inited = false;

		static void LoadNatives()
		{
			if (!File.Exists(_NativesPath))
				return;

			string jsonContent = File.ReadAllText(_NativesPath);
			JObject jsonObject = JObject.Parse(jsonContent);

			_db = new Dictionary<uint, string>();
			foreach (var ns in jsonObject.Properties())
			{
				JObject systemObject = (JObject)ns.Value;

				foreach (var item in systemObject.Properties())
				{
					string key = item.Name;
					if (key.StartsWith("0x"))
						key = key.Substring(2);

					string name = item.Value["name"]?.ToString() ?? "";

					if (name.StartsWith("_0x"))
						continue;

					if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(name))
					{
						uint key_int = 0;
						if (uint.TryParse(key, System.Globalization.NumberStyles.HexNumber, null, out key_int))
							_db[key_int] = name.ToUpper();

					}
				}
			}
			_inited = true;
		}

		public static string GetName(uint hash)
		{
			if (!_inited)
				LoadNatives();

			if (_db.ContainsKey(hash))
				return _db[hash];

			return $"UNK_0x{hash:X8}";
		}
	}
}
