using System;

public class PlayerBuilder : IPlayerPack
{
    private PlayerObj player;

    public PlayerObj Pack(PlayerData playerData)
    {
        player = new PlayerObj
        {
            Mass = playerData.MassPlayer
        };
        
        return player;
    }
}