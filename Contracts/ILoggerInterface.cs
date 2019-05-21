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
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}