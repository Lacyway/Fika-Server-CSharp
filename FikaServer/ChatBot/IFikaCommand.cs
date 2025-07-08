﻿using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Dialog;
using SPTarkov.Server.Core.Models.Eft.Profile;

namespace FikaServer.ChatBot
{
    public interface IFikaCommand
    {
        public string Command { get; }
        public string CommandHelp { get; }
        public ValueTask<string> PerformAction(UserDialogInfo commandHandler, MongoId sessionId, SendMessageRequest request);
    }
}
