﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockStuff
{

    public interface StockMarketDisplay
    {
          void Update(RealTimeData s);
    }
}
