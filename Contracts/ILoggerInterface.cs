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

namespace ComputerHardware.Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(ControllerContext ControllerContext, string Message);
        void LogWarn(ControllerContext ControllerContext, string Message);
        void LogDebug(ControllerContext ControllerContext, string Message);
        void LogError(ControllerContext ControllerContext, string Message);
    }
}