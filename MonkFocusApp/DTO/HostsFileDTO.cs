﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkFocusApp.DTO
{
    /// <summary>
    /// This class is used to transfer data between data from hosts file to the UI.
    /// </summary>
    public class HostsFileDTO
    {
        public int ID { get; set; }
        public string Content { get; set; }
    }
}
