using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;

public class LoadPlayer : MonoBehaviour {

    [SerializeField]
    private PlayerData playerData;

    [SerializeField]
    private UiPlayerData uiPlayerData;

    private const string fileName = "settings.json";

    public void Load(){
        string jsonData = null;
        using (var stream = new FileStream(Application.persistentDataPath + "/" + fileName, FileMode.Open)){
            using (var reader = new StreamReader(stream)){
                jsonData = reader.ReadToEnd();
            }
        }

        if (jsonData != null){
            var player = JsonConvert.DeserializeObject<PlayerObj>(jsonData);
            var playerBuilder = new PlayerBuilder();
            playerBuilder.Unpack(playerData, player);
            uiPlayerData.UpdateAllData();
        }
    }
}