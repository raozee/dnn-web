// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Modules.DigitalAssets.Components.ExtensionPoint.UserControls
{
    using System;
    using System.ComponentModel.Composition;

    using DotNetNuke.ExtensionPoints;

    [Export(typeof(IUserControlExtensionPoint))]
    [ExportMetadata("Module", "DigitalAssets")]
    [ExportMetadata("Name", "FileFieldsControlExtensionPoint")]
    [ExportMetadata("Group", "ViewProperties")]
    [ExportMetadata("Priority", 2)]
    public class FileFieldsControlExtensionPoint : IUserControlExtensionPoint
    {
        public string UserControlSrc
        {
            get { return "~/DesktopModules/DigitalAssets/FileFieldsControl.ascx"; }
        }

        public string Text
        {
            get { return string.Empty; }
        }

        public string Icon
        {
            get { return string.Empty; }
        }

        public int Order
        {
            get { return 1; }
        }

        public bool Visible
        {
            get { return true; }
        }
    }
}
