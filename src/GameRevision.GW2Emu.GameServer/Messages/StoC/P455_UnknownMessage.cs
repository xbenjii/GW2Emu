/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 22-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Common;
using GameRevision.GW2Emu.Common.Math;
using GameRevision.GW2Emu.Common.Messaging;
using GameRevision.GW2Emu.Common.Serialization;
using GameRevision.GW2Emu.Common.Session;

namespace GameRevision.GW2Emu.GameServer.Messages.StoC
{
    public class P455_UnknownMessage : IMessage
    {
        public struct Struct0
        {
            public int Unknown1;
            public int Unknown2;
            public Vector3 Unknown3;
            public Vector3 Unknown4;
            public byte Unknown5;
            
            public void Serialize(Serializer serializer)
            {
                serializer.WriteVarint(this.Unknown1);
                serializer.WriteVarint(this.Unknown2);
                serializer.Write(this.Unknown3);
                serializer.Write(this.Unknown4);
                serializer.Write(this.Unknown5);
            }
            public void Deserialize(Deserializer deserializer) {}
        }
        public Struct0[] Unknown6;
        
        public ushort Header
        {
            get
            {
                return 455;
            }
        }
        
        public ISession Owner {  get;  set; }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.Write((byte)Unknown6.Length);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i].Serialize(serializer);
            }
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}
