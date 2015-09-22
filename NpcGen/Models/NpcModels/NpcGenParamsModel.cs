﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NpcGen.Models.NpcModels
{
    public class NpcGenParamsModel
    {
        // Modifiers

        [DisplayName("Freakishly strong")]
        public bool MoreStr { get; set; }

        [DisplayName("Lightning fast")]
        public bool MoreDex { get; set; }

        [DisplayName("Impervious to pain")]
        public bool MoreCon { get; set; }

        [DisplayName("Smarter than the average NPC")]
        public bool MoreInt { get; set; }

        [DisplayName("Deep and insightful")]
        public bool MoreWis { get; set; }

        [DisplayName("Inner fire")]
        public bool MoreCha { get; set; }
    }
}