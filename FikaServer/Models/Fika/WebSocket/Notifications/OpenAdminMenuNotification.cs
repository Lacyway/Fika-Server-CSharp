﻿using FikaServer.Models.Enums;
using System.Text.Json.Serialization;

namespace FikaServer.Models.Fika.WebSocket.Notifications;

public record OpenAdminMenuNotification : IFikaNotification
{
    public OpenAdminMenuNotification(bool success)
    {
        Success = success;
    }

    [JsonPropertyName("type")]
    public EFikaNotification Type { get; set; } = EFikaNotification.OpenAdminSettings;

    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
