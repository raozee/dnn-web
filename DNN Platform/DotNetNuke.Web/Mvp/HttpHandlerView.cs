﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Mvp
{
    using System;

    using WebFormsMvp.Web;

    /// <summary>
    /// Implements a custom HTTP handler for a WebForms Model-View-Presenter.
    /// </summary>
    [Obsolete("Deprecated in DNN 9.2.0. Replace WebFormsMvp and DotNetNuke.Web.Mvp with MVC or SPA patterns instead. Scheduled removal in v11.0.0.")]
    public abstract class HttpHandlerView : MvpHttpHandler, IHttpHandlerView
    {
    }
}
