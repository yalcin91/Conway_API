﻿using Conway.Core.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Core.Model
{
    public class ITB_Tabac : IAssortiment
    {
        public ITB_Tabac(long id, int @ref, string product, long eancode, string fabrikant, string size, double nielsen1, double nielsen2, double nielsen3, double nielsen4, string groupe, string color) : base(id, @ref, product, eancode, fabrikant, size, nielsen1, nielsen2, nielsen3, nielsen4, groupe, color)
        {
        }
    }
}
