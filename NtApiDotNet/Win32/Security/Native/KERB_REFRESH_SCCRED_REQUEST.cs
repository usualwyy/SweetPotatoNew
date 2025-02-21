﻿//  Copyright 2020 Google Inc. All Rights Reserved.
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

using System.Runtime.InteropServices;

namespace NtApiDotNet.Win32.Security.Native
{
    internal enum KERB_REFRESH_SCCRED_REQUEST_FLAGS
    {
        KERB_REFRESH_SCCRED_RELEASE = 0,
        KERB_REFRESH_SCCRED_GETTGT = 1,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct KERB_REFRESH_SCCRED_REQUEST
    {
        public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
        public UnicodeStringOut CredentialBlob;
        public Luid LogonId;
        public KERB_REFRESH_SCCRED_REQUEST_FLAGS Flags;
    }
}
