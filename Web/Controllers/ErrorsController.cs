﻿// ---------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

namespace Microsoft.Azure.Devices.Applications.PredictiveMaintenance.Web.Controllers
{
    using System.Web.Mvc;

    [AllowAnonymous]
    public sealed class ErrorsController : Controller
    {
        [Route("500")]
        public ActionResult Error()
        {
            return this.View("500");
        }

        [Route("404")]
        public ActionResult NotFound()
        {
            return this.View("404");
        }
    }
}