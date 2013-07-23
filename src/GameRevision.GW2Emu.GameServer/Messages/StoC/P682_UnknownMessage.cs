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
    public class P682_UnknownMessage : IMessage
    {
        public int Unknown0;
        public string Unknown1;
        public string Unknown2;
        
        public ushort Header
        {
            get
            {
                return 682;
            }
        }
        
        public ISession Owner {  get;  set; }
        
        public void Serialize(Serializer serializer)
        {
            serializer.Write(Header);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteUtf16String(this.Unknown1);
            serializer.WriteUtf16String(this.Unknown2);
        }
        public void Deserialize(Deserializer deserializer) {}
    }
}