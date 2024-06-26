using System;

public class PlayerBuilder : IPlayerPack
{
    public PlayerObj Pack(PlayerData playerData)
    {
        if (playerData == null){
            throw new ArgumentNullException(nameof(playerData), "Cannot pack null player data.");
        }

        var player = new PlayerObj
        {
            Name = playerData.Name,
            Mass = playerData.MassPlayer,
            Height = playerData.HeightPlayer,
            Width = playerData.WidthPlayer,
            IndexHat = playerData.IndexHat
        };
        
        return player;
    }

    public void Unpack(PlayerData playerDataToWrite, PlayerObj playerObj)
    {
        if (playerDataToWrite == null){
            throw new ArgumentNullException(nameof(playerDataToWrite));
         }

         if (playerObj == null){
            throw new ArgumentNullException(nameof(playerObj));
         }

         playerDataToWrite.Name = playerObj.Name;
         playerDataToWrite.MassPlayer = playerObj.Mass;
         playerDataToWrite.HeightPlayer = playerObj.Height;
         playerDataToWrite.WidthPlayer = playerObj.Width;
         playerDataToWrite.IndexHat = playerObj.IndexHat;
    }
}