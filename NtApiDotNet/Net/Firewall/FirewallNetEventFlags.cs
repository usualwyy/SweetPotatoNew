﻿//  Copyright 2021 Google LLC. All Rights Reserved.
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

using NtApiDotNet.Utilities.Reflection;
using System;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace NtApiDotNet.Net.Firewall
{
    /// <summary>
    /// Flags for a network event.
    /// </summary>
    [Flags]
    public enum FirewallNetEventFlags
    {
        [SDKName("FWPM_NET_EVENT_FLAG_IP_PROTOCOL_SET")]
        IpProtocolSet = 0x00000001,
        [SDKName("FWPM_NET_EVENT_FLAG_LOCAL_ADDR_SET")]
        LocalAddrSet  = 0x00000002,
        [SDKName("FWPM_NET_EVENT_FLAG_REMOTE_ADDR_SET")]
        RemoteAddrSet = 0x00000004,
        [SDKName("FWPM_NET_EVENT_FLAG_LOCAL_PORT_SET")]
        LocalPortSet  = 0x00000008,
        [SDKName("FWPM_NET_EVENT_FLAG_REMOTE_PORT_SET")]
        RemotePortSet = 0x00000010,
        [SDKName("FWPM_NET_EVENT_FLAG_APP_ID_SET")]
        AppIdSet      = 0x00000020,
        [SDKName("FWPM_NET_EVENT_FLAG_USER_ID_SET")]
        UserIdSet     = 0x00000040,
        [SDKName("FWPM_NET_EVENT_FLAG_SCOPE_ID_SET")]
        ScopeIdSet    = 0x00000080,
        [SDKName("FWPM_NET_EVENT_FLAG_IP_VERSION_SET")]
        IpVersionSet  = 0x00000100,
        [SDKName("FWPM_NET_EVENT_FLAG_REAUTH_REASON_SET")]
        ReAuthReasonSet = 0x00000200,
        [SDKName("FWPM_NET_EVENT_FLAG_PACKAGE_ID_SET")]
        PackageIdSet  = 0x00000400,
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member