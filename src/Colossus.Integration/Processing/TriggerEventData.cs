﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colossus.Integration.Processing
{    
    public class TriggerEventData
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public int? Value { get; set; }
        public bool IsGoal { get; set; }

        public Dictionary<string, object> CustomValues { get; set; }
    }
}
