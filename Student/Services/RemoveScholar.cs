﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Services
{
    internal class RemoveScholar : ScholarManager
    {
        public void removeScholar()
        {
           // int i = HandleScholarId();
            scholarsList.RemoveAt(0);
        }
    }
}
