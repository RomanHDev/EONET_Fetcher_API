﻿using EONET_Fetcher.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EONET_Fetcher.Models
{
    public class EventGeometry : IEventGeometry
    {
        public DateTime Date { get; set; }

        public string Type { get; set; }

        public List<Object> Coordinates { get; set; }
    }
}
