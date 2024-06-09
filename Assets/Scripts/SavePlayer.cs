using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class SavePlayer : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;
    private const string fileName = "settings.json";

    public void Save(){
        var playerBuilder = new PlayerBuilder();
        var player = playerBuilder.Pack(playerData);
        
        var playerJson = JsonConvert.SerializeObject(player);

        using (var fs = new FileStream(Application.persistentDataPath + "/" + fileName, FileMode.OpenOrCreate)){
            using (var sw = new StreamWriter(fs)) {
                sw.Write(playerJson);
            }
        }
    }
}
