using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NLearn.UI.Models;

namespace NLearn.UI.Services
{
    public class SystemService : ServiceBase<SystemService>
    {
        internal async Task<List<UserModel>> GetAllUsersAsync()
        {
            return await base.GetDataFromAPI<List<UserModel>>("user");
        }
    }
}
