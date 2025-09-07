﻿using SPTarkov.Server.Core.Models.Utils;
using System.Text.Json.Serialization;

namespace FikaServer.Models.Fika.Routes.Raid.Join;

public record FikaUpdateRaidAddPlayerData : IRequestData
{
    [JsonPropertyName("serverId")]
    public string ServerId { get; set; } = string.Empty;
    [JsonPropertyName("profileId")]
    public string ProfileId { get; set; } = string.Empty;
    [JsonPropertyName("isSpectator")]
    public bool IsSpectator { get; set; }
}
