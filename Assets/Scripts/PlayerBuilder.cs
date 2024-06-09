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
            Mass = playerData.MassPlayer
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

         playerDataToWrite.MassPlayer = playerObj.Mass;
    }
}