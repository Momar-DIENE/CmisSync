﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CmisSync.Lib
{
    public static class ConfigManager
    {
        private static Config config;
        public static Config CurrentConfig
        {
            get
            {
                if (config == null) config = new Config(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cmissync"), "config.xml");
                return config;
            }
        }
    }
}
