﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shine.Samples.IRepositories.UOW
{
   public interface IUnitOfWork
   {
       void Commit();
       void RollBack();
   }
}
