﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SteamKit
{
    public enum EAccountType : int
    {
        Invalid = 0,

        Individual = 1,
        Multiseat = 2,
        GameServer = 3,
        AnonGameServer = 4,
        Pending = 5,
        ContentServer = 6,
        Clan = 7,
        Chat = 8,
        P2PSuperSeeder = 9,
        AnonUser = 10,

        Max = 11,
    };
}
