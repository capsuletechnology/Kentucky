﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.Helper
{
    public interface ICreateMD5
    {
        string GenerateHash(string input);
    }
}