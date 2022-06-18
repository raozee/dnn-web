﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Entities
{
    using DotNetNuke.Abstractions.Settings;

    /// <inheritdoc />
    public class ConfigurationSetting : IConfigurationSetting
    {
        /// <inheritdoc />
        public bool IsSecure { get; set; }

        /// <inheritdoc />
        public string Key { get; set; }

        /// <inheritdoc />
        public string Value { get; set; }
    }
}
