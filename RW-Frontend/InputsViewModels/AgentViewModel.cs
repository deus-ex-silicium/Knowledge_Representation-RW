﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW_Frontend.InputsViewModels
{
    public class AgentViewModel
    {
        public string Agent { get; set; }

        public AgentViewModel(string agent)
        {
            this.Agent = agent;
        }
    }
}