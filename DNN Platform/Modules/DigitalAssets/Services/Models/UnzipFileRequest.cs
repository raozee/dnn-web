// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.DigitalAssets.Services.Models
{
    public class UnzipFileRequest
    {
        public int FileId { get; set; }

        public bool Overwrite { get; set; }
    }
}
