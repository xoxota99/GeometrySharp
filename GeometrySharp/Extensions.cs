﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometrySharp
{
    public static class Extensions
    {
        public static float Bucketise(this float f, float bucketsize)
        {
            return f - f % bucketsize;
        }
    }
}
