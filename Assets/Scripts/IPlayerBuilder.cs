public interface IPlayerPack {
    PlayerObj Pack(PlayerData playerData);
    void Unpack(PlayerData playerDataToWrite, PlayerObj playerObj);
}