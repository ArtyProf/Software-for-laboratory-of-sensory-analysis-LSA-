﻿using LSA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSA.Interfaces
{
    public interface ITastingHistory
    {
        Task CreateTastingHistory(TastingHistory tastingHistory);
    }
}
