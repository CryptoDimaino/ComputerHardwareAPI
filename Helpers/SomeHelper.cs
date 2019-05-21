using NLog;
using System;
using ComputerHardware.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;
using ComputerHardware.Repositories;

namespace ComputerHardware.Helpers
{
    public static class SomeHelper
    {
        public static string LogInfos(ControllerContext cc)
        {
            return $"Controller: {cc.RouteData.Values["controller"].ToString()} - Method: {cc.RouteData.Values["action"].ToString()} -";
        }
    }
}