﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Manager.Config
{
    public static class Configuration
    {
        public static string GetUrl()
        {
            return ConfigurationManager.AppSettings["URL"];
        }
    }
}