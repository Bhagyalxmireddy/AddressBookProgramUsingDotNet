using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class NLog
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public void logDebug(String message)
        {
            logger.Debug(message);
       
        }
    }
}
