﻿using CommsWall.Core.Aggregates.ChatMessageAg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommsWall.Infrastructure.ChatSessionsScreen.ManageMessages.SubTasks
{
    public interface IManageMessages
    {
        Tuple<ChatMessage, Dictionary<int, ChatMessage>>? SendMessage(int sessionId, string textMessage);
    }
}
