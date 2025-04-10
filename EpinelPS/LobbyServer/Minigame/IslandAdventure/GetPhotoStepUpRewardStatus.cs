﻿using EpinelPS.Utils;

namespace EpinelPS.LobbyServer.Minigame.IslandAdventure
{
    [PacketPath("/event/minigame/islandadventure/get/photo/stepupreward")]
    public class GetPhotoStepUpRewardStatus : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqGetIslandAdventurePhotoStepUpRewardStatus>();

            var response = new ResGetIslandAdventurePhotoStepUpRewardStatus();
            // TODO
            await WriteDataAsync(response);
        }
    }
}
