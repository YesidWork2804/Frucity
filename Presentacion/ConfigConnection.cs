﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Presentacion
{
    public static class ConfigConnection
    {
        public static string connectionstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
