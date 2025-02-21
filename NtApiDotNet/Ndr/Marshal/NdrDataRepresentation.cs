﻿//  Copyright 2019 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace NtApiDotNet.Ndr.Marshal
{
#pragma warning disable 1591
    /// <summary>
    /// NDR integer representation.
    /// </summary>
    public enum NdrIntegerRepresentation
    {
        LittleEndian,
        BigEndian
    }

    /// <summary>
    /// NDR character representation.
    /// </summary>
    public enum NdrCharacterRepresentation
    {
        ASCII = 0,
        EBCDIC
    }

    /// <summary>
    /// NDR floating point representation.
    /// </summary>
    public enum NdrFloatingPointRepresentation
    {
        IEEE = 0,
        VAX,
        Cray,
        IBM
    }

    /// <summary>
    /// Definition of the NDR data representation for an NDR stream.
    /// </summary>
    public struct NdrDataRepresentation
    {
        /// <summary>
        /// The integer representation of the NDR data.
        /// </summary>
        public NdrIntegerRepresentation IntegerRepresentation { get; set; }
        /// <summary>
        /// The character representation of the NDR data.
        /// </summary>
        public NdrCharacterRepresentation CharacterRepresentation { get; set; }
        /// <summary>
        /// The floating representation of the NDR data.
        /// </summary>
        public NdrFloatingPointRepresentation FloatingPointRepresentation { get; set; }

        internal NdrDataRepresentation(byte[] data_rep)
        {
            CharacterRepresentation = (NdrCharacterRepresentation)(data_rep[0] & 0xF);
            IntegerRepresentation = (data_rep[0] & 0xF0) == 0 ? NdrIntegerRepresentation.BigEndian : NdrIntegerRepresentation.LittleEndian;
            FloatingPointRepresentation = (NdrFloatingPointRepresentation)data_rep[1];
        }

        internal byte[] ToArray()
        {
            byte[] ret = new byte[4];
            ret[0] = (byte)(IntegerRepresentation == NdrIntegerRepresentation.LittleEndian ? 0x10 : 0);
            ret[0] |= (byte)CharacterRepresentation;
            ret[1] = (byte)FloatingPointRepresentation;
            return ret;
        }
    }
#pragma warning restore 1591
}
