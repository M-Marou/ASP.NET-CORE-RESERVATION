﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YCReservations.Controllers
{
    public class ErrorController : Controller
    {
            private readonly ILogger<ErrorController> logger;
            public ErrorController(ILogger<ErrorController> logger)
            {
                this.logger = logger;
            }

            [Route("Error/{StatusCode}")]

            public IActionResult Index(int StatusCode)
            {
                string message = string.Empty;
                switch (StatusCode)
                {
                    case 404:
                        {
                            message = "Sorry, The ressource you requested could not be found";
                        }
                        break;
                }
                return View("404Error", message);
            }
   
    }
}
