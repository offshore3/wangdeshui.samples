﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shine.Samples.IRepositories
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();

    }

}
