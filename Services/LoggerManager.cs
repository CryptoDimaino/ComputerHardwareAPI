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

namespace ComputerHardware.Services
{
    public class LoggerManager : ILoggerManager
    {
        private readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {

        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
 
        public void LogError(string message)
        {
            logger.Error(message);
        }
 
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
 
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}