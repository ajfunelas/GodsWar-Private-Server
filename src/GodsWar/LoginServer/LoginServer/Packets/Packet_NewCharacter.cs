﻿namespace LoginServer
{
    public partial class Systems
    {
        public static byte[] NewCharacterPacket()
        {
            byte[] datasend = new byte[] {
            //0x54, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            //0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            //0x00, 0x00, 0x00, 0x00, 0x54, 0x68, 0x65, 0x61, 0x00, 0x5B, 0xF4, 0x01, 0xC4, 0xD1, 0x40, 0x00,
            //0x80, 0xC1, 0x85, 0x65, 0x80, 0x5B, 0xF4, 0x01, 0x88, 0x5B, 0xF4, 0x01, 0x58, 0xC1, 0x85, 0x65,
            //0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xBF, 0x40, 0x00, 0x23, 0x00, 0x00, 0x00,
            //0x02, 0x00, 0x01, 0x01

            0x54, 0x00, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x4D, 0x69, 0x6E, 0x6F, 0x73, 0x00, 0x29, 0x00, 0xC4, 0xD1, 0x40, 0x00,
            0x78, 0x91, 0x36, 0x57, 0xC0, 0x37, 0x29, 0x00, 0xC8, 0x37, 0x29, 0x00, 0x50, 0x91, 0x36, 0x57,
            0x0A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0xBF, 0x40, 0x00, 0x13, 0x00, 0x00, 0x00,
            0x02, 0x00, 0x01, 0x01
            };
            return datasend;
        }
    }
}