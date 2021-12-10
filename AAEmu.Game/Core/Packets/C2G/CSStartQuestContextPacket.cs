﻿using System.Threading.Tasks;

using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSStartQuestContextPacket : GamePacket
    {
        private uint _questContextId;
        private uint _npcObjId;
        private uint _doodadObjId;
        private uint _sphereId;

        public CSStartQuestContextPacket() : base(CSOffsets.CSStartQuestContextPacket, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            _questContextId = stream.ReadUInt32(); // questContextId
            _npcObjId = stream.ReadBc();           // npcObjId
            _doodadObjId = stream.ReadBc();        // doodadObjId
            _sphereId = stream.ReadUInt32();       // selected

        }
        public override async Task Execute()
        {
            if (
                _npcObjId > 0
                && Connection.ActiveChar.CurrentTarget != null
                && Connection.ActiveChar.CurrentTarget.ObjId != _npcObjId
               )
            {
                return;
            }

            Connection.ActiveChar.Quests.Add(_questContextId);
        }
    }
}
