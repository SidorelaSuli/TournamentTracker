﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel Create(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
