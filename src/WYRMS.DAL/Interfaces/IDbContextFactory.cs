﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WYRMS.Domain.Model;

namespace WYRMS.DAL.Interfaces
{
    public interface IDbContextFactory
    {
        SysEntities Ctx { get; }
    }
}