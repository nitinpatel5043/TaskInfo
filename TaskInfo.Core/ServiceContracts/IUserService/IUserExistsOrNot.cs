﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInfo.Core.ServiceContracts.IUserService
{
    public interface IUserExistsOrNot
    {
        Task<bool> IsUserExistsOrNotExists(string? userId, Guid? guid);
    }
}
