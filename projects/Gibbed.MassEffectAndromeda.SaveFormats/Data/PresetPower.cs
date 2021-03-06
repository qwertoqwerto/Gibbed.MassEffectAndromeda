﻿/* Copyright (c) 2017 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using Gibbed.MassEffectAndromeda.FileFormats;
using Newtonsoft.Json;

namespace Gibbed.MassEffectAndromeda.SaveFormats.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PresetPower
    {
        #region Fields
        private uint _Id;
        private uint _Unknown1;
        private uint _Unknown2;
        private uint _Unknown3;
        #endregion

        #region Properties
        [JsonProperty("id")]
        public uint Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }

        [JsonProperty("unknown1")]
        public uint Unknown1
        {
            get { return this._Unknown1; }
            set { this._Unknown1 = value; }
        }

        [JsonProperty("unknown2")]
        public uint Unknown2
        {
            get { return this._Unknown2; }
            set { this._Unknown2 = value; }
        }

        [JsonProperty("unknown3")]
        public uint Unknown3
        {
            get { return this._Unknown3; }
            set { this._Unknown3 = value; }
        }
        #endregion

        internal void Read(IBitReader reader)
        {
            reader.PushFrameLength(24);
            this._Id = reader.ReadUInt32();
            if (this._Id != 0)
            {
                this._Unknown1 = reader.ReadUInt32();
                this._Unknown2 = reader.ReadUInt32();
                this._Unknown3 = reader.ReadUInt32();
            }
            reader.PopFrameLength();
        }

        internal void Write(IBitWriter writer)
        {
            writer.PushFrameLength(24);
            writer.WriteUInt32(this._Id);
            if (this._Id != 0)
            {
                writer.WriteUInt32(this._Unknown1);
                writer.WriteUInt32(this._Unknown2);
                writer.WriteUInt32(this._Unknown3);
            }
            writer.PopFrameLength();
        }
    }
}
