[test.ini]
``` Offline=true ``` 

ReadINI("Offline",StaticDataManager.appSettings);

public string ReadINI(string key, string path)
{
  var result = File.ReadAllText(path).Split('\r', '\n').First(st => st.StartsWith(key));
  return result.Split('=')[1];
}
