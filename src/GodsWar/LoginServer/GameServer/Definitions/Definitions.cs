﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Systems
    {
        public static string DownloadServer = "";
        public static Int16 DownloadPort = 15000;
        internal Client client;
        internal Decode PacketInformation;
        //private byte WrongPassword = 1;
        //static short User_Current;

        public Systems(Client de)
        {
            client = de;
        }
    }
}